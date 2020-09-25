using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mecanica.Modelos;
using Mecanica.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mecanica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private UnidadeDeTrabalho _context;

        public PerfilController()
        {
            _context = new UnidadeDeTrabalho();
        }

        [HttpGet("{id}")]
        public ActionResult<Perfil> GetPerfil(int id)
        {
            var perfil = _context.PerfilRepositorio.Get(id);

            if (perfil == null)
            {
                return NotFound();
            }

            return perfil;
        }

        [HttpPost]
        public ActionResult<Perfil> CriarPerfil(Perfil perfil)
        {
            _context.PerfilRepositorio.Adicionar(perfil);

            return CreatedAtAction(nameof(GetPerfil), new { id = perfil.Id }, perfil);
        }

        [HttpPut]
        public ActionResult<Perfil> AtualizarPerfil(int id, Perfil perfil)
        {
            _context.PerfilRepositorio.Atualizar(id, perfil);

            return perfil;
        }
    }
}
