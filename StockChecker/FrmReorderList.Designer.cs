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
            this.gbxProducts.SuspendLayout();
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
            this.sfdSaveList.Filter = "Text File (*.txt)|*.txt";
            // 
            // FrmReorderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 356);
            this.Controls.Add(this.btnSaveAsText);
            this.Controls.Add(this.gbxProducts);
            this.Name = "FrmReorderList";
            this.Text = "FrmReorderList";
            this.Load += new System.EventHandler(this.FrmReorderList_Load);
            this.gbxProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnSaveAsText;
        private System.Windows.Forms.SaveFileDialog sfdSaveList;
    }
}