using AASPGlobalLibrary;
using SMSAndWhatsAppDeploymentTool;

namespace KeyvaultSecretsUpdater
{
    public partial class ChooseDBType : Form
    {
        public Form1 form;

        public ChooseDBType(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.OpenLink("https://digitalpocketdevelopment.sharepoint.com/:w:/r/sites/DigitalPocketDeveloment-Test2/_layouts/15/Doc.aspx?sourcedoc=%7BEBE2A2F7-FB72-45B6-857B-844A27B69083%7D&file=DatabaseTypes.docx&action=default&mobileredirect=true");
        }

        private void DataverseBTN_Click(object sender, EventArgs e)
        {
            form.SetDBType(0);
            DataverseConfig dataverse = new(this);
            this.Hide();
            dataverse.ShowDialog();
        }

        private void CosmosBTN_Click(object sender, EventArgs e)
        {
            form.SetDBType(1);
            this.Hide();
        }

        public IntPtr windowHandle;
        private void ChooseDBType_Load(object sender, EventArgs e)
        {
            windowHandle = Handle;
            NativeWindow nativeWindow = new();
            nativeWindow.AssignHandle(windowHandle);
        }
    }
}
