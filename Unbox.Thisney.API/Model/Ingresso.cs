using System.ComponentModel.DataAnnotations;

namespace Unbox.Thisney.API.Model
{
    public class Ingresso
    {
        [Key]
        public int Codigo { get; set; }
        public string qrCode { get; set; }
        public int idEstoque { get; set; }
        public Estoque Estoque { get; set; }
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }

    }
}