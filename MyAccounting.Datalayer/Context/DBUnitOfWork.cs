﻿using MyAccounting.Datalayer.Repository;
using MyAccounting.Datalayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Datalayer.Context
{
    public class DBUnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomersRepo _customerRepo;
        private GenericRepo<Transation> _transactionRepo;
        private GenericRepo<LoginInfo> _loginRepo;

        public ICustomersRepo CustomerRepo
        {
            get 
            { 
                if (_customerRepo == null)
                {
                    _customerRepo = new CustomerRepo(db);
                }
                return _customerRepo;
            }
        }
        public GenericRepo<Transation> TransactionsRepo
        {
            get
            {
                if (_transactionRepo == null)
                {
                    _transactionRepo = new GenericRepo<Transation>(db);
                }
                return _transactionRepo;
            }
        }

        public GenericRepo<LoginInfo> LoginRepo
        {
            get
            {
                if (_loginRepo == null)
                {
                    _loginRepo = new GenericRepo<LoginInfo>(db);
                }
                return _loginRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
