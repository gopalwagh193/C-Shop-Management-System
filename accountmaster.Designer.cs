namespace shopmanagement
{
    partial class accountmaster
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.badd = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taccd = new System.Windows.Forms.TextBox();
            this.tacc = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(402, 86);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(260, 225);
            this.listBox.TabIndex = 15;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "ACCOUNT MASTER";
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(28, 30);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 4;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(156, 30);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 23);
            this.bsave.TabIndex = 5;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(535, 30);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(75, 23);
            this.bexit.TabIndex = 8;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bmodify
            // 
            this.bmodify.Location = new System.Drawing.Point(268, 30);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(75, 23);
            this.bmodify.TabIndex = 7;
            this.bmodify.Text = "Modify";
            this.bmodify.UseVisualStyleBackColor = true;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(400, 30);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 6;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taccd);
            this.groupBox1.Controls.Add(this.tacc);
            this.groupBox1.Controls.Add(this.tname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(84, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 252);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // taccd
            // 
            this.taccd.Location = new System.Drawing.Point(131, 129);
            this.taccd.Name = "taccd";
            this.taccd.Size = new System.Drawing.Size(100, 20);
            this.taccd.TabIndex = 5;
            // 
            // tacc
            // 
            this.tacc.Location = new System.Drawing.Point(130, 85);
            this.tacc.Name = "tacc";
            this.tacc.Size = new System.Drawing.Size(100, 20);
            this.tacc.TabIndex = 4;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(129, 44);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.badd);
            this.groupBox2.Controls.Add(this.bsave);
            this.groupBox2.Controls.Add(this.bexit);
            this.groupBox2.Controls.Add(this.bmodify);
            this.groupBox2.Controls.Add(this.bdelete);
            this.groupBox2.Location = new System.Drawing.Point(82, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // accountmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 446);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "accountmaster";
            this.Text = "accountmaster";
            this.Load += new System.EventHandler(this.accountmaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox taccd;
        private System.Windows.Forms.TextBox tacc;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}