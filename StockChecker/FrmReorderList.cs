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

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdSaveList.ShowDialog() == DialogResult.OK)
                {
                    //Opens stream to write to the filename entered in the savedialog
                    StreamWriter sr = new StreamWriter(sfdSaveList.FileName);

                    //Write heading to file
                    sr.WriteLine("REORDER LIST");
                    sr.WriteLine("===================");

                    //Adds items in the listbox to the file
                    for (int i = 0; i < lstProducts.Items.Count; i++)
                    {
                        sr.WriteLine(lstProducts.Items[i].ToString());
                    }
                    //Closes stream and frees resources
                    sr.Dispose();
                    sr.Close();
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
                string expression = string.Format("/AllCategories/Category/Products/Product/ProductName[../UnitsInStock < {0}]", minStock); //Display names of products with < 20 in stock
                XPathDocument doc = new XPathDocument(productList);
                XPathNavigator nav = doc.CreateNavigator();
                XPathNodeIterator nodeIter = nav.Select(expression);

                while (nodeIter.MoveNext())
                {
                    lstProducts.Items.Add(nodeIter.Current.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lstProducts.Items.Clear();
                GetItemsNeededForReorder(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
