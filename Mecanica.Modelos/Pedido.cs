using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mecanica.Modelos
{
    public class Pedido
    {
        public Pedido()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public TipoDeServico TipoDeServico { get; set; }
        
        [Required]
        public virtual int TipoDeServicoId { get; set; }

        //[Required]
        //public Perfil Perfil { get; set; }

        //[Required]
        //public virtual int PerfilId { get; set; }

        [Required]
        public Veiculo Veiculo { get; set; }

        [Required]
        public virtual int VeiculoId { get; set; }

        [Required]
        public double ValorMaoDeObra { get; set; }

        [Required]
        public double ValorPecas { get; set; }

        [Required]
        public double ValorTotal { get; set; }
    }
}
