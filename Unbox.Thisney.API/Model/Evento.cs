using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime Data { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(5, ErrorMessage = "Este campo deve conter no minimo 5 caracteres")]
        [MaxLength(255, ErrorMessage = "Este campo deve conter até 255 caracteres")]
        public string Descricao { get; set; }
        public List<Ingresso> Ingressos { get; set; }
        public List<Venda> Venda { get; set; }
    }
}