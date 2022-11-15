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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    Guardar();
        //    CargarGrilla();
        //    CargarLista();
        //}

        //void Guardar()
        //{
        //    Entidades.Cliente cliente = new Entidades.Cliente();
        //    cliente.Cedula = new Random().Next(999999, 10000000)
        //    cliente.Nombres = textNombres.Text;
        //    cliente.Apelllidos = textApellidos.Text;
        //    cliente.Telefono = textTelefono.Text;
        //    cliente.Sexo = radioButtonFemenino.Text, radioButtonMasculino.Text;
        //}



        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor solo ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor solo ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor solo ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor solo ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            LimpiarTodo limpiarTodo = new LimpiarTodo();
            limpiarTodo.LimpiarCampos(this, groupBox1);
        }

        

        
    }
}
