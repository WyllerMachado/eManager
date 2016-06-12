using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AV2_WyllerMachado.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(128)]
        public string Marca { get; set; }

        [Required]
        public int Estoque { get; set; }

        public List<ItemPedido> ItensPedidos { get; set; }
    }
}