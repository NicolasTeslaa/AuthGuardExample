using AuthGuardExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthGuardExample.Context
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}