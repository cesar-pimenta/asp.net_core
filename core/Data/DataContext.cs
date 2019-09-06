using core.Models;
using Microsoft.EntityFrameworkCore;

namespace core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Atributo> Atributos {get; set;}
    }
}