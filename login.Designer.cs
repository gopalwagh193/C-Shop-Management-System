namespace shopmanagement
{
    partial class login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tlid = new System.Windows.Forms.TextBox();
            this.fexit = new System.Windows.Forms.Button();
            this.flogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.tpass);
            this.groupBox1.Controls.Add(this.tlid);
            this.groupBox1.Controls.Add(this.fexit);
            this.groupBox1.Controls.Add(this.flogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 434);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(96, 53);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(100, 20);
            this.tpass.TabIndex = 5;
            // 
            // tlid
            // 
            this.tlid.Location = new System.Drawing.Point(96, 19);
            this.tlid.Name = "tlid";
            this.tlid.Size = new System.Drawing.Size(100, 20);
            this.tlid.TabIndex = 4;
            // 
            // fexit
            // 
            this.fexit.Location = new System.Drawing.Point(107, 111);
            this.fexit.Name = "fexit";
            this.fexit.Size = new System.Drawing.Size(56, 19);
            this.fexit.TabIndex = 3;
            this.fexit.Text = "Exit";
            this.fexit.UseVisualStyleBackColor = true;
            this.fexit.Click += new System.EventHandler(this.fexit_Click);
            // 
            // flogin
            // 
            this.flogin.Location = new System.Drawing.Point(29, 111);
            this.flogin.Name = "flogin";
            this.flogin.Size = new System.Drawing.Size(46, 19);
            this.flogin.TabIndex = 2;
            this.flogin.Text = "Login";
            this.flogin.UseVisualStyleBackColor = true;
            this.flogin.Click += new System.EventHandler(this.flogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ID";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.groupBox1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tlid;
        private System.Windows.Forms.Button fexit;
        private System.Windows.Forms.Button flogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}