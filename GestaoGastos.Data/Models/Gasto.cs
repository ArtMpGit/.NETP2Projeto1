using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoGastos.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        [Required(ErrorMessage = "O preço é obrigatório")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória"), MaxLength(150, ErrorMessage = "O tamanho máximo permitido é de 150 caracteres")]
        public string Descricao { get; set; }
    }
}
