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

namespace Banco01.MDC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonAcceso_Click(object sender, EventArgs e)
        {
            MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities();
            foreach (ValidaCajero_Result usuario in localDBEntity.ValidaCajero(UserTXT.Text, PassTXT.Text)) {
                if(usuario != null) {
                    //Esto manda el nombre del cajero/a y la sucursal al menu principal.
                    CajaMenuPrincipal Menu = new CajaMenuPrincipal(usuario);
                    this.Hide(); //Esconde esta ventana.
                    Menu.Show(); //Muestra el menu
                    return; //Termina el ciclo y sale del metodo.
                }
            }
            //Si llegó a este punto, entonces el usuario y/o contraseña están invalidos,
            //... o hay errores de conexion con la DB.
            MessageBox.Show("Usuario y/o contraseña inválidos.", "Credenciales incorrectos", MessageBoxButtons.OK);
            UserTXT.Focus();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro desea salir?", "Cerrando el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
