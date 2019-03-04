using System;
using System.Threading.Tasks;
using ZeMERP.Data.Repositories;

namespace ZeMERP.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employee { get; }
       
       
        IDepartmentRepository Department { get; }
        
        IAddressRepository Address { get; }
        IEmailRepository Email { get; }
        
        IPhoneRepository Phone { get; }
        
        //Refference Data
       

        void SaveChanges();
        Task<bool> SaveChangesAsync();
    }
}
