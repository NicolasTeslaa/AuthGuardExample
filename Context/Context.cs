using AuthGuardExample.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthGuardExample.Context
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}