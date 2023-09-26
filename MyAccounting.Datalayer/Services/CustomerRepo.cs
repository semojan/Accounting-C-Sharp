using MyAccounting.Datalayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Datalayer.Services
{
    internal class CustomerRepo : ICustomersRepo
    {
        Accounting_DBEntities db;
        public CustomerRepo(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch 
            { 
                return false;
            }
        }

        public bool DeleteCustomer(int CustomerId)
        {
            try
            {
                Customer customer = db.Customers.Find(CustomerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Customer GetCustomerById(int CustomerId)
        {
            return db.Customers.Find(CustomerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> SearchCustomers(string SearchTerm)
        {
            return db.Customers
                .Where(c => c.FullName.Contains(SearchTerm) || 
                    c.Email.Contains(SearchTerm) || 
                    c.Mobile.Contains(SearchTerm))
                .ToList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}