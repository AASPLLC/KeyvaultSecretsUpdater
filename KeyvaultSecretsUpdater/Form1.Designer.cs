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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "WhatsApp System Access Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "WhatsApp Callback Token:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // whatsappSystemTokenTB
            // 
            this.whatsappSystemTokenTB.Location = new System.Drawing.Point(197, 300);
            this.whatsappSystemTokenTB.Name = "whatsappSystemTokenTB";
            this.whatsappSystemTokenTB.Size = new System.Drawing.Size(409, 23);
            this.whatsappSystemTokenTB.TabIndex = 3;
            // 
            // whatsappCallbackTokenTB
            // 
            this.whatsappCallbackTokenTB.Location = new System.Drawing.Point(197, 329);
            this.whatsappCallbackTokenTB.Name = "whatsappCallbackTokenTB";
            this.whatsappCallbackTokenTB.Size = new System.Drawing.Size(409, 23);
            this.whatsappCallbackTokenTB.TabIndex = 4;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(226, 368);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(153, 36);
            this.UpdateBTN.TabIndex = 5;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 416);
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
        private TextBox whatsappSystemTokenTB;
        private TextBox whatsappCallbackTokenTB;
        private Button UpdateBTN;
    }
}