﻿namespace shopmanagement
{
    partial class ViewPurchase
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
            this.button2 = new System.Windows.Forms.Button();
            this.bshow = new System.Windows.Forms.Button();
            this.griddata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.griddata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "View Purchase Entry";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bshow
            // 
            this.bshow.Location = new System.Drawing.Point(47, 410);
            this.bshow.Name = "bshow";
            this.bshow.Size = new System.Drawing.Size(399, 23);
            this.bshow.TabIndex = 9;
            this.bshow.Text = "Show";
            this.bshow.UseVisualStyleBackColor = true;
            this.bshow.Click += new System.EventHandler(this.bshow_Click);
            // 
            // griddata
            // 
            this.griddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddata.Location = new System.Drawing.Point(47, 91);
            this.griddata.Name = "griddata";
            this.griddata.Size = new System.Drawing.Size(794, 290);
            this.griddata.TabIndex = 8;
            // 
            // ViewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bshow);
            this.Controls.Add(this.griddata);
            this.Name = "ViewPurchase";
            this.Text = "ViewPurchase";
            this.Load += new System.EventHandler(this.ViewPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bshow;
        private System.Windows.Forms.DataGridView griddata;
    }
}