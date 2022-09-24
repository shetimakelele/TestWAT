using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWAT.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Personne> Personnes { get; set; }
        
        // methode qui permet d initialiser la Base de Donées
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // on verifie si il y a des data sinon on les insere

            modelBuilder.Entity<Personne>().HasData(
                new Personne { PersonneId = 1, Nom = "Mak", Prenom = "Sheti", }
                );

            modelBuilder.Entity<Personne>().HasData(
                new Personne { PersonneId = 2, Nom = "Mak", Prenom = "Cindy", }
                );

            modelBuilder.Entity<Personne>().HasData(
                new Personne { PersonneId = 3, Nom = "Mak", Prenom = "Elijaah", }
                );
        }
    }
}
