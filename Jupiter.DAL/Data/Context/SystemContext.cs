using Jupiter.DAL;
using Microsoft.EntityFrameworkCore;

namespace Jupiter.DAL
{
    public class SystemContext :DbContext
    {
        public DbSet<Tasks> Tasks => Set<Tasks>();
        public DbSet<User> Users => Set<User>();

        public SystemContext(DbContextOptions<SystemContext> options) : base(options) { }
    }
}
