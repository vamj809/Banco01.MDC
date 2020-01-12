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
using Banco01.MDC.Resources.MDC_LocalDataSetTableAdapters;

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
            ValidaCajeroTableAdapter validaCajero = new ValidaCajeroTableAdapter();
            MDC_LocalDataSet.ValidaCajeroDataTable datos = validaCajero.isValid(UserTXT.Text, PassTXT.Text);
            if(datos.Count > 0) {
                //Esto manda el nombre del cajero/a y la sucursal al menu principal.
                UserData CurrentUser = new UserData() {
                    Usuario = UserTXT.Text,
                    Nombre = datos.Rows[0].ItemArray[0].ToString(),
                    Sucursal = datos.Rows[0].ItemArray[1].ToString()
                };
                CajaMenuPrincipal Menu = new CajaMenuPrincipal(CurrentUser);
                this.Hide(); //Esconde esta ventana.
                Menu.Show(); //Muestra el menu
            } else {
                MessageBox.Show("Usuario y/o contraseña inválidos.", "Credenciales incorrectos", MessageBoxButtons.OK);
                UserTXT.Focus();
            }
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
