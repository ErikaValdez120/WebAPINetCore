using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Autores.Models
{
    [Table("Empleado")]
    public class Empleado
    {

        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Apellido { get; set;}
        public DateTime FechaNacimiento { get; set;}
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string email { get; set;}
    }
}
