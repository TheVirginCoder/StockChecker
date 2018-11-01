﻿using System;
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
        DataSet ds = new DataSet();
        DataView dv;
        const string productList = "../../res/Products.xml";

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
                }
                else
                {
                    ds.Tables[2].DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", cbxProductIDList.Text, txtProductName.Text); 
                    dgvProducts.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmStockCheckerMain_Load(object sender, EventArgs e)
        {
            try
            {
                XmlTextReader txtin = new XmlTextReader(productList);
                
                ds.ReadXml(productList, XmlReadMode.InferSchema);
                dv = ds.Tables[2].DefaultView;

                dgvProducts.DataSource = dv;
                dgvProducts.Refresh();

                while (txtin.Read())
                {
                    if (txtin.NodeType.Equals(XmlNodeType.Element) && !cbxProductIDList.Items.Contains(txtin.Name))
                    {
                        cbxProductIDList.Items.Add(txtin.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
