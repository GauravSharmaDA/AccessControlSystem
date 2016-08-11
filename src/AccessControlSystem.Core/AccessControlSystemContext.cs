using Microsoft.EntityFrameworkCore;

namespace AccessControlSystem.Core
{
    public class AccessControlSystemContext : DbContext
    {
        public AccessControlSystemContext(DbContextOptions<AccessControlSystemContext> options)
            : base(options)
        {
            
        }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Department> Departmetns { get; set; }
        public DbSet<AccessPolicy> Policies { get; set; }
        public DbSet<ServerType> ServerTypes { get; set; }
    }
}
