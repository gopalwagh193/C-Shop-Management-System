namespace shopmanagement
{
    partial class productentry
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
            this.csearch = new System.Windows.Forms.ComboBox();
            this.tcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.badd = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tdesc = new System.Windows.Forms.TextBox();
            this.tmname = new System.Windows.Forms.ComboBox();
            this.tcname = new System.Windows.Forms.ComboBox();
            this.tsku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // csearch
            // 
            this.csearch.FormattingEnabled = true;
            this.csearch.Location = new System.Drawing.Point(587, 83);
            this.csearch.Name = "csearch";
            this.csearch.Size = new System.Drawing.Size(121, 21);
            this.csearch.TabIndex = 27;
            this.csearch.SelectedIndexChanged += new System.EventHandler(this.csearch_SelectedIndexChanged);
            // 
            // tcode
            // 
            this.tcode.Location = new System.Drawing.Point(246, 288);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(114, 20);
            this.tcode.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "PRODUCT ENTRY";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.badd);
            this.groupBox2.Controls.Add(this.bexit);
            this.groupBox2.Controls.Add(this.bsave);
            this.groupBox2.Controls.Add(this.bdelete);
            this.groupBox2.Controls.Add(this.bmodify);
            this.groupBox2.Location = new System.Drawing.Point(139, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(18, 19);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 7;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(448, 19);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(75, 23);
            this.bexit.TabIndex = 11;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(119, 19);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 23);
            this.bsave.TabIndex = 8;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(339, 19);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 10;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bmodify
            // 
            this.bmodify.Location = new System.Drawing.Point(229, 19);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(75, 23);
            this.bmodify.TabIndex = 9;
            this.bmodify.Text = "Modify";
            this.bmodify.UseVisualStyleBackColor = true;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "PRODUCT ENTRY";
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(118, 126);
            this.tdesc.Name = "tdesc";
            this.tdesc.Size = new System.Drawing.Size(117, 20);
            this.tdesc.TabIndex = 9;
            // 
            // tmname
            // 
            this.tmname.FormattingEnabled = true;
            this.tmname.Location = new System.Drawing.Point(115, 94);
            this.tmname.Name = "tmname";
            this.tmname.Size = new System.Drawing.Size(121, 21);
            this.tmname.TabIndex = 8;
            // 
            // tcname
            // 
            this.tcname.FormattingEnabled = true;
            this.tcname.Location = new System.Drawing.Point(114, 58);
            this.tcname.Name = "tcname";
            this.tcname.Size = new System.Drawing.Size(121, 21);
            this.tcname.TabIndex = 7;
            // 
            // tsku
            // 
            this.tsku.Location = new System.Drawing.Point(112, 22);
            this.tsku.Name = "tsku";
            this.tsku.Size = new System.Drawing.Size(124, 20);
            this.tsku.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SKU Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HSN / SAC Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(454, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 186);
            this.listBox1.TabIndex = 24;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tdesc);
            this.groupBox1.Controls.Add(this.tmname);
            this.groupBox1.Controls.Add(this.tcname);
            this.groupBox1.Controls.Add(this.tsku);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(125, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 194);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // productentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 446);
            this.Controls.Add(this.csearch);
            this.Controls.Add(this.tcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "productentry";
            this.Text = "productentry";
            this.Load += new System.EventHandler(this.productentry_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox csearch;
        private System.Windows.Forms.TextBox tcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tdesc;
        private System.Windows.Forms.ComboBox tmname;
        private System.Windows.Forms.ComboBox tcname;
        private System.Windows.Forms.TextBox tsku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}