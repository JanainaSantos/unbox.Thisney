using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(5, ErrorMessage = "Este campo deve conter no minimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter até 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Telefone { get; set; }

        public List<Venda> Venda { get; set; }
    }
}