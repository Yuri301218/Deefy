using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DeeFyPlay.Infra;
using DeeFyPlay.Model;
using Microsoft.AspNetCore.Mvc;

namespace DeeFyPlay.Controllers
{
    [Route("api/[controller]")]
    public class GeneroController : Controller
    {
        private readonly DeeFyDbContext _context;

        public GeneroController(DeeFyDbContext context)
        {
            _context = context;    
        }


        [HttpGet]
        public IEnumerable<Genero> Get()
        {
            return _context.Generos.ToList();
        }

        [HttpGet("{id}")]
        public Genero Get(int id)
        {
            return _context.Generos.Find(id);
        }

        [HttpPost]
        public void Post([FromBody] Genero Genero)
        {
            Genero.Id = 0;
            _context.Generos.Add(Genero);
            _context.SaveChanges();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genero Genero)
        {
            Genero.Id = id;
            _context.Generos.Update(Genero);
            _context.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Genero = _context.Generos.Find(id);

            if (Genero != null)
            {
                _context.Generos.Remove(Genero);
                _context.SaveChanges();
            }
        }
    }
}

