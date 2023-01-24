using Azure.Core;
using Azure.ResourceManager.Resources;
using AASPGlobalLibrary;

namespace KeyvaultSecretsUpdater
{
    public partial class Form1 : Form
    {
        public SubscriptionResource? SelectedSubscription;
        public ResourceGroupResource? SelectedGroup;
        public string? SelectedEnvironment;
        public string? SelectedOrgId;
        public ArmClientHandler? Arm { get; set; }
        int DbType = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ChooseDBType dbType = new(this);
            dbType.ShowDialog();
            this.Hide();
        }

        public void SetDBType(int type)
        {
            DbType = type;
        }

        public async Task Init()
        {
            if (DbType == 0)
            {

            }
            else if (DbType == 1)
            {

            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {

        }
    }
}