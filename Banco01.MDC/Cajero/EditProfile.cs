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
    public partial class EditProfile : Form
    {
        private ValidaCajero_Result CurrentUser;
        private Cajeros detalles_cajero;
        private static bool detectedChanges = false;
        public EditProfile(ValidaCajero_Result _currentUser)
        {
            InitializeComponent();
            CurrentUser = _currentUser;
            detalles_cajero = new Cajeros();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textClave.Text == "") {
                MessageBox.Show("Debe digitar su contraseña para guardar los cambios.",
                    "Error de autenticación.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textClave.Focus();
            } else if(textClave.Text != detalles_cajero?.Clave) {
                MessageBox.Show("Contraseña inválida. Verifique su contraseña.",
                "Error de autenticación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textClave.Focus();
            }
            else {
                //SaveChanges.
                using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                    var data = localDBEntity.Cajeros.Where(d => d.ID == detalles_cajero.ID);
                    if(data.Count() > 0)
                        detalles_cajero = data.First();
                    detalles_cajero.Usuario = textUsuario.Text;
                    //Si puso una nueva contraseña, guarda la nueva... sino, pues no.
                    if(textClave_2.Text == "")
                        detalles_cajero.Clave = textClave.Text;
                    else {
                        detalles_cajero.Clave = textClave_2.Text;
                    }
                    detalles_cajero.Nombre = textNombre.Text;
                    detalles_cajero.Correo = textCorreo.Text;
                    detalles_cajero.Sucursal = textSucursal.Text;
                    localDBEntity.SaveChanges();
                    detectedChanges = false;
                    MessageBox.Show("Cambios guardados satisfactoriamente.\n" +
                        "Para ver los cambios, cierre la sesión y vuelva a ingresar.","Exito",MessageBoxButtons.OK);
                    this.Close();
                }
            }
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
                    textClave.Text = "";
                    textClave_2.Text = "";
                    textNombre.Text = datosUsuario.Nombre;
                    textCorreo.Text = datosUsuario.Correo;
                    textSucursal.Text = datosUsuario.Sucursal;
                    //Esto servirá para saber a quien le actualizamos los valores:
                    detalles_cajero = localDBEntity.Cajeros.Find(datosUsuario.ID);
                    detectedChanges = false;
                    break;
                }
            }
        }

        private void EditProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verifica que si han habido cambios, preguntará para confirmar que quiere salir sin guardar.
            if (detectedChanges) {
                DialogResult dr = MessageBox.Show("¿Seguro desea cerrar sin guardar los cambios?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
            }
            CajaMenuPrincipal Menu = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            Menu.Show();
        }

        private void dataChanged(object sender, EventArgs e)
        {
            detectedChanges = true;
        }
    }
}
