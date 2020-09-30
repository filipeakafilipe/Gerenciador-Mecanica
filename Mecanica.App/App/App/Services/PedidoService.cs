using App.Modelos;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public static class PedidoService
    {
        public static async Task Cadastrar(Pedido pedido)
        {
            await $"{Base.Uri}api/pedido".PostJsonAsync(pedido);
        }
    }
}
