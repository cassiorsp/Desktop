using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAulaDesktop.Models
{
   public class ClienteModel
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(30)]
        public string DataNascimento { get; set; }
        [Required]
        [MaxLength(20)]
        public string Pais { get; set; }
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

    }
}
