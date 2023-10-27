using MyAccounting.App.Customers;
using MyAccounting.App.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNewTransacrtion frmAddTrans = new frmNewTransacrtion();
            frmAddTrans.ShowDialog();
        }

        private void btnExpenseReport_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.TypeId = 2;
            frmReports.Text = "Expense Report";
            frmReports.ShowDialog();
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.TypeId = 1;
            frmReports.Text = "Income Report";
            frmReports.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmNewTransacrtion frmAddTrans = new frmNewTransacrtion();
            frmAddTrans.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLoginSett_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.isEdit = true;
            frmLogin.ShowDialog();
        }
    }
}
