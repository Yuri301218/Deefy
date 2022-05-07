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
    public class MusicaController : Controller
    {
        private readonly DeeFyDbContext _context;

        public MusicaController(DeeFyDbContext context)
        {
            _context = context;    
        }


        [HttpGet]
        public IEnumerable<Musica> Get()
        {
            return _context.Musicas.ToList();
        }
      
        [HttpGet("{id}")]
        public Musica Get(int id)
        {
            return _context.Musicas.Find(id);
        }

        [HttpPost]
        public void Post([FromBody] Musica Musica)
        {
            Musica.Id = 0;
            _context.Musicas.Add(Musica);
            _context.SaveChanges();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Musica Musica)
        {
            Musica.Id = id;
            _context.Musicas.Update(Musica);
            _context.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Musica = _context.Musicas.Find(id);

            if (Musica != null)
            {
                _context.Musicas.Remove(Musica);
                _context.SaveChanges();
            }
        }
    }
}

