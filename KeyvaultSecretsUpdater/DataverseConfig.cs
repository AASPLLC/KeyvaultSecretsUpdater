using Azure.Core;
using Azure.ResourceManager.Resources;
using System.Net.Http.Headers;
using AASPGlobalLibrary;
using KeyvaultSecretsUpdater;

namespace SMSAndWhatsAppDeploymentTool
{
    public partial class DataverseConfig : Form
    {
        readonly ChooseDBType ChooseDBType;
        public DataverseConfig(ChooseDBType ChooseDBType)
        {
            InitializeComponent();
            this.ChooseDBType = ChooseDBType;
        }

        List<SubscriptionResource> subids = new();
        dynamic? info;

        private async void InstallConfig_Load(object sender, EventArgs e)
        {
            ChooseDBType.form.Arm = new ArmClientHandler();
            //List<string> names = new();
            (List<string> names, subids) = ChooseDBType.form.Arm.SetupSubscriptionName();
            comboBox1.Items.AddRange(names.ToArray());
            comboBox1.SelectedIndex = 0;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", await TokenHandler.GetGlobalDynamicsImpersonationToken());
            HttpRequestMessage request = new(new HttpMethod("GET"), Globals.Dynamics365Distro);
            var response = await httpClient.SendAsync(request);
            info = Globals.DynamicJsonDeserializer(await response.Content.ReadAsStringAsync());

            if (info.value.Count > 0)
            {
                for (int i = 0; i < info.value.Count; i++)
                {
                    comboBox2.Items.Add(info.value[i].FriendlyName);
                }
                comboBox2.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChooseDBType.form.SelectedSubscription = subids[comboBox1.SelectedIndex];

            button1.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = true;
            comboBox2.Enabled = true;
            subids.Clear();
        }

        private void InstallConfig_Closed(object sender, FormClosedEventArgs e)
        {
            ChooseDBType.form.Init();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Converting null literal or possible null value to non-nullable type.
            ChooseDBType.form.SelectedEnvironment = info.value[comboBox2.SelectedIndex].UrlName;
            ChooseDBType.form.SelectedOrgId = info.value[comboBox2.SelectedIndex].Id;
#pragma warning restore CS8602 // Converting null literal or possible null value to non-nullable type.

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
