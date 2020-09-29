namespace Lab1_COMP212
{
    partial class Form1
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
            this.btnms = new System.Windows.Forms.Button();
            this.btnpn = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnms
            // 
            this.btnms.Location = new System.Drawing.Point(50, 113);
            this.btnms.Name = "btnms";
            this.btnms.Size = new System.Drawing.Size(185, 55);
            this.btnms.TabIndex = 0;
            this.btnms.Text = "Manage Subscription";
            this.btnms.UseVisualStyleBackColor = false;
            this.btnms.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpn
            // 
            this.btnpn.Location = new System.Drawing.Point(292, 113);
            this.btnpn.Name = "btnpn";
            this.btnpn.Size = new System.Drawing.Size(183, 55);
            this.btnpn.TabIndex = 1;
            this.btnpn.Text = "Publish Notifcation";
            this.btnpn.UseVisualStyleBackColor = true;
            this.btnpn.Click += new System.EventHandler(this.btnpn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(544, 113);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 55);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 243);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpn);
            this.Controls.Add(this.btnms);
            this.Name = "Form1";
            this.Text = "Notifcation Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnms;
        private System.Windows.Forms.Button btnpn;
        private System.Windows.Forms.Button btnexit;

        // Hello
    }
}

