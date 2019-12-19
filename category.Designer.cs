namespace shopmanagement
{
    partial class category
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
            this.label1 = new System.Windows.Forms.Label();
            this.badd = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category Name";
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(16, 19);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 2;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(124, 19);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 23);
            this.bsave.TabIndex = 3;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(237, 47);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(75, 23);
            this.bexit.TabIndex = 6;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(16, 71);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 4;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(124, 71);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 5;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(227, 118);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(227, 20);
            this.tname.TabIndex = 17;
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.badd);
            this.groupBox1.Controls.Add(this.bsave);
            this.groupBox1.Controls.Add(this.bexit);
            this.groupBox1.Controls.Add(this.bupdate);
            this.groupBox1.Controls.Add(this.bdelete);
            this.groupBox1.Location = new System.Drawing.Point(142, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(516, 111);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(223, 199);
            this.listBox.TabIndex = 15;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category Entry";
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox);
            this.Name = "category";
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
    }
}