using System;
using System.Collections.Generic;
using System.Text;

namespace App.Modelos
{
    public class Pedido
    {
        public int TipoDeServicoId { get; set; }

        public int VeiculoId { get; set; }

        public double ValorMaoDeObra { get; set; }

        public double ValorPecas { get; set; }
    }
}
