using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace StockChecker
{
    public partial class FrmProductInformation : Form
    {
        DataSet ds = new DataSet();
        DataView dv;
        const string productList = "../../res/Products.xml";

        public FrmProductInformation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Error: Please enter a value for the units in stock");
                }
                else
                {
                    ds.Tables[2].DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", cbxProductIDList.Text, txtProductName.Text); 
                    dgvProducts.Refresh();
                }

                if (dv.Count == 0)
                {
                    MessageBox.Show("No results found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProductInformation_Load(object sender, EventArgs e)
        {
            try
            {
                ds.ReadXml(productList);
                dv = ds.Tables[2].DefaultView;

                dgvProducts.DataSource = dv;
                dgvProducts.Refresh();

                foreach (DataColumn col in ds.Tables[2].Columns)
                {
                    cbxProductIDList.Items.Add(col.ColumnName);
                }
                cbxProductIDList.Items.RemoveAt(10);
                cbxProductIDList.Items.RemoveAt(9);
                cbxProductIDList.Items.RemoveAt(8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu returnToMain = new FrmMainMenu();
            returnToMain.Show();
            this.Dispose();
            this.Close();
        }

        private void btnReorderList_Click(object sender, EventArgs e)
        {
            FrmReorderList reorderList = new FrmReorderList();
            reorderList.Show();
            this.Dispose();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btnReturnToMenu_MouseEnter(object sender, EventArgs e)
        {
            btnReturnToMenu.BackColor = Color.Navy;
        }

        private void btnReturnToMenu_MouseLeave(object sender, EventArgs e)
        {
            btnReturnToMenu.BackColor = Color.Red;
        }

        private void btnReorderList_MouseEnter(object sender, EventArgs e)
        {
            btnReorderList.BackColor = Color.Navy;
        }

        private void btnReorderList_MouseLeave(object sender, EventArgs e)
        {
            btnReorderList.BackColor = Color.Red;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Navy;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Navy;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Red;
        }

        private void FrmProductInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
