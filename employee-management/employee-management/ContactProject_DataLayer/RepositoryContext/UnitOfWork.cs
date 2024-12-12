using ContactProject_DataLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject_DataLayer.DataModel
{
    public class UnitOfWork : IDisposable
    {
        ContactProject_DBEntities db;
        public UnitOfWork()
        {
            db = new ContactProject_DBEntities();
        }


        private GenericRepository<User> _userRepository;
        public GenericRepository<User> UserRepository 
        {
            get
            {
                return _userRepository ?? new GenericRepository<User>(db);
            }
        }

        private GenericRepository<ContactTransactions> _contactTransactionRepository;
        public GenericRepository<ContactTransactions> ContactTransactionRepository
        {
            get
            {
                return _contactTransactionRepository ?? new GenericRepository<ContactTransactions>(db);
            }
        }


        private GenericRepository<Contact> _contactRepository;
        public GenericRepository<Contact> ContactRepository
        {
            get
            {
                return _contactRepository ?? new GenericRepository<Contact>(db);
            }
        }

        private GenericRepository<ContactEmails> _contactEmailsRepository;
        public GenericRepository<ContactEmails> ContactEmailsRepository
        {
            get
            {
                return _contactEmailsRepository ?? new GenericRepository<ContactEmails>(db);
            }
        }

        private GenericRepository<ContactPhones> _contactPhonesRepository;
        public GenericRepository<ContactPhones> ContactPhonesRepository
        {
            get
            {
                return _contactPhonesRepository ?? new GenericRepository<ContactPhones>(db);
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
