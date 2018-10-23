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
    public partial class FrmStockCheckerMain : Form
    {
        public FrmStockCheckerMain()
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
                    return;
                }

                XPathNavigator nav;
                XPathDocument docNav;
                XPathNodeIterator nodeIter;
                string strExpression;

                docNav = new XPathDocument(@"C:\Users\FIS40063783\source\repos\ComboBoxExample\ComboBoxExample\res\Products.xml");
                nav = docNav.CreateNavigator();
                strExpression = "/AllCategories/Category/Products/Product/ProductName[../UnitsInStock <=" + txtProductName.Text + "]";

                nodeIter = nav.Select(strExpression);
                lstProducts.Items.Clear();
                lstProducts.Items.Add("List of stock that requires reordering: ");

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
    }
}
