using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PagBem.Test;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definindo um índice único na propriedade Cpf da entidade Pessoa
            modelBuilder.Entity<Person>()
                .HasIndex(p => p.CPF)
                .IsUnique();

            modelBuilder.Entity<Person>()
             .HasIndex(p => p.RG)
             .IsUnique();

            // Outras configurações do modelo podem ser adicionadas aqui

            base.OnModelCreating(modelBuilder);
        }


    }
}
