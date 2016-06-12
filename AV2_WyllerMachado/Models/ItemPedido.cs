using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AV2_WyllerMachado.Models
{
    [Table("ItensPedidos")]
    public class ItemPedido
    {
        public int Id { get; set; }


        // Navigation Property
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }

        // Navigation Property
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }


        public int Quantidade { get; set; }
    }
}