using App.Modelos;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public static class VeiculoService
    {
        public static async Task Cadastrar(Veiculo veiculo)
        {
            await $"{Base.Uri}api/veiculo".PostJsonAsync(veiculo);
        }
    }
}
