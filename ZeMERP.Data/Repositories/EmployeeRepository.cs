using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeMERP.Data.Infrastructure;
using ZeMERP.Models;

namespace ZeMERP.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(ZeMERPDbContext context)
            : base(context)
        {
        }

        public int TotalEmployees()
        {
            return _dbContext.Employee.Count();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            try
            {
                return
                   await _dbContext.Employee.Where(e => e.EmployeeId == id)
                        .Include(e => e.Email)
                        .Include(e => e.Address)
                        .Include(e => e.Phone)
                        .Include(e => e.Department)
                        .FirstOrDefaultAsync();


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            try
            {
                return
                    await _dbContext.Employee
                        .Include(e => e.Email)
                        .Include(e => e.Address)
                        .Include(e => e.Phone)
                        .Include(e => e.Department)
                        .ToListAsync();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}

    public interface IEmployeeRepository : IRepository<Employee>
    {
        int TotalEmployees();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }

