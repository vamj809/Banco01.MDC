using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco01.MDC.Resources;

/// <summary>
/// Created by @vamj809
/// </summary>

namespace Banco01.MDC.Cajero
{
    public partial class AddProfile : Form
    {
        static bool safeToClose = true;
        public AddProfile()
        {
            InitializeComponent();
            safeToClose = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
                textUsuario.Focus();
            else if (textClave.Text == "")
                textClave.Focus();
            else if (textNombre.Text == "")
                textNombre.Focus();
            else if (textCorreo.Text == "")
                textCorreo.Focus();
            else if (textSucursal.Text == "")
                textSucursal.Focus();
            else if (isAdminBox.Checked) { }
                //Validate user's credentials.
            else {
                //si todos tienen sus datos...
                Cajeros nuevo_cajero = new Cajeros() {
                    Usuario = textUsuario.Text,
                    Clave = textClave.Text,
                    Nombre = textNombre.Text,
                    Correo = textCorreo.Text,
                    Sucursal = textSucursal.Text,
                    isAdmin = isAdminBox.Checked
                };
                safeToClose = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataChanged(object sender, EventArgs e)
        {
            safeToClose = false;
        }

        private void AddProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verifica que si han habido cambios, preguntará para confirmar que quiere salir sin guardar.
            if (!safeToClose) {
                DialogResult dr = MessageBox.Show("¿Seguro desea cerrar sin guardar los cambios?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
