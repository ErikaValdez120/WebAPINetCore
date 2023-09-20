using Microsoft.EntityFrameworkCore;
using WebApplication_PrimerDiseño.Models;

namespace WebApplication_PrimerDiseño.Data
{
    public class DBProductosEFContext: DbContext
    {
        //tiene que estar el constructor con parámetro
        public DBProductosEFContext(DbContextOptions<DBProductosEFContext> options) : base(options) { }


        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
