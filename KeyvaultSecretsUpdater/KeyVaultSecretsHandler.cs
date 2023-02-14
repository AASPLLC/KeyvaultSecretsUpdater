using AASPGlobalLibrary;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.KeyVault;
using Azure;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;
using Azure.ResourceManager.AppService;
using Azure.Security.KeyVault.Secrets;

namespace KeyvaultSecretsUpdater
{
    public class JSONSecretNames
    {
        public string? PDynamicsEnvironment { get; set; }
        public string? PAccountsDBPrefix { get; set; }
        public string? PSMSDBPrefix { get; set; }
        public string? PWhatsAppDBPrefix { get; set; }
        public string? PPhoneNumberDBPrefix { get; set; }
        public string? PCommsEndpoint { get; set; }
        public string? PWhatsAppAccess { get; set; }
        public string? PTenantID { get; set; }
        public string? IoOrgID { get; set; }
        public string? IoClientID { get; set; }
        public string? IoSecret { get; set; }
        public string? IoEmail { get; set; }
        public string? IoJobs { get; set; }
        public string? IoCallback { get; set; }
        public string? Type { get; set; }
        public string? IoCosmos { get; set; }
        public string? IoKey { get; set; }
        public string? RESTSite { get; set; }
        public string? DbName { get; set; }
        public string? DbName1 { get; set; }
        public string? DbName2 { get; set; }
        public string? DbName3 { get; set; }
        public string? DbName4 { get; set; }
        public string? DbName5 { get; set; }
        public string? AutomationId { get; set; }
        public string? SMSTemplate { get; set; }
    }

    public class KeyVaultSecretsHandler
    {
        static async Task CreateSecret(VaultResource vr, string key, string value)
        {
            try
            {
                SecretClient sc = TokenHandler.GetFunctionAppKeyVaultClient("https://" + vr.Data.Name + ".vault.azure.net/");
                if ((await sc.GetSecretAsync(key)).Value.Value != value)
                {
                    await foreach (var version in (sc.GetPropertiesOfSecretVersionsAsync(key)))
                    {
                        if (version.Enabled == true)
                        {
                            version.Enabled = false;
                            await sc.UpdateSecretPropertiesAsync(version);
                        }
                    }
                    await vr.GetSecrets().CreateOrUpdateAsync(WaitUntil.Completed, key, new SecretCreateOrUpdateContent(new()
                    {
                        Value = value
                    }));
                }
            }
            catch
            {
                await vr.GetSecrets().CreateOrUpdateAsync(WaitUntil.Completed, key, new SecretCreateOrUpdateContent(new()
                {
                    Value = value
                }));
            }
        }

