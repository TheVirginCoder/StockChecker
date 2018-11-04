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
            this.btnExport = new System.Windows.Forms.Button();
            this.sfdSaveList = new System.Windows.Forms.SaveFileDialog();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.txtMinimumStock = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProductInformation = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.lblMinimumStock = new System.Windows.Forms.Label();
            this.gbxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.lstProducts);
            this.gbxProducts.Location = new System.Drawing.Point(516, 48);
            this.gbxProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxProducts.Size = new System.Drawing.Size(551, 379);
            this.gbxProducts.TabIndex = 0;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "List of Products that need reordered";
            // 
            // lstProducts
            // 
            this.lstProducts.ForeColor = System.Drawing.Color.Red;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 18;
            this.lstProducts.Location = new System.Drawing.Point(11, 28);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(528, 346);
            this.lstProducts.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Red;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(272, 94);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 51);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.btnExport_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.btnExport_MouseLeave);
            // 
            // sfdSaveList
            // 
            this.sfdSaveList.Filter = "Text File (*.txt)|*.txt|CSV File|*.csv";
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.BackColor = System.Drawing.Color.Red;
            this.btnUpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateList.ForeColor = System.Drawing.Color.White;
            this.btnUpdateList.Location = new System.Drawing.Point(161, 94);
            this.btnUpdateList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(101, 51);
            this.btnUpdateList.TabIndex = 1;
            this.btnUpdateList.Text = "Update List";
            this.btnUpdateList.UseVisualStyleBackColor = false;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            this.btnUpdateList.MouseEnter += new System.EventHandler(this.btnUpdateList_MouseEnter);
            this.btnUpdateList.MouseLeave += new System.EventHandler(this.btnUpdateList_MouseLeave);
            // 
            // txtMinimumStock
            // 
            this.txtMinimumStock.ForeColor = System.Drawing.Color.Red;
            this.txtMinimumStock.Location = new System.Drawing.Point(147, 48);
            this.txtMinimumStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMinimumStock.Name = "txtMinimumStock";
            this.txtMinimumStock.Size = new System.Drawing.Size(352, 26);
            this.txtMinimumStock.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(974, 435);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(383, 94);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 51);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnProductInformation
            // 
            this.btnProductInformation.BackColor = System.Drawing.Color.Red;
            this.btnProductInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInformation.ForeColor = System.Drawing.Color.White;
            this.btnProductInformation.Location = new System.Drawing.Point(125, 435);
            this.btnProductInformation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProductInformation.Name = "btnProductInformation";
            this.btnProductInformation.Size = new System.Drawing.Size(101, 51);
            this.btnProductInformation.TabIndex = 4;
            this.btnProductInformation.Text = "Product Info";
            this.btnProductInformation.UseVisualStyleBackColor = false;
            this.btnProductInformation.Click += new System.EventHandler(this.btnProductInformation_Click);
            this.btnProductInformation.MouseEnter += new System.EventHandler(this.btnProductInformation_MouseEnter);
            this.btnProductInformation.MouseLeave += new System.EventHandler(this.btnProductInformation_MouseLeave);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.Color.Red;
            this.btnReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMenu.Location = new System.Drawing.Point(14, 435);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(101, 51);
            this.btnReturnToMenu.TabIndex = 5;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            this.btnReturnToMenu.MouseEnter += new System.EventHandler(this.btnReturnToMenu_MouseEnter);
            this.btnReturnToMenu.MouseLeave += new System.EventHandler(this.btnReturnToMenu_MouseLeave);
            // 
            // lblMinimumStock
            // 
            this.lblMinimumStock.AutoSize = true;
            this.lblMinimumStock.Location = new System.Drawing.Point(12, 51);
            this.lblMinimumStock.Name = "lblMinimumStock";
            this.lblMinimumStock.Size = new System.Drawing.Size(127, 18);
            this.lblMinimumStock.TabIndex = 6;
            this.lblMinimumStock.Text = "Minimum Stock";
            // 
            // FrmReorderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 493);
            this.Controls.Add(this.lblMinimumStock);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnProductInformation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.txtMinimumStock);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbxProducts);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmReorderList";
            this.Text = "Reorder List";
            this.Load += new System.EventHandler(this.FrmReorderList_Load);
            this.gbxProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdSaveList;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.TextBox txtMinimumStock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProductInformation;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label lblMinimumStock;
    }
}