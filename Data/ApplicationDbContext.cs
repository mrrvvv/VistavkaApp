using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VistavkaApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Posetitel> Posetitels { get; set; }
        public virtual DbSet<Bilet> Bilets { get; set; }
        public virtual DbSet<Vistavka> Vistavkas { get; set; }
    }
}

