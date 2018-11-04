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
        DataSet productInfo = new DataSet();
        DataView tableInfo;
        const string productList = "../../res/Products.xml"; //Path to XML file

        public FrmProductInformation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Display erroris nothing is entered
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Error: Please enter a value");
                }
                else
                {
                    //Refresh datagridview to contain search results
                    productInfo.Tables[2].DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", cbxSearchCriteria.Text, txtProductName.Text); 
                    dgvProducts.Refresh();
                }

                //Output warning if nothing is found
                if (tableInfo.Count == 0)
                {
                    MessageBox.Show("No results found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //Error message if exception is thrown
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProductInformation_Load(object sender, EventArgs e)
        {
            try
            {
                //Initialize Datagridview
                InitializeTable();
                cbxSearchCriteria.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            //Return the user to the main Menu
            FrmMainMenu returnToMain = new FrmMainMenu();
            returnToMain.Show();
            this.Dispose();
            this.Close();
        }

        private void btnReorderList_Click(object sender, EventArgs e)
        {
            //Take the user to the reorder list
            FrmReorderList reorderList = new FrmReorderList();
            reorderList.Show();
            this.Dispose();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Ask the user if they wish to exit
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If yes, close the program
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
                string output = ""; //Output will be written to CSV

                //Execute if user clicks Save in the dialog
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdExport.FileName); //Allow the program to write to file

                    //Write the headers to file, loops through number of columns
                    for (int header = 0; header <= dgvProducts.Columns.Count - 1; header++)
                    {
                        //Write comma if more than one item is written
                        if (header > 0)
                        {
                            sw.Write(",");
                        }
                        sw.Write(dgvProducts.Columns[header].HeaderText); //Write header text to file
                    }
                    
                    sw.WriteLine(); //Write newline

                    for (int j = 0; j <= dgvProducts.Columns.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            sw.WriteLine();
                        }

                        for (int i = 0; i <= dgvProducts.Columns.Count - 1; i++)
                        {
                            //Write comma if there is more than one value
                            if (i > 0)
                            {
                                sw.Write(",");
                            }

                            output = dgvProducts.Rows[j].Cells[i].Value.ToString(); //Store row values in output
                            output = output.Replace(',', ' '); //replace commas with spaces
                            output = output.Replace(Environment.NewLine, " "); //replace newlines with spaces

                            sw.Write(output); //write all info to file
                        }
                    }

                    //Close file
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
            //Read the XML file and store it in the dataset
            productInfo.ReadXml(productList);
            tableInfo = productInfo.Tables[2].DefaultView;

            //Store the info in the datagridview
            dgvProducts.DataSource = tableInfo;
            dgvProducts.Refresh();

            //Set up combobox items
            foreach (DataColumn col in productInfo.Tables[2].Columns)
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
            InitializeTable();
            cbxSearchCriteria.SelectedIndex = 1;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Navy;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
        }
    }
}
