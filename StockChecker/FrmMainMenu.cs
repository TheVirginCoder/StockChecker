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

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            //Open product info form
            FrmProductInformation stocksearch = new FrmProductInformation();
            stocksearch.Show();
            this.Hide();
        }

        private void btnReorderList_Click(object sender, EventArgs e)
        {
            //Open reorder list form
            FrmReorderList reorderList = new FrmReorderList();
            reorderList.Show();
            this.Hide();
        }

        private void btnReorderList_MouseEnter(object sender, EventArgs e)
        {
            btnReorderList.BackColor = Color.Navy;
        }

        private void btnReorderList_MouseLeave(object sender, EventArgs e)
        {
            btnReorderList.BackColor = Color.Red;
        }

        private void btnProductInformation_MouseEnter(object sender, EventArgs e)
        {
            btnProductInformation.BackColor = Color.Navy;
        }

        private void btnProductInformation_MouseLeave(object sender, EventArgs e)
        {
            btnProductInformation.BackColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Ask the user if they want to exit
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If yes, close the program
            if (exit.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Navy;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }
    }
}
