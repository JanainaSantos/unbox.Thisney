using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [MinLength(5, ErrorMessage = "Campo nome deve conter no minimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "Campo nome deve conter até 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Campo telefone é obrigatório")]
        public string Telefone { get; set; }

        public List<Venda> Venda { get; set; }
    }
}