using EFMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Subject> Teachers { get; set; }
    }
}
