using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal class LimpiarTodo
    {
        public void LimpiarCampos(Control control, GroupBox groupBox)
        {
            foreach (var text in control.Controls)
            {
                if (text is TextBox)
                {
                    ((TextBox)text).Clear();
                }
                else if (text is ComboBox)
                {
                    ((ComboBox)text).SelectedIndex = 0;
                }
            }

            foreach (var combo in control.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = 0;
                }
            }
        }
    }
}
