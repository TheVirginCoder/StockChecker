namespace StockChecker
{
    partial class FrmMainMenu
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
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.Location = new System.Drawing.Point(13, 50);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(87, 23);
            this.btnStockSearch.TabIndex = 0;
            this.btnStockSearch.Text = "Stock Search";
            this.btnStockSearch.UseVisualStyleBackColor = true;
            this.btnStockSearch.Click += new System.EventHandler(this.btnStockSearch_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 279);
            this.Controls.Add(this.btnStockSearch);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockSearch;
    }
}