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
    public class VeiculoController : ControllerBase
    {
        private UnidadeDeTrabalho _context;

        public VeiculoController()
        {
            _context = new UnidadeDeTrabalho();
        }

        [HttpGet("{id}")]
        public ActionResult<Veiculo> GetVeiculo(int id)
        {
            var veiculo = _context.VeiculoRepositorio.Get(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;
        }

        [HttpPost]
        public ActionResult<Veiculo> CriarVeiculo(Veiculo veiculo)
        {
            _context.VeiculoRepositorio.Adicionar(veiculo);

            return CreatedAtAction(nameof(GetVeiculo), new { id = veiculo.Id }, veiculo);
        }
    }
}
