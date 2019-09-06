using System.Collections.Generic;
using core.Models;
using Microsoft.EntityFrameworkCore;

namespace core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Atributo> Atributos { get; set;}
        public DbSet<Produto> Produtos { get; set;} 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
            .HasData(
                new List<Produto>(){
                    new Produto(){
                        Id = 1,
                        Descricao = "chave"
                    },
                    new Produto(){
                        Id = 2,
                        Descricao = "motor"
                    },
                    new Produto(){
                        Id = 3,
                        Descricao = "abraçadeira"
                    }
                }
            );
            builder.Entity<Atributo>()
            .HasData(
                new List<Atributo>(){
                    new Atributo(){
                        Id = 1,
                        Descricao = "chave"
                    },
                    new Atributo(){
                        Id = 2,
                        Descricao = "motor"
                    },
                    new Atributo(){
                        Id = 3,
                        Descricao = "abraçadeira"
                    }
                }
            );
        }
    }
}