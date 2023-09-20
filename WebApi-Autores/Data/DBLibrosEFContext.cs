using Microsoft.EntityFrameworkCore;
using WebApi_Autores.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi_Autores.Data
{
    public class DBLibrosEFContext : DbContext
    {
        public DBLibrosEFContext(DbContextOptions<DBLibrosEFContext> options) : base(options) { }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
