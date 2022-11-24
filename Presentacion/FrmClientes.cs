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
    public partial class FrmClientes : Form
    {
        Cliente cliente = new Cliente();
        CLClientes LogicaDeCliente = new CLClientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor solo ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //private void btnLimpiarTodo_Click(object sender, EventArgs e)
        //{
        //    LimpiarTodo();
        //    this.comboBox1.Text = "Seleccione...";
        //    this.comboBox2.Text = "Seleccione...";
        //}

        //private void LimpiarTodo()
        //{
        //    textCedula.Clear();
        //    textNombres.Clear();
        //    textApellidos.Clear();
        //    textTelefono.Clear();
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ResponseCliente Resultado;
            Cliente cliente = new Cliente();
            cliente.Cedula = int.Parse(textCedula.Text);
            cliente.Nombres = textNombres.Text;
            cliente.Apellidos = textApellidos.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.Sexo = comboBox1.Text;
            cliente.Menu = comboBox2.Text;

            Resultado = LogicaDeCliente.ValidarDatos(cliente);  
            if (Resultado.Estado == false)
            {
                MessageBox.Show(Resultado.Mensaje);
                MessageBox.Show("Datos guardados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //MessageBox.Show("Datos guardados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnLimpiarTodo_Click_1(object sender, EventArgs e)
        {
            LimpiarTodo();
            this.comboBox1.Text = "Seleccione...";
            this.comboBox2.Text = "Seleccione...";
        }

        private void LimpiarTodo()
        {
            textCedula.Clear();
            textNombres.Clear();
            textApellidos.Clear();
            textTelefono.Clear();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
