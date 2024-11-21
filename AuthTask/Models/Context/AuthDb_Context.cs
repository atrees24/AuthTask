using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthTask.Models.Context
{
    public class AuthDb_Context:IdentityDbContext
    {
        public AuthDb_Context(DbContextOptions<AuthDb_Context> options):base(options) { }
        
    }
}
