namespace KeyvaultSecretsUpdater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.whatsappSystemTokenTB = new System.Windows.Forms.TextBox();
            this.whatsappCallbackTokenTB = new System.Windows.Forms.TextBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.PublicCB = new System.Windows.Forms.ComboBox();
            this.InternalCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputRT = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OrgIDTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SMSFuncTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WhatsAppFuncTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RESTFuncTB = new System.Windows.Forms.TextBox();
            this.PrimaryEmailTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.APIClientIDTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SMSEndpointTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UpdateAPISecretCheck = new System.Windows.Forms.CheckBox();
            this.UpdateStorageCheck = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.smsTemplateTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "WhatsApp System Access Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "WhatsApp Callback Token:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // whatsappSystemTokenTB
            // 
            this.whatsappSystemTokenTB.Location = new System.Drawing.Point(198, 85);
            this.whatsappSystemTokenTB.Name = "whatsappSystemTokenTB";
            this.whatsappSystemTokenTB.PlaceholderText = "Only need if WhatsApp is used";
            this.whatsappSystemTokenTB.Size = new System.Drawing.Size(409, 23);
            this.whatsappSystemTokenTB.TabIndex = 3;
            // 
            // whatsappCallbackTokenTB
            // 
            this.whatsappCallbackTokenTB.Location = new System.Drawing.Point(198, 114);
            this.whatsappCallbackTokenTB.Name = "whatsappCallbackTokenTB";
            this.whatsappCallbackTokenTB.PlaceholderText = "Only need if WhatsApp is used";
            this.whatsappCallbackTokenTB.Size = new System.Drawing.Size(409, 23);
            this.whatsappCallbackTokenTB.TabIndex = 4;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(613, 27);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(113, 54);
            this.UpdateBTN.TabIndex = 5;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // PublicCB
            // 
            this.PublicCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublicCB.FormattingEnabled = true;
            this.PublicCB.Location = new System.Drawing.Point(198, 27);
            this.PublicCB.Name = "PublicCB";
            this.PublicCB.Size = new System.Drawing.Size(409, 23);
            this.PublicCB.TabIndex = 6;
            // 
            // InternalCB
            // 
            this.InternalCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InternalCB.FormattingEnabled = true;
            this.InternalCB.Location = new System.Drawing.Point(198, 56);
            this.InternalCB.Name = "InternalCB";
            this.InternalCB.Size = new System.Drawing.Size(409, 23);
            this.InternalCB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Public Vault:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Internal Vault:";
            // 
            // OutputRT
            // 
            this.OutputRT.Location = new System.Drawing.Point(12, 445);
            this.OutputRT.Name = "OutputRT";
            this.OutputRT.Size = new System.Drawing.Size(714, 182);
            this.OutputRT.TabIndex = 10;
            this.OutputRT.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dynamics Organization ID:";
            // 
            // OrgIDTB
            // 
            this.OrgIDTB.Location = new System.Drawing.Point(198, 143);
            this.OrgIDTB.Name = "OrgIDTB";
            this.OrgIDTB.PlaceholderText = "Only needed for dataverse";
            this.OrgIDTB.Size = new System.Drawing.Size(409, 23);
            this.OrgIDTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "SMS Function Object ID:";
            // 
            // SMSFuncTB
            // 
            this.SMSFuncTB.Location = new System.Drawing.Point(198, 172);
            this.SMSFuncTB.Name = "SMSFuncTB";
            this.SMSFuncTB.PlaceholderText = "Only need if SMS is used";
            this.SMSFuncTB.Size = new System.Drawing.Size(409, 23);
            this.SMSFuncTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "WhatsApp Function Object ID:";
            // 
            // WhatsAppFuncTB
            // 
            this.WhatsAppFuncTB.Location = new System.Drawing.Point(198, 201);
            this.WhatsAppFuncTB.Name = "WhatsAppFuncTB";
            this.WhatsAppFuncTB.PlaceholderText = "Only need if WhatsApp is used";
            this.WhatsAppFuncTB.Size = new System.Drawing.Size(409, 23);
            this.WhatsAppFuncTB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cosmos Rest Function Object ID:";
            // 
            // RESTFuncTB
            // 
            this.RESTFuncTB.Location = new System.Drawing.Point(198, 230);
            this.RESTFuncTB.Name = "RESTFuncTB";
            this.RESTFuncTB.PlaceholderText = "Only needed for cosmos";
            this.RESTFuncTB.Size = new System.Drawing.Size(409, 23);
            this.RESTFuncTB.TabIndex = 19;
            // 
            // PrimaryEmailTB
            // 
            this.PrimaryEmailTB.Location = new System.Drawing.Point(198, 259);
            this.PrimaryEmailTB.Name = "PrimaryEmailTB";
            this.PrimaryEmailTB.PlaceholderText = "Auto Archiving Email Address";
            this.PrimaryEmailTB.Size = new System.Drawing.Size(409, 23);
            this.PrimaryEmailTB.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Primary System Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "API Client ID:";
            // 
            // APIClientIDTB
            // 
            this.APIClientIDTB.Location = new System.Drawing.Point(198, 288);
            this.APIClientIDTB.Name = "APIClientIDTB";
            this.APIClientIDTB.PlaceholderText = "API Registration Applicatrion ID";
            this.APIClientIDTB.Size = new System.Drawing.Size(409, 23);
            this.APIClientIDTB.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Leave fields you want to skip blank";
            // 
            // SMSEndpointTB
            // 
            this.SMSEndpointTB.Location = new System.Drawing.Point(198, 317);
            this.SMSEndpointTB.Name = "SMSEndpointTB";
            this.SMSEndpointTB.PlaceholderText = "Connection String for Azure Communications";
            this.SMSEndpointTB.Size = new System.Drawing.Size(409, 23);
            this.SMSEndpointTB.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "SMS Endpoint:";
            // 
            // UpdateAPISecretCheck
            // 
            this.UpdateAPISecretCheck.AutoSize = true;
            this.UpdateAPISecretCheck.Location = new System.Drawing.Point(12, 375);
            this.UpdateAPISecretCheck.Name = "UpdateAPISecretCheck";
            this.UpdateAPISecretCheck.Size = new System.Drawing.Size(273, 19);
            this.UpdateAPISecretCheck.TabIndex = 27;
            this.UpdateAPISecretCheck.Text = "Define New Application Registration API Secret";
            this.UpdateAPISecretCheck.UseVisualStyleBackColor = true;
            // 
            // UpdateStorageCheck
            // 
            this.UpdateStorageCheck.AutoSize = true;
            this.UpdateStorageCheck.Location = new System.Drawing.Point(12, 400);
            this.UpdateStorageCheck.Name = "UpdateStorageCheck";
            this.UpdateStorageCheck.Size = new System.Drawing.Size(221, 19);
            this.UpdateStorageCheck.TabIndex = 28;
            this.UpdateStorageCheck.Text = "Update Storage Account Primary Key";
            this.UpdateStorageCheck.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "SMS 24 Hour Template Response:";
            // 
            // smsTemplateTB
            // 
            this.smsTemplateTB.Location = new System.Drawing.Point(198, 346);
            this.smsTemplateTB.Name = "smsTemplateTB";
            this.smsTemplateTB.PlaceholderText = "Only need if SMS is used";
            this.smsTemplateTB.Size = new System.Drawing.Size(409, 23);
            this.smsTemplateTB.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 639);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.smsTemplateTB);
            this.Controls.Add(this.UpdateStorageCheck);
            this.Controls.Add(this.UpdateAPISecretCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SMSEndpointTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.APIClientIDTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrimaryEmailTB);
            this.Controls.Add(this.RESTFuncTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WhatsAppFuncTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SMSFuncTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrgIDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputRT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InternalCB);
            this.Controls.Add(this.PublicCB);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.whatsappCallbackTokenTB);
            this.Controls.Add(this.whatsappSystemTokenTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secrets Updater";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button UpdateBTN;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox OrgIDTB;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        internal TextBox whatsappSystemTokenTB;
        internal TextBox whatsappCallbackTokenTB;
        internal RichTextBox OutputRT;
        internal TextBox SMSFuncTB;
        internal TextBox WhatsAppFuncTB;
        internal TextBox RESTFuncTB;
        private Label label11;
        private Label label12;
        private Label label13;
        internal TextBox SMSEndpointTB;
        internal TextBox APIClientIDTB;
        internal TextBox PrimaryEmailTB;
        internal CheckBox UpdateAPISecretCheck;
        internal CheckBox UpdateStorageCheck;
        internal ComboBox PublicCB;
        internal ComboBox InternalCB;
        private Label label14;
        internal TextBox smsTemplateTB;
    }
}