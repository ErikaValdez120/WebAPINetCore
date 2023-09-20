using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Autores.Models
{
    [Table("Autor")]
    public class Autor
    {
        [Required]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
