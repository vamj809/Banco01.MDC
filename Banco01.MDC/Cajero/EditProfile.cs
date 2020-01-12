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

namespace Banco01.MDC.Cajero
{
    public partial class EditProfile : Form
    {
        private ValidaCajero_Result CurrentUser;
        public EditProfile(ValidaCajero_Result _currentUser)
        {
            InitializeComponent();
            CurrentUser = _currentUser;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if (CurrentUser == null) {
                MessageBox.Show("Datos Inválidos. \n" +
                    "Necesita acceder por el menu principal después de iniciar sesión.\n" +
                    "En caso contrario, comuniquese con soporte técnico.", 
                    "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else {
                MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities();
                foreach (GetCajero_Result datosUsuario in localDBEntity.GetCajero(CurrentUser.Usuario)) {
                    textUsuario.Text = datosUsuario.Usuario;
                    textClave.Text = datosUsuario.Clave;
                    textClave_2.Text = "";
                    textNombre.Text = datosUsuario.Nombre;
                    textCorreo.Text = datosUsuario.Correo;
                    textSucursal.Text = datosUsuario.Sucursal;
                    break;
                }
            }
        }

        private void EditProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            CajaMenuPrincipal Menu = new CajaMenuPrincipal(CurrentUser);
            this.Hide(); //Esconde esta ventana.
            Menu.Show();
        }
    }
}
