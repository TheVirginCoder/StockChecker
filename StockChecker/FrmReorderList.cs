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
using System.Xml.XPath;

namespace StockChecker
{
    public partial class FrmReorderList : Form
    {
        const string productList = "../../res/Products.xml"; //Path to products.xml
        public FrmReorderList()
        {
            InitializeComponent();
        }

        private void FrmReorderList_Load(object sender, EventArgs e)
        {
            GetItemsNeededForReorder(15);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdSaveList.ShowDialog() == DialogResult.OK)
                {
                    SaveAsText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetItemsNeededForReorder(int minStock)
        {
            try
            {
                //XPath expressions used to get product name and reorder level
                string productNameQuery = string.Format("/AllCategories/Category/Products/Product/ProductName[../UnitsInStock < {0}]", minStock); //Display names of products with < 20 in stock
                string stockQuery = string.Format("/AllCategories/Category/Products/Product/UnitsInStock[../UnitsInStock < {0}]", minStock); //Display names of products with < 20 in stock
                string reorderLevelQuery = string.Format("/AllCategories/Category/Products/Product/ReorderLevel[../UnitsInStock < {0}]", minStock); //Display names of products with < 20 in stock

                //XPath Objects used to navigate through the xml file
                XPathDocument listDocument = new XPathDocument(productList);
                XPathNavigator nav = listDocument.CreateNavigator();

                //Execute the queries stored in strings
                XPathNodeIterator nodeIter = nav.Select(productNameQuery); //Get product name
                XPathNodeIterator reorderLevels = nav.Select(reorderLevelQuery); //Get Reorder Level
                XPathNodeIterator stockLevels = nav.Select(stockQuery); //Get units in stock

                //Loop to add items to the ListBox
                while (nodeIter.MoveNext() && reorderLevels.MoveNext() && stockLevels.MoveNext())
                {
                    lstProducts.Items.Add("Product Name: " + nodeIter.Current.Value);
                    lstProducts.Items.Add("Remaining Stock: " + stockLevels.Current.Value);
                    lstProducts.Items.Add("Reorder Level: " + reorderLevels.Current.Value);
                    lstProducts.Items.Add("====================");
                }
            }
            catch (Exception ex)
            {
                //Display error if exception thrown
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event for Update List being clicked
        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            try
            {
                lstProducts.Items.Clear(); //Clear current items in ListBox
                GetItemsNeededForReorder(Convert.ToInt32(txtMinimumStock.Text)); //Repopulate with new minimum stock
            }
            catch (Exception ex)
            {
                //Display error if exception is thrown
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Procedure to save reorder list as txt file
        private void SaveAsText()
        {
            //Opens stream to write to the filename entered in the savedialog
            StreamWriter textFileWriter = new StreamWriter(sfdSaveList.FileName);

            //Write heading to file
            textFileWriter.WriteLine("REORDER LIST");
            textFileWriter.WriteLine("===================");

            //Adds items in the listbox to the file
            for (int itemWritten = 0; itemWritten < lstProducts.Items.Count; itemWritten++)
            {
                textFileWriter.WriteLine(lstProducts.Items[itemWritten].ToString());
            }

            //Closes stream and frees resources
            textFileWriter.Dispose();
            textFileWriter.Close();
        }

        //Set background colour of Update List to Navy when mouse enters
        private void btnUpdateList_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateList.BackColor = Color.Navy;
        }

        private void btnUpdateList_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateList.BackColor = Color.Red;
        }

        //Set background colour of Export to Navy when mouse enters
        private void btnExport_MouseEnter(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Navy;
        }

        private void btnExport_MouseLeave(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Red;
        }

        //Set background colour of Clear to Navy when mouse enters
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Navy;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
        }

        //Set background colour of Return to menu to Navy when mouse enters
        private void btnReturnToMenu_MouseEnter(object sender, EventArgs e)
        {
            btnReturnToMenu.BackColor = Color.Navy;
        }

        private void btnReturnToMenu_MouseLeave(object sender, EventArgs e)
        {
            btnReturnToMenu.BackColor = Color.Red;
        }

        //Set background colour of Product Information to Navy when mouse enters
        private void btnProductInformation_MouseEnter(object sender, EventArgs e)
        {
            btnProductInformation.BackColor = Color.Navy;
        }

        private void btnProductInformation_MouseLeave(object sender, EventArgs e)
        {
            btnProductInformation.BackColor = Color.Red;
        }

        //Set background colour of Exit to Navy when mouse enters
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnProductInformation.BackColor = Color.Red;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset list when clear is clicked
            txtMinimumStock.Text = "";
            GetItemsNeededForReorder(20);
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            //Return the user to the main menu
            FrmMainMenu returnToMenu = new FrmMainMenu();
            returnToMenu.Show();
            this.Dispose();
        }

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            //Open the product information form
            FrmProductInformation productInfo = new FrmProductInformation();
            productInfo.Show();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Prompt the user if they wish to close the program
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If they choose yes, close
            if (exit.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }
    }
}