        public static async Task CreateKeyVaultSecrets(string DBType, Guid TenantID, JSONSecretNames secretNames, VaultResource publicVault, VaultResource internalVault, Form1 form)
        {
#pragma warning disable CS8601
            string[] databases = { secretNames.DbName1, secretNames.DbName2, secretNames.DbName3, secretNames.DbName4, secretNames.DbName5 };
#pragma warning restore CS8601
            await CreateOrUpdatePublicSecretsDV(DBType, publicVault, secretNames, databases, form);
            await CreateOrUpdateInternalVaultDV(DBType, TenantID, internalVault, secretNames, databases, form);

            //can't think of a reason why this would be required...
            /*foreach (var item in form.SelectedGroup.GetCosmosDBAccounts())
            {
                if (item.Data.Name == secretNames.DbName)
                {
#pragma warning disable CS8604
                    CreateSecret(internalVault, secretNames.IoCosmos, item.Data.Name);
                    CreateSecret(internalVault, secretNames.IoKey, (await item.GetKeysAsync()).Value.PrimaryReadonlyMasterKey);
#pragma warning restore CS8604
                    break;
                }
            }*/

            form.OutputRT.Text += Environment.NewLine + "Key Vault secrets updated and locked by RBAC access.";
        }
        static async Task CreateOrUpdatePublicSecretsDV(string DBType, VaultResource publicVault, JSONSecretNames secretNames, string[] databases, Form1 form)
        {
            if (form.DbType == 0)
            {
                form.OutputRT.Text += Environment.NewLine + "Public Vault: Updating selected environment, dataverse prefixes, and making sure type is dataverse";
#pragma warning disable CS8604 // Possible null reference argument.
                if (!form.smsTemplateTB.Text.Contains("COMPANYNAMEHERE") && form.smsTemplateTB.Text != "")
                    await CreateSecret(publicVault, secretNames.SMSTemplate, form.smsTemplateTB.Text);
                await CreateSecret(publicVault, secretNames.PDynamicsEnvironment, form.SelectedEnvironment);
                await CreateSecret(publicVault, secretNames.PAccountsDBPrefix, databases[0].ToLower() + "eses");
                await CreateSecret(publicVault, secretNames.PSMSDBPrefix, databases[1].ToLower() + "eses");
                await CreateSecret(publicVault, secretNames.PWhatsAppDBPrefix, databases[2].ToLower() + "eses");
                await CreateSecret(publicVault, secretNames.PPhoneNumberDBPrefix, databases[3].ToLower() + "eses");
            }
            form.OutputRT.Text += Environment.NewLine + "Public Vault: Updating selected database type";
            await CreateSecret(publicVault, secretNames.Type, DBType);
            if (form.SMSEndpointTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Public Vault: Updating SMS endpoint";
                await CreateSecret(publicVault, secretNames.PCommsEndpoint, form.SMSEndpointTB.Text);
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Public Vault: Skipping SMS endpoint";
            if (form.whatsappSystemTokenTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Public Vault: Updating WhatsApp token";
                if (form.whatsappSystemTokenTB.Text.StartsWith("Bearer "))
                    await CreateSecret(publicVault, secretNames.PWhatsAppAccess, form.whatsappSystemTokenTB.Text);
                else
                    await CreateSecret(publicVault, secretNames.PWhatsAppAccess, "Bearer " + form.whatsappSystemTokenTB.Text);
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Public Vault: Skipping WhatsApp token";

            VaultProperties properties = publicVault.Data.Properties;
            properties.EnabledForTemplateDeployment = false;
            VaultCreateOrUpdateContent content = new(form.SelectedRegion, properties);
            _ = (await form.SelectedGroup.GetVaults().CreateOrUpdateAsync(WaitUntil.Completed, publicVault.Data.Name, content)).Value;

            form.OutputRT.Text += Environment.NewLine + "Public Vault: Finished";
        }
        static async Task CreateOrUpdateInternalVaultDV(string DBType, Guid TenantID, VaultResource internalVault, JSONSecretNames secretNames, string[] databases, Form1 form)
        {
            if (form.DbType == 0)
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating selected environment, dataverse prefixes, and making sure type is dataverse";
                await CreateSecret(internalVault, secretNames.PDynamicsEnvironment, form.SelectedEnvironment);
                await CreateSecret(internalVault, secretNames.PAccountsDBPrefix, databases[0].ToLower() + "eses");
                await CreateSecret(internalVault, secretNames.PSMSDBPrefix, databases[1].ToLower() + "eses");
                await CreateSecret(internalVault, secretNames.PWhatsAppDBPrefix, databases[2].ToLower() + "eses");
                await CreateSecret(internalVault, secretNames.PPhoneNumberDBPrefix, databases[3].ToLower() + "eses");
                if (form.SelectedOrgId != "")
                {
                    form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating dataverse organization id";
                    await CreateSecret(internalVault, secretNames.IoOrgID, form.SelectedOrgId);
                }
                else
                    form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping dataverse organization id";
            }
            form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating selected database type";
            await CreateSecret(internalVault, secretNames.Type, DBType);
            if (form.APIClientIDTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating API Client ID";
                await CreateSecret(internalVault, secretNames.IoClientID, form.APIClientIDTB.Text);
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping API Client ID";
            if (form.UpdateAPISecretCheck.Checked)
            {
                SecuredExistingSecret securedExistingSecret = new();
                securedExistingSecret.ShowDialog();
                if (securedExistingSecret.GetSecuredString() != "")
                {
                    form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating API Client Secret";
                    await CreateSecret(internalVault, secretNames.IoSecret, securedExistingSecret.GetSecuredString());
                }
                securedExistingSecret.Dispose();
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping API Client Secret";
            if (form.UpdateStorageCheck.Checked)
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating storage primary url";
                foreach (var storageAccount in form.SelectedGroup.GetStorageAccounts())
                {
                    Page<StorageAccountKey>[] keys = storageAccount.GetKeys().AsPages().ToArray();
                    string urlPrimary = "DefaultEndpointsProtocol=https;AccountName=" + storageAccount.Data.Name + ";AccountKey=" + keys[0].Values[0].Value + ";EndpointSuffix=core.windows.net";
                    await CreateSecret(internalVault, secretNames.IoJobs, urlPrimary);
                    break;
                }
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping storage primary url";
            if (form.PrimaryEmailTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating primary system email";
                await CreateSecret(internalVault, secretNames.IoEmail, form.PrimaryEmailTB.Text);
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping primary system email";
            if (form.whatsappCallbackTokenTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating WhatsApp callback token";
                await CreateSecret(internalVault, secretNames.IoCallback, form.whatsappCallbackTokenTB.Text);
            }
            else
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Skipping WhatsApp callback token";
#pragma warning restore CS8604 // Possible null reference argument.

            var properties = internalVault.Data.Properties;
            properties.EnabledForTemplateDeployment = false;
            properties.EnableRbacAuthorization = false;
            AccessPermissions permissions = new();
            permissions.Secrets.Add(SecretPermissions.Get);
            if (form.SMSFuncTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating access policy for SMS object id";
                properties.AccessPolicies.Add(new(TenantID, form.SMSFuncTB.Text, permissions));
            }
            else
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Using existing SMS object id for access policy";
                foreach (var item in form.SelectedGroup.GetWebSites())
                {
                    if (item.Data.Name.EndsWith("SMSApp"))
                    {
                        properties.AccessPolicies.Add(new(TenantID, item.Data.Name, permissions));
                        break;
                    }
                }
            }
            if (form.WhatsAppFuncTB.Text != "")
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Updating access policy for WhatsApp object id";
                properties.AccessPolicies.Add(new(TenantID, form.WhatsAppFuncTB.Text, permissions));
            }
            else
            {
                form.OutputRT.Text += Environment.NewLine + "Internal Vault: Using existing WhatsApp object id for access policy";
                foreach (var item in form.SelectedGroup.GetWebSites())
                {
                    if (item.Data.Name.EndsWith("WhatsApp"))
                    {
                        properties.AccessPolicies.Add(new(TenantID, item.Data.Name, permissions));
                        break;
                    }
                }
            }
            VaultCreateOrUpdateContent content = new(form.SelectedRegion, properties);
            _ = (await form.SelectedGroup.GetVaults().CreateOrUpdateAsync(WaitUntil.Completed, internalVault.Data.Name, content)).Value;

            form.OutputRT.Text += Environment.NewLine + "Internal Vault: Finished";
        }
    }
}
