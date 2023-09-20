using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApi_Autores.Data;
using WebApi_Autores.Models;
using WebApiEF.Helper;

namespace WebApi_Autores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly DBLibrosEFContext context;
        public LibroController(DBLibrosEFContext context)

        {
            this.context = context;
        }

        [ServiceFilter(typeof(TestActionFilterAttribute))]
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            //Este Codigo produce un Bucle Infinito.
            //var libros = context.Libros.Include(l => l.Autor).ToList(); 

            //return libros;
            
            var libros = context.Libros
            .Select(l => new Libro
            {
                Id = l.Id,
                Titulo = l.Titulo,               
                Autor = new Autor
                {
                    Id = l.Autor.Id,
                    Nombre = l.Autor.Nombre
                }
            })
            .ToList();

            return libros;
        }

        [HttpPost]
        public ActionResult Post(Libro libro)
        {
            //EF guarda en memoria
            context.Libros.Add(libro);
            //EF guarda en DB
            context.SaveChanges();

            return Ok();
        }


    }
}
