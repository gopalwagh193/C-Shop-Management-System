namespace shopmanagement
{
    partial class DistributorMaster
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
            this.button1 = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.ListBox();
            this.tgst = new System.Windows.Forms.TextBox();
            this.tphone = new System.Windows.Forms.TextBox();
            this.tacc = new System.Windows.Forms.TextBox();
            this.taddress = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdelete = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.badd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(648, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.White;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.FormattingEnabled = true;
            this.lname.ItemHeight = 16;
            this.lname.Location = new System.Drawing.Point(15, 28);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(229, 228);
            this.lname.TabIndex = 13;
            this.lname.DoubleClick += new System.EventHandler(this.lname_DoubleClick);
            // 
            // tgst
            // 
            this.tgst.Location = new System.Drawing.Point(124, 189);
            this.tgst.Name = "tgst";
            this.tgst.Size = new System.Drawing.Size(100, 20);
            this.tgst.TabIndex = 9;
            this.tgst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tgst_KeyDown);
            // 
            // tphone
            // 
            this.tphone.Location = new System.Drawing.Point(124, 148);
            this.tphone.MaxLength = 10;
            this.tphone.Name = "tphone";
            this.tphone.Size = new System.Drawing.Size(100, 20);
            this.tphone.TabIndex = 8;
            this.tphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tphone_KeyDown);
            this.tphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tphone_KeyPress);
            // 
            // tacc
            // 
            this.tacc.Location = new System.Drawing.Point(124, 116);
            this.tacc.MaxLength = 12;
            this.tacc.Name = "tacc";
            this.tacc.Size = new System.Drawing.Size(100, 20);
            this.tacc.TabIndex = 7;
            this.tacc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tacc_KeyDown);
            this.tacc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tacc_KeyPress);
            // 
            // taddress
            // 
            this.taddress.Location = new System.Drawing.Point(124, 77);
            this.taddress.MaxLength = 60;
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(100, 20);
            this.taddress.TabIndex = 6;
            this.taddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taddress_KeyDown);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(124, 37);
            this.tname.MaxLength = 30;
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 5;
            this.tname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tname_KeyDown);
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "GSTIN No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile No";
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Green;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bdelete.Location = new System.Drawing.Point(536, 388);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 31);
            this.bdelete.TabIndex = 20;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bmodify
            // 
            this.bmodify.BackColor = System.Drawing.Color.Green;
            this.bmodify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmodify.Location = new System.Drawing.Point(411, 388);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(75, 31);
            this.bmodify.TabIndex = 19;
            this.bmodify.Text = "Modify";
            this.bmodify.UseVisualStyleBackColor = false;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.Green;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bsave.Location = new System.Drawing.Point(294, 388);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 31);
            this.bsave.TabIndex = 17;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distributor Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(303, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "DISTRIBUTOR MASTER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lname);
            this.groupBox2.Location = new System.Drawing.Point(472, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 273);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Green;
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.badd.Location = new System.Drawing.Point(176, 388);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 31);
            this.badd.TabIndex = 18;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tgst);
            this.groupBox1.Controls.Add(this.tphone);
            this.groupBox1.Controls.Add(this.tacc);
            this.groupBox1.Controls.Add(this.taddress);
            this.groupBox1.Controls.Add(this.tname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(159, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 282);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // DistributorMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bmodify);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.groupBox1);
            this.Name = "DistributorMaster";
            this.Text = "DistributorMaster";
            this.Load += new System.EventHandler(this.DistributorMaster_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lname;
        private System.Windows.Forms.TextBox tgst;
        private System.Windows.Forms.TextBox tphone;
        private System.Windows.Forms.TextBox tacc;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}