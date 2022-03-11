using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAulaDesktop.Models
{
   public class ClienteModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

    }
}
