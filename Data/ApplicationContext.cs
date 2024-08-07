using Microsoft.EntityFrameworkCore;
using ParcInformatiqueData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt) { }
        //public ApplicationContext(){}

        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Equipement> Equipements { get; set; }
        public virtual DbSet<Appel> Appels { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
