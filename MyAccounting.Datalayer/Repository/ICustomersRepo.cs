﻿using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Datalayer.Repository
{
    public interface ICustomersRepo
    {
        List<Customer> GetAllCustomers();
        List<Customer> SearchCustomers(string SearchTerm);
        List<ListCustomerViewModel> getNames(string SearchTerm);
        Customer GetCustomerById(int CustomerId);
        bool UpdateCustomer(Customer customer);
        bool InsertCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int CustomerId);
        int GetIdByName(string name);
        string GetNameById (int CustomerId);
    }
}
