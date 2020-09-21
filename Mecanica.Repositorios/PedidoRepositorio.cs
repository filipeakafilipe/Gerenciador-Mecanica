using Mecanica.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Mecanica.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio
    {
        public PedidoRepositorio() : base()
        {

        }

        public Pedido Get(int id)
        {
            return db.Pedidos.Where(v => v.Id == id).FirstOrDefault();
        }

        public void Adicionar(Pedido pedido)
        {
            db.Pedidos.Add(pedido);

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            var pedido = db.Pedidos.Where(v => v.Id == id).FirstOrDefault();

            db.Pedidos.Remove(pedido);

            db.SaveChanges();
        }

        public void Atualizar(int id, Pedido novoPedido)
        {
            var pedido = Get(id);

            pedido = novoPedido;

            db.Entry(pedido).State = EntityState.Modified;

            db.SaveChanges();
        }
    }
}
