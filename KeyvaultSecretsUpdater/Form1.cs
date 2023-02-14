using Azure.ResourceManager.Resources;
using Azure.ResourceManager.KeyVault;
using AASPGlobalLibrary;
using Azure.Core;

namespace KeyvaultSecretsUpdater
{
    public partial class Form1 : Form
    {
        public SubscriptionResource? SelectedSubscription;
        public ResourceGroupResource? SelectedGroup;
        public string? SelectedEnvironment;
        public string? SelectedOrgId;
        public ArmClientHandler? Arm { get; set; }
        public AzureLocation SelectedRegion;
        public Guid? TenantID;
        public VaultResource? PublicV;
        public VaultResource? InternalV;

        public int DbType = 0;
        JSONSecretNames? secretNames;

        public Form1()
        {
            InitializeComponent();
            _ = new SetConsoleOutput(OutputRT);
        }
        private async void Form_Load(object sender, EventArgs e)
        {
            secretNames = await Globals.LoadJSON<JSONSecretNames>(Environment.CurrentDirectory + "/JSONS/SecretNames.json");
            ChooseDBType dbType = new(this);
            this.Hide();
            dbType.ShowDialog(this);
        }

        public void SetDBType(int type)
        {
            DbType = type;
        }

        public void Init()
        {
            PublicCB.Enabled = false;
            InternalCB.Enabled = false;
            UpdateBTN.Enabled = false;
            this.Show();
            if (SelectedSubscription != null)
            {
                TenantID = SelectedSubscription.Data.TenantId;
                SelectedGroup = SelectedSubscription.GetResourceGroup("SMSAndWhatsAppResourceGroup");
            }
            if (SelectedGroup != null)
                SelectedRegion = SelectedGroup.Data.Location;
            PublicCB.Items.Add("");
            InternalCB.Items.Add("");
            foreach (var vault in SelectedGroup.GetVaults())
            {
                PublicCB.Items.Add(vault.Data.Name);
                InternalCB.Items.Add(vault.Data.Name);
            }
            PublicCB.Enabled = true;
            InternalCB.Enabled = true;
            UpdateBTN.Enabled = true;
        }

        private async void UpdateBTN_Click(object sender, EventArgs e)
        {

            if (DbType == 0)
            {
#pragma warning disable CS8604
#pragma warning disable CS8629
                await KeyVaultSecretsHandler.CreateKeyVaultSecrets("0", TenantID.Value, secretNames, PublicV, InternalV, this);
#pragma warning restore CS8604
#pragma warning restore CS8629
            }
            else if (DbType == 1)
            {
#pragma warning disable CS8604
#pragma warning disable CS8629
                await KeyVaultSecretsHandler.CreateKeyVaultSecrets("1", TenantID.Value, secretNames, PublicV, InternalV, this);
#pragma warning restore CS8604
#pragma warning restore CS8629
            }
        }
    }
}