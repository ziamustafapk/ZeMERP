using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ZeMERP.Data.Repositories;
using ZeMERP.Models.Shared;

namespace ZeMERP.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private CancellationTokenSource _cancellationTokenSource;
        private  ZeMERPDbContext _context;
        private IEmployeeRepository _employee;
        
       
        private IDepartmentRepository _department;
        
        

        private IAddressRepository _address;
        private IEmailRepository _email;
        
        private IPhoneRepository _phone;
       
        //Reference Data

        public UnitOfWork(ZeMERPDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            //_context?.Dispose();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
                if (_cancellationTokenSource != null)
                {
                    _cancellationTokenSource.Dispose();
                    _cancellationTokenSource = null;
                }
            }
        }

        public IEmployeeRepository Employee => _employee ?? (_employee = new EmployeeRepository(_context));

       

        public IDepartmentRepository Department => _department ?? (_department = new DepartmentRepository(_context));

       public IAddressRepository Address => _address ?? (_address = new AddressRepository(_context));
        public IEmailRepository Email => _email ?? (_email = new EmailRepository(_context));
        public IPhoneRepository Phone => _phone ?? (_phone = new PhoneRepository(_context));
        
       

        public void SaveChanges()
        {
            //DisplayStates(_context.ChangeTracker.Entries());
            _context.SaveChanges();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entity in entries)
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        ((IBaseModel)entity.Entity).CreatedDate = DateTime.Now;
                        ((IBaseModel)entity.Entity).CreatedBy = Guid.NewGuid().ToString();
                        
                        break;
                    case EntityState.Modified:
                        ((IBaseModel)entity.Entity).UpdatedDate = DateTime.Now;
                        ((IBaseModel)entity.Entity).UpdatedBy = Guid.NewGuid().ToString();
                        break;
                }
            }
        }
       

       

    }
}
