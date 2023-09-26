using MyAccounting.Datalayer;
using MyAccounting.Datalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace MyAccounting.App.Customers
{
    public partial class frmAddEdit : Form
    {
        public int cid = 0;
        public frmAddEdit()
        {
            InitializeComponent();
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = dlg.FileName;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (DBUnitOfWork db = new DBUnitOfWork())
                {
                    string ImageName = Guid.NewGuid().ToString() + 
                        Path.GetExtension(pcCustomer.ImageLocation);

                    string imagePath = Application.StartupPath + "/Images/";

                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }
                    pcCustomer.Image.Save(imagePath + ImageName);

                    Customer customer = new Customer()
                    {
                        FullName = txtName.Text,
                        Mobile = txtMobile.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        CustomerImage = ImageName
                    };

                    if (cid == 0)
                    {
                        db.CustomerRepo.InsertCustomer(customer);
                    }
                    else
                    {
                        customer.CustomerID = cid;
                        db.CustomerRepo.UpdateCustomer(customer);
                    }

                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            if(cid != 0)
            {
                this.Text = "Edit Customer";
                using (DBUnitOfWork db = new DBUnitOfWork())
                {
                    Customer customer = db.CustomerRepo.GetCustomerById(cid);
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }
    }
}
