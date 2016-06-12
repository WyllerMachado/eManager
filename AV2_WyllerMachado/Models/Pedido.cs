using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AV2_WyllerMachado.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int Id { get; set; }


        // Navigation Property
        public Cliente Cliente { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }


        [StringLength(64)]
        public string Status { get; set; }


        [Display(Name = "Data do Pedido")]
        [Column(TypeName = "Date")]
        public DateTime DataPedido { get; set; }


        [Required]
        public List<ItemPedido> ItensPedidos { get; set; }
    }
}