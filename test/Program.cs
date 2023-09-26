using MyAccounting.Datalayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBUnitOfWork db = new DBUnitOfWork();
            var list = db.CustomerRepo.GetAllCustomers();
        }
    }
}
