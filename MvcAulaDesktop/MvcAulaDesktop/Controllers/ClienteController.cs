using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcAulaDesktop.Data;
using MvcAulaDesktop.Models;

namespace MvcAulaDesktop.Controllers
{
    public class ClienteController
    {
        DataContext _data;
        public ClienteController()
        {
            _data = new DataContext();
        }

        public void Salvar(ClienteModel cliente)
        {
            _data.Clientes.Add(cliente);
            _data.SaveChanges();

        }

    }
}
