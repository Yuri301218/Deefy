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
    public class ArtistaController : Controller
    {
        private readonly DeeFyDbContext _context;

        public ArtistaController(DeeFyDbContext context)
        {
            _context = context;    
        }


        [HttpGet]
        public IEnumerable<Artista> Get()
        {
            return _context.Artistas.ToList();
        }

        [HttpGet("{id}")]
        public Artista Get(int id)
        {
            return _context.Artistas.Find(id);
        }

        [HttpPost]
        public void Post([FromBody] Artista Artista)
        {
            Artista.Id = 0;
            _context.Artistas.Add(Artista);
            _context.SaveChanges();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Artista Artista)
        {
            Artista.Id = id;
            _context.Artistas.Update(Artista);
            _context.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Artista = _context.Artistas.Find(id);

            if (Artista != null)
            {
                _context.Artistas.Remove(Artista);
                _context.SaveChanges();
            }
        }
    }
}

