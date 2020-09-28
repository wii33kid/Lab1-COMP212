namespace Lab1_COMP212.Views
{
    partial class Publish_Notifcation
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
            this.btnpub = new System.Windows.Forms.Button();
            this.btnexit2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnpub
            // 
            this.btnpub.Location = new System.Drawing.Point(124, 213);
            this.btnpub.Name = "btnpub";
            this.btnpub.Size = new System.Drawing.Size(107, 31);
            this.btnpub.TabIndex = 0;
            this.btnpub.Text = "Publish";
            this.btnpub.UseVisualStyleBackColor = true;
            this.btnpub.Click += new System.EventHandler(this.btnpub_Click);
            // 
            // btnexit2
            // 
            this.btnexit2.Location = new System.Drawing.Point(355, 213);
            this.btnexit2.Name = "btnexit2";
            this.btnexit2.Size = new System.Drawing.Size(108, 31);
            this.btnexit2.TabIndex = 1;
            this.btnexit2.Text = "Exit";
            this.btnexit2.UseVisualStyleBackColor = true;
            this.btnexit2.Click += new System.EventHandler(this.btnexit2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(121, 117);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Notifcation Content";
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(287, 117);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(248, 20);
            this.txtcontent.TabIndex = 3;
            this.txtcontent.TextChanged += new System.EventHandler(this.txtcontent_TextChanged);
            // 
            // Publish_Notifcation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 288);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnexit2);
            this.Controls.Add(this.btnpub);
            this.Name = "Publish_Notifcation";
            this.Text = "Publish_Notifcation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpub;
        private System.Windows.Forms.Button btnexit2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtcontent;
    }
}