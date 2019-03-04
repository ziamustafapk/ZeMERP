using ZeMERP.Data.Infrastructure;
using ZeMERP.Models;

namespace ZeMERP.Data.Repositories
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
        public EmailRepository(ZeMERPDbContext context)
            : base(context)
        {
        }
    }

    public interface IEmailRepository : IRepository<Email>
    {

    }
}