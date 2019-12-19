namespace shopmanagement
{
    partial class dmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distrbutorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributionMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.viewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelEntryToolStripMenuItem,
            this.categoryEntryToolStripMenuItem,
            this.productEntryToolStripMenuItem,
            this.distrbutorEntryToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // modelEntryToolStripMenuItem
            // 
            this.modelEntryToolStripMenuItem.Name = "modelEntryToolStripMenuItem";
            this.modelEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modelEntryToolStripMenuItem.Text = "Model Entry";
            this.modelEntryToolStripMenuItem.Click += new System.EventHandler(this.modelEntryToolStripMenuItem_Click);
            // 
            // categoryEntryToolStripMenuItem
            // 
            this.categoryEntryToolStripMenuItem.Name = "categoryEntryToolStripMenuItem";
            this.categoryEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.categoryEntryToolStripMenuItem.Text = "Category Entry";
            this.categoryEntryToolStripMenuItem.Click += new System.EventHandler(this.categoryEntryToolStripMenuItem_Click);
            // 
            // productEntryToolStripMenuItem
            // 
            this.productEntryToolStripMenuItem.Name = "productEntryToolStripMenuItem";
            this.productEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productEntryToolStripMenuItem.Text = "Product Entry";
            this.productEntryToolStripMenuItem.Click += new System.EventHandler(this.productEntryToolStripMenuItem_Click);
            // 
            // distrbutorEntryToolStripMenuItem
            // 
            this.distrbutorEntryToolStripMenuItem.Name = "distrbutorEntryToolStripMenuItem";
            this.distrbutorEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.distrbutorEntryToolStripMenuItem.Text = "Distrbutor Entry";
            this.distrbutorEntryToolStripMenuItem.Click += new System.EventHandler(this.distrbutorEntryToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseTransactionToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // purchaseTransactionToolStripMenuItem
            // 
            this.purchaseTransactionToolStripMenuItem.Name = "purchaseTransactionToolStripMenuItem";
            this.purchaseTransactionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.purchaseTransactionToolStripMenuItem.Text = "Purchase Transaction";
            this.purchaseTransactionToolStripMenuItem.Click += new System.EventHandler(this.purchaseTransactionToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User : Admin";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.distributionMasterToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.productEntryToolStripMenuItem1,
            this.purchaseToolStripMenuItem});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // distributionMasterToolStripMenuItem
            // 
            this.distributionMasterToolStripMenuItem.Name = "distributionMasterToolStripMenuItem";
            this.distributionMasterToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.distributionMasterToolStripMenuItem.Text = "Distribution Master";
            this.distributionMasterToolStripMenuItem.Click += new System.EventHandler(this.distributionMasterToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // productEntryToolStripMenuItem1
            // 
            this.productEntryToolStripMenuItem1.Name = "productEntryToolStripMenuItem1";
            this.productEntryToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.productEntryToolStripMenuItem1.Text = "Product Entry";
            this.productEntryToolStripMenuItem1.Click += new System.EventHandler(this.productEntryToolStripMenuItem1_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // dmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dmenu";
            this.Text = "dmenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distrbutorEntryToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributionMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
    }
}