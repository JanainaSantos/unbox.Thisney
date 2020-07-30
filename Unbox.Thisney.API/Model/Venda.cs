using System;
using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime Data { get; set; }
        public int idIngresso { get; set; }
        public Ingresso ingresso { get; set; }
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }
    }
}