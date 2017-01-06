namespace WebRipGUI
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
            this.btnGetPledges = new System.Windows.Forms.Button();
            this.txtboxURL = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.btnSaveEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetPledges
            // 
            this.btnGetPledges.Location = new System.Drawing.Point(13, 66);
            this.btnGetPledges.Name = "btnGetPledges";
            this.btnGetPledges.Size = new System.Drawing.Size(100, 23);
            this.btnGetPledges.TabIndex = 0;
            this.btnGetPledges.Text = "Get Pledges";
            this.btnGetPledges.UseVisualStyleBackColor = true;
            this.btnGetPledges.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxURL
            // 
            this.txtboxURL.Location = new System.Drawing.Point(13, 34);
            this.txtboxURL.Name = "txtboxURL";
            this.txtboxURL.Size = new System.Drawing.Size(330, 20);
            this.txtboxURL.TabIndex = 1;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(13, 141);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(220, 20);
            this.txtboxEmail.TabIndex = 2;
            // 
            // btnSaveEmail
            // 
            this.btnSaveEmail.Location = new System.Drawing.Point(13, 168);
            this.btnSaveEmail.Name = "btnSaveEmail";
            this.btnSaveEmail.Size = new System.Drawing.Size(100, 23);
            this.btnSaveEmail.TabIndex = 3;
            this.btnSaveEmail.Text = "Save Email";
            this.btnSaveEmail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 477);
            this.Controls.Add(this.btnSaveEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxURL);
            this.Controls.Add(this.btnGetPledges);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPledges;
        private System.Windows.Forms.TextBox txtboxURL;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Button btnSaveEmail;
    }
}

