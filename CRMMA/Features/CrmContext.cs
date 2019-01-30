using Microsoft.EntityFrameworkCore;

namespace CRMMAEngine.Features
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {
        }

        public DbSet<ContactDto> Contacts { get; set; }
    }
}
