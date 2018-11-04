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
            this.btnReorderList = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.BackColor = System.Drawing.Color.Red;
            this.btnStockSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockSearch.ForeColor = System.Drawing.Color.White;
            this.btnStockSearch.Location = new System.Drawing.Point(12, 53);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(101, 51);
            this.btnStockSearch.TabIndex = 0;
            this.btnStockSearch.Text = "Stock Search";
            this.btnStockSearch.UseVisualStyleBackColor = false;
            this.btnStockSearch.Click += new System.EventHandler(this.btnStockSearch_Click);
            this.btnStockSearch.MouseEnter += new System.EventHandler(this.btnStockSearch_MouseEnter);
            this.btnStockSearch.MouseLeave += new System.EventHandler(this.btnStockSearch_MouseLeave);
            // 
            // btnReorderList
            // 
            this.btnReorderList.BackColor = System.Drawing.Color.Red;
            this.btnReorderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReorderList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderList.ForeColor = System.Drawing.Color.White;
            this.btnReorderList.Location = new System.Drawing.Point(119, 53);
            this.btnReorderList.Name = "btnReorderList";
            this.btnReorderList.Size = new System.Drawing.Size(101, 51);
            this.btnReorderList.TabIndex = 1;
            this.btnReorderList.Text = "Reorder List";
            this.btnReorderList.UseVisualStyleBackColor = false;
            this.btnReorderList.Click += new System.EventHandler(this.btnReorderList_Click);
            this.btnReorderList.MouseEnter += new System.EventHandler(this.btnReorderList_MouseEnter);
            this.btnReorderList.MouseLeave += new System.EventHandler(this.btnReorderList_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(57, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tesco Stock Checker";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(225, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 111);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReorderList);
            this.Controls.Add(this.btnStockSearch);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.Button btnReorderList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}