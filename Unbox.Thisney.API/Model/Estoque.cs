using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }
        public string QtdTotal { get; set; }
        public string QtdAtual { get; set; }
        public List<Ingresso> Ingresso { get; set; }
    }
}