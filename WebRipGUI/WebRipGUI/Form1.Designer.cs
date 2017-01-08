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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxHTML = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetPledges
            // 
            this.btnGetPledges.Location = new System.Drawing.Point(13, 60);
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
            this.txtboxURL.Text = "https://www.kickstarter.com/projects/2099003506/worlds-first-smart-microhabitat";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kickstarter URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Address:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(99, 20);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pledges found:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HTML Found:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtboxHTML
            // 
            this.txtboxHTML.Location = new System.Drawing.Point(443, 166);
            this.txtboxHTML.Multiline = true;
            this.txtboxHTML.Name = "txtboxHTML";
            this.txtboxHTML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxHTML.Size = new System.Drawing.Size(423, 358);
            this.txtboxHTML.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 576);
            this.Controls.Add(this.txtboxHTML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxURL);
            this.Controls.Add(this.btnGetPledges);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPledges;
        private System.Windows.Forms.TextBox txtboxURL;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Button btnSaveEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxHTML;
    }
}

