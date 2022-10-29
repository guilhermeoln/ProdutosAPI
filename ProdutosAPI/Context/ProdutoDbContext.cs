using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ProdutosAPI.Models;

namespace ProdutosAPI.Context
{
    public class ProdutoDbContext : DbContext
    {


        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite(connectionString: "DataSource=produtos.db;Cache=Shared");


        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Produto>()
                .Property(x => x.Valor)
                .HasPrecision(10,2);

            model.Entity<Produto>()
                .HasKey(x => x.Id);

            model.Entity<Produto>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

        }


    }
}
