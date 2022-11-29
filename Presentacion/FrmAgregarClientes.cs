using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;


namespace Presentacion
{
    public partial class FrmAgregarClientes : Form
    {
        private Clientes cliente = new Clientes();
        private string accion = "nuevo";
        private int id = 0;
        private int Id = 0;

        public FrmAgregarClientes()
        {
            InitializeComponent();
        }

        private void FrmAgregarClientes_Load(object sender, EventArgs e)
        {
            this.GetCliente();
        }

        private void GetCliente()
        {
            var response = cliente.GetCliente();

            this.dgCliente.DataSource = response;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.textNombres.Enabled = true;
            this.textApellidos.Enabled = true;
            this.textTelefono.Enabled = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;

            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnSalir.Enabled = true;


            this.textNombres.Text = "";
            this.textApellidos.Text = "";
            this.textTelefono.Text = "";
            this.comboBox1.Text = "Seleccione...";
            this.comboBox2.Text = "Seleccione...";

            this.textNombres.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "nuevo")
            {
                Cliente cliente = new Cliente()
                {
                    Id = 0,
                    Nombres = this.textNombres.Text,
                    Apellidos = this.textApellidos.Text,
                    Telefono = this.textTelefono.Text,
                    Sexo = this.comboBox1.Text,
                    Menu = this.comboBox2.Text,
                };

                if (cliente != null)
                {
                    var response = oCliente.AddCliente(cliente);

                    if (response > 0)
                    {
                        MessageBox.Show("Se guardo correctamente.", ",Mensaje del sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar.", ",Mensaje del sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Cliente cliente = new Cliente()
                {
                    Id = id,
                    Nombres = this.textNombres.Text,
                    Apellidos = this.textApellidos.Text,
                    Telefono = this.textTelefono.Text,
                    Sexo = this.comboBox1.Text,
                    Menu = this.comboBox2.Text,
                };

                if (cliente != null)
                {
                    var response = oCliente.UpdateCliente(cliente);

                    if (response > 0)
                    {
                        MessageBox.Show("Se actualizo correctamente.", ",Mensaje del sistemas. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar.", ",Mensaje del sistemas. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.textNombres.Text = "";
            this.textApellidos.Text = "";
            this.textTelefono.Text = "";
            this.comboBox1.Text = "Seleccione...";
            this.comboBox2.Text = "Seleccione...";
            id = 0;

            this.textNombres.Enabled = false;
            this.textApellidos.Enabled = false;
            this.textTelefono.Enabled = false;
            this.comboBox1.Enabled = false;
            this.comboBox2.Enabled = false;

            this.btnGuardar.Enabled = false;
            this.btnSalir.Enabled = false;
            this.btnNuevo.Enabled = false;

            this.GetCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "editar";

            if (id > 0)
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnNuevo.Enabled = false;
                this.btnSalir.Enabled = true;

                this.textNombres.Enabled = true;
                this.textApellidos.Enabled = true;
                this.textTelefono.Enabled = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;

            }
        }

        private void dgCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            accion = "editar";

            DataGridViewRow row = this.dgCliente.Rows[e.RowIndex];

            id = Convert.ToInt32(row.Cells["Id"].Value);
            this.textNombres.Text = row.Cells["Nombres"].Value.ToString();
            this.textApellidos.Text = row.Cells["Apellidos"].Value.ToString();
            this.textTelefono.Text = row.Cells["Telefono"].Value.ToString();
            this.comboBox1.Text = row.Cells["Sexo"].Value.ToString();
            this.comboBox2.Text = row.Cells["Menu"].Value.ToString();

            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var response = oCliente.DeleteCliente(id);

                    if (response > 0)
                    {
                        MessageBox.Show("Se elimino correctamente.", ",Mensaje del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnEliminar.Enabled = false;
                        this.btnEditar.Enabled = false;

                        this.textNombres.Text = "";
                        this.textApellidos.Text = "";
                        this.textTelefono.Text = "";
                        this.comboBox1.Text = "Seleccione...";
                        this.comboBox2.Text = "Seleccione...";
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar.", ",Mensaje del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.GetCliente();
            }
        }

        
    }
}
  
