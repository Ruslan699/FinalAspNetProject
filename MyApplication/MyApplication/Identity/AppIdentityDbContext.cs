using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApplication.Models.Security;
using MyApplication.Models.Brons;
using MyApplication.Models;

namespace MyApplication.Identity
{
    public class AppIdentityDbContext:IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<MyApplication.Models.Security.RegisterViewModel> RegisterViewModel { get; set; }
    }
}
