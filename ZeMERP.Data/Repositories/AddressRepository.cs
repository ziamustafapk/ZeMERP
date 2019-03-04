using ZeMERP.Data.Infrastructure;
using ZeMERP.Models;

namespace ZeMERP.Data.Repositories
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(ZeMERPDbContext context)
            : base(context)
        {
        }

    }

    public interface IAddressRepository : IRepository<Address>
    {

    }

}