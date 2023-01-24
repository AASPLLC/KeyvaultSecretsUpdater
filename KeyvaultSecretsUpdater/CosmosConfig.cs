using Azure.ResourceManager.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeyvaultSecretsUpdater
{
    public partial class CosmosConfig : Form
    {
        List<SubscriptionResource> subids = new();

        readonly ChooseDBType ChooseDBType;
        public CosmosConfig(ChooseDBType chooseDBType)
        {
            InitializeComponent();
            ChooseDBType = chooseDBType;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChooseDBType.form.SelectedSubscription = subids[comboBox1.SelectedIndex];
            this.Close();
        }

        private void CosmosConfig_Load(object sender, EventArgs e)
        {
            ChooseDBType.form.Arm = new ArmClientHandler();
            //List<string> names = new();
            (List<string> names, subids) = ChooseDBType.form.Arm.SetupSubscriptionName();
            comboBox1.Items.AddRange(names.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void CosmosConfig_Closed(object sender, FormClosedEventArgs e)
        {
            ChooseDBType.form.Init();
        }
    }
}
