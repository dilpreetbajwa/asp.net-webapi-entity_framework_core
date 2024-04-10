using asp.net_webapi_entity_framework_core.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.net_webapi_entity_framework_core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
