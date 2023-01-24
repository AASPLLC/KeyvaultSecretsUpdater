# KeyvaultSecretsUpdater

Key Vault Secrets Updater - Manually updates secrets in case an internal change needs to happen in the providers environment.

The public Key Vault will need to have users added to it in order to use the Microsoft Teams Application.

Reference for adding users to RBAC: https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal

The role users or a group of users will need is: Key Vault Secrets User

The SecretNames.json file is specific to Key Vault secret names and is required for the application to update secrets correctly.

These values must be specific, but for reference, this is the format:
```
{
  "PDynamicsEnvironment": "",
  "PAccountsDBPrefix": "",
  "PSMSDBPrefix": "",
  "PWhatsAppDBPrefix": "",
  "PCommsEndpoint": "",
  "PWhatsAppAccess": "",
  "PTenantID": "",
  "IoOrgID": "",
  "IoClientID": "",
  "IoSecret": "",
  "IoEmail": "",
  "IoJobs": "",
  "IoCallback": "",
  "Type": "",
  "IoCosmos": "",
  "IoKey": "",
  "RESTSite": "",
  "DbName": "",
  "DbName1": "",
  "DbName2": "",
  "DbName3": ""
}
```

This application is dependent on the following library: [AASP Global Library](https://github.com/wrharper/AASPGlobalLibrary)
