using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using WebApi_Autores.Data;
using WebApi_Autores.Models;
using WebApiEF.Helper;

namespace WebApi_Autores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {

        private readonly DBLibrosEFContext context;
        public AutorController(DBLibrosEFContext context)

        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Autor> GetAutores()
        {
            return context.Autors.ToList();
        }

        [HttpGet("{id}")]

        public Autor GetAutores(int id)
        {
            return context.Autors.SingleOrDefault(c => c.Id == id);
        }

        // POST api/Categoria
        [HttpPost]
        public ActionResult Post(Autor autor)
        {
            //EF guarda en memoria
            context.Autors.Add(autor);
            //EF guarda en DB
            context.SaveChanges();

            return Ok();
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            //buscar uno por ID
            Autor autor = context.Autors.Find(id);

            if (autor == null)
            {
                return NotFound();
            }

            //EF guarda en memoria
            context.Autors.Remove(autor);
            //EF guarda en DB
            context.SaveChanges();

            return autor;
        }

        //PUT api/Categoria/id
        [HttpPut("{id}")]
        public ActionResult Put(int id,Autor autor)
        {
            if (id != autor.Id)
            {
                return BadRequest();
            }

            context.Entry(autor).State = EntityState.Modified;

            //EF guarda en DB
            context.SaveChanges();

            return NoContent();

        }
    }
}
