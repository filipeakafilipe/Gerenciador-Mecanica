using App.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Modelos
{
    public class TipoDeServico
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Observacoes { get; set; }

        public Dictionary<int, string> Tipo { get; set; }

        public List<KeyValuePair<int, string>> PopulaTipos()
        {
            var listTipos = new List<KeyValuePair<int, string>>();

            var tipos = TipoDeServicoService.GetTipoDeServicos().Result;

            foreach(var tipo in tipos)
            {
                listTipos.Add(new KeyValuePair<int, string>(tipo.Id, tipo.Nome));
            }

            return listTipos;
        }
    }
}
