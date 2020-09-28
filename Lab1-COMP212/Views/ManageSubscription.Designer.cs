namespace Lab1_COMP212.Views
{
    partial class ManageSubscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsub = new System.Windows.Forms.Button();
            this.btnun = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.chkemail = new System.Windows.Forms.CheckBox();
            this.chksms = new System.Windows.Forms.CheckBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsms = new System.Windows.Forms.TextBox();
            this.lblinvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(115, 266);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(105, 41);
            this.btnsub.TabIndex = 0;
            this.btnsub.Text = "Subscribe";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnun
            // 
            this.btnun.Location = new System.Drawing.Point(280, 266);
            this.btnun.Name = "btnun";
            this.btnun.Size = new System.Drawing.Size(99, 41);
            this.btnun.TabIndex = 1;
            this.btnun.Text = "Unsubscribe";
            this.btnun.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(475, 266);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 41);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // chkemail
            // 
            this.chkemail.AutoSize = true;
            this.chkemail.Location = new System.Drawing.Point(115, 94);
            this.chkemail.Name = "chkemail";
            this.chkemail.Size = new System.Drawing.Size(145, 17);
            this.chkemail.TabIndex = 3;
            this.chkemail.Text = "Notifcation Sent By Email";
            this.chkemail.UseVisualStyleBackColor = true;
            this.chkemail.CheckedChanged += new System.EventHandler(this.chkemail_CheckedChanged);
            // 
            // chksms
            // 
            this.chksms.AutoSize = true;
            this.chksms.Location = new System.Drawing.Point(115, 197);
            this.chksms.Name = "chksms";
            this.chksms.Size = new System.Drawing.Size(143, 17);
            this.chksms.TabIndex = 4;
            this.chksms.Text = "Notifcation Sent By SMS";
            this.chksms.UseVisualStyleBackColor = true;
            this.chksms.CheckedChanged += new System.EventHandler(this.chksms_CheckedChanged);
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(333, 94);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(223, 20);
            this.txtemail.TabIndex = 5;
            // 
            // txtsms
            // 
            this.txtsms.Enabled = false;
            this.txtsms.Location = new System.Drawing.Point(333, 194);
            this.txtsms.Name = "txtsms";
            this.txtsms.Size = new System.Drawing.Size(223, 20);
            this.txtsms.TabIndex = 6;
            // 
            // lblinvalid
            // 
            this.lblinvalid.AutoSize = true;
            this.lblinvalid.Location = new System.Drawing.Point(330, 146);
            this.lblinvalid.Name = "lblinvalid";
            this.lblinvalid.Size = new System.Drawing.Size(107, 13);
            this.lblinvalid.TabIndex = 7;
            this.lblinvalid.Text = "Invalid Email Address";
            // 
            // ManageSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 358);
            this.Controls.Add(this.lblinvalid);
            this.Controls.Add(this.txtsms);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.chksms);
            this.Controls.Add(this.chkemail);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnun);
            this.Controls.Add(this.btnsub);
            this.Name = "ManageSubscription";
            this.Text = "ManageSubscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnun;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.CheckBox chkemail;
        private System.Windows.Forms.CheckBox chksms;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsms;
        private System.Windows.Forms.Label lblinvalid;
    }
}