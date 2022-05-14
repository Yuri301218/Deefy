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
    public class UsuarioController : Controller
    {
        private readonly DeeFyDbContext _context;

        public UsuarioController(DeeFyDbContext context)
        {
            _context = context;    
        }


        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpPost("login")]
        public Usuario Login([FromBody] Login login)
        {
            var usuario = _context.Usuarios.Where(
                x => x.Email == login.Email &&
                    x.Senha == login.Senha).FirstOrDefault();

            if (usuario == null)
                throw new Exception("Usuario não encontrado");

            return usuario;

        }
     
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuarios.Find(id);
        }

        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            usuario.Id = 0;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Usuario usuario)
        {
            usuario.Id = id;
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}

