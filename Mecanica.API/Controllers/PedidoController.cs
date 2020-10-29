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
    public class PedidoController : ControllerBase
    {
        private PedidoRepositorio _context;

        public PedidoController()
        {
            _context = new PedidoRepositorio();
        }

        [HttpGet("{id}")]
        public ActionResult<Pedido> GetPedido(int id)
        {
            var pedido = _context.Get(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }


        [HttpPost]
        public ActionResult<Perfil> CriarPerfil(Pedido pedido)
        {
            _context.Adicionar(pedido);

            return CreatedAtAction(nameof(GetPedido), new { id = pedido.Id }, pedido);
        }

        [HttpGet("todos")]
        public ActionResult<List<Pedido>> GetTodosPedidos()
        {
            return _context.GetTodos();
        }

        [HttpPut]
        public void AtualizarPedido(Pedido pedido)
        {
            _context.Atualizar(pedido.Id, pedido);
        }

        [HttpGet("cliente/{idCliente}")]
        public ActionResult<List<Pedido>> GetPedidosDoCliente(int idCliente)
        {
            return _context.GetPedidosDoCliente(idCliente);
        }

        [HttpGet("atuais")]
        public ActionResult<List<Pedido>> GetPedidosNaoFinalizados()
        {
            return _context.GetPedidosNaoFinalizados();
        }
    }
}
