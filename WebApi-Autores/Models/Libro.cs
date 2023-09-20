using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using WebApi_Autores.Helper;

namespace WebApi_Autores.Models
{
    [Table("Libro")]
    public class Libro
    {

        [Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]

        [TituloLibroValidationAttribute]
        public string Titulo { get; set; }
        [Required]
        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public Autor Autor { get; set; }
        

    }
}
