using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

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
                    ds.Tables[2].DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", cbxSearchCriteria.Text, txtProductName.Text); 
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
                cbxSearchCriteria.SelectedIndex = 1;
                InitializeTable();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdExport.FileName);

                    for (int i = 0; i <= dgvProducts.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            sw.Write(",");
                        }
                        sw.Write(dgvProducts.Columns[i].HeaderText);
                    }
                    
                    sw.WriteLine();

                    for (int j = 0; j <= dgvProducts.Columns.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            sw.WriteLine();
                        }

                        for (int i = 0; i <= dgvProducts.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                sw.Write(",");
                            }

                            output = dgvProducts.Rows[j].Cells[i].Value.ToString();
                            output = output.Replace(',', ' ');
                            output = output.Replace(Environment.NewLine, " ");

                            sw.Write(output);
                        }
                    }

                    sw.Dispose();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeTable()
        {
            ds.ReadXml(productList);
            dv = ds.Tables[2].DefaultView;

            dgvProducts.DataSource = dv;
            dgvProducts.Refresh();

            foreach (DataColumn col in ds.Tables[2].Columns)
            {
                cbxSearchCriteria.Items.Add(col.ColumnName);
            }
            cbxSearchCriteria.Items.RemoveAt(10);
            cbxSearchCriteria.Items.RemoveAt(9);
            cbxSearchCriteria.Items.RemoveAt(8);
        }

        private void btnExport_MouseEnter(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Navy;
        }

        private void btnExport_MouseLeave(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Red;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset all values in the form
            txtProductName.Text = "";
            cbxSearchCriteria.SelectedIndex = 1;
            InitializeTable();
        }
    }
}
