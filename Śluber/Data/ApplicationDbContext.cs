using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Śluber.Models;

namespace Śluber.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Śluber.Models.Wedding> Wedding { get; set; }
        public DbSet<Śluber.Models.Guest> Guest { get; set; }
        public DbSet<Śluber.Models.Errand> Errand { get; set; }
        public DbSet<Śluber.Models.ServiceProv> ServiceProv { get; set; }
    }
}
