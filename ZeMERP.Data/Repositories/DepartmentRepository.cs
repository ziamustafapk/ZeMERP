using ZeMERP.Data.Infrastructure;
using ZeMERP.Models;

namespace ZeMERP.Data.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ZeMERPDbContext context)
            : base(context)
        {
        }
    }

    public interface IDepartmentRepository : IRepository<Department>
    {

    }
}