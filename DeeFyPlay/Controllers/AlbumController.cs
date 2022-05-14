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
    public class AlbumController : Controller
    {
        private readonly DeeFyDbContext _context;

        public AlbumController(DeeFyDbContext context)
        {
            _context = context;    
        }


        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return _context.Albums.ToList();
        }

        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return _context.Albums.Find(id);
        }

        [HttpPost]
        public void Post([FromBody] Album Album)
        {
           Album.Id = 0;
            _context.Albums.Add(Album);
            _context.SaveChanges();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Album Album)
        {
           Album.Id = id;
            _context.Albums.Update(Album);
            _context.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Album = _context.Albums.Find(id);

            if (Album != null)
            {
                _context.Albums.Remove(Album);
                _context.SaveChanges();
            }
        }
    }
}

