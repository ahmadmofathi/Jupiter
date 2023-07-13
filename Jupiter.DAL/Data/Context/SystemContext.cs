using Jupiter.APIs.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jupiter.Data.Context
{
    public class SystemContext :DbContext
    {
        public DbSet<Tasks> Tasks => Set<Tasks>();
        public DbSet<User> Users => Set<User>();

        public SystemContext(DbContextOptions<SystemContext> options) : base(options) { }
    }
}
