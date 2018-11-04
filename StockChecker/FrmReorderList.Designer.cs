namespace StockChecker
{
    partial class FrmReorderList
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
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnSaveAsText = new System.Windows.Forms.Button();
            this.sfdSaveList = new System.Windows.Forms.SaveFileDialog();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxProducts.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.lstProducts);
            this.gbxProducts.Location = new System.Drawing.Point(310, 35);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(331, 274);
            this.gbxProducts.TabIndex = 0;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "List of Products that need reordered";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(7, 20);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(318, 251);
            this.lstProducts.TabIndex = 0;
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.Location = new System.Drawing.Point(13, 163);
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAsText.TabIndex = 1;
            this.btnSaveAsText.Text = "Save as text file";
            this.btnSaveAsText.UseVisualStyleBackColor = true;
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // sfdSaveList
            // 
            this.sfdSaveList.Filter = "Text File (*.txt)|*.txt|CSV File|*.csv";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.button1);
            this.gbxSearch.Controls.Add(this.textBox1);
            this.gbxSearch.Location = new System.Drawing.Point(13, 35);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(291, 122);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FrmReorderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 356);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.btnSaveAsText);
            this.Controls.Add(this.gbxProducts);
            this.Name = "FrmReorderList";
            this.Text = "FrmReorderList";
            this.Load += new System.EventHandler(this.FrmReorderList_Load);
            this.gbxProducts.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnSaveAsText;
        private System.Windows.Forms.SaveFileDialog sfdSaveList;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}