using ZeMERP.Data.Infrastructure;
using ZeMERP.Models;

namespace ZeMERP.Data.Repositories
{
    public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
    {
        public PhoneRepository(ZeMERPDbContext context)
            : base(context)
        {
        }
    }
    public interface IPhoneRepository : IRepository<Phone>
    {

    }
}