﻿using System;
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
        const string productList = "../../res/Products.xml";
        public FrmReorderList()
        {
            InitializeComponent();
        }

        private void FrmReorderList_Load(object sender, EventArgs e)
        {
            try
            {
                string expression = "/AllCategories/Category/Products/Product/ProductName[../UnitsInStock < 20]";
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
    }
}
