using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvcAulaDesktop.Controllers;
using MvcAulaDesktop.Models;

namespace MvcAulaDesktop.Views.Clientes
{
    public partial class CadastroCliente : Form
    {
        ClienteController ctrlCliente;
        ClienteModel cliente;
        public CadastroCliente()
        {
            InitializeComponent();
            ctrlCliente = new ClienteController();
            
        }

        private void Salvar(object sender, EventArgs e)
        {
            cliente = new ClienteModel();

            cliente.Nome = txtNome.Text ;
            cliente.DataNascimento = txtDataNascimento.Text;
            cliente.Pais =txtPais.Text ;
            cliente.Estado =txtEstado.Text;
            cliente.Cidade =txtCidade.Text;
            cliente.Bairro =txtBairro.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = txtNumero.Text;

            ctrlCliente.Salvar(cliente);



        }
    }
}
