using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AV2_WyllerMachado.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [StringLength(255)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [StringLength(14)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}