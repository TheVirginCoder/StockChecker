using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockChecker
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            FrmStockCheckerMain stocksearch = new FrmStockCheckerMain();
            stocksearch.Show();
            this.Hide();
        }

        private void btnReorderList_Click(object sender, EventArgs e)
        {
            FrmReorderList reorderList = new FrmReorderList();
            reorderList.Show();
            this.Hide();
        }
    }
}
