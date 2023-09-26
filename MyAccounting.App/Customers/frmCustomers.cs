using MyAccounting.Datalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting.App.Customers
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            using (DBUnitOfWork db = new DBUnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepo.GetAllCustomers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            BindGrid();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (DBUnitOfWork db = new DBUnitOfWork())
            {
                dgCustomers.DataSource = db.CustomerRepo.SearchCustomers(txtSearch.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int cid = (int)dgCustomers.CurrentRow.Cells[0].Value;
                string name = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                var result = MessageBox.Show($"Are you sure about deleting {name}?", 
                    "Alert", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    using(DBUnitOfWork db = new DBUnitOfWork())
                    {
                        db.CustomerRepo.DeleteCustomer(cid);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Customer!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit frmAdd = new frmAddEdit();
            var result = frmAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int cid = (int)dgCustomers.CurrentRow.Cells[0].Value;
                frmAddEdit frmEdit = new frmAddEdit();
                frmEdit.cid = cid;
                var result = frmEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Customer!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
