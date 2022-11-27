using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private Clientes Clientes = new Clientes();

        private void GetCliente()
        {
            var response = Clientes.GetCliente();

            this.Clientes.DataSource = response;
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {

        }

    }
}

