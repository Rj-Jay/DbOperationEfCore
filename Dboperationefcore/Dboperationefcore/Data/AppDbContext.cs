using Microsoft.EntityFrameworkCore;

namespace Dboperationefcore.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
    }
}
