using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParcInformatique.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data
{
    public class ApplicationContext:IdentityDbContext<Utilisateur>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt) { }
        //public ApplicationContext(){}

        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Equipement> Equipements { get; set; }
        public virtual DbSet<Appel> Appels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
