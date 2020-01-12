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
    public partial class CajaMenuPrincipal : Form
    {
        private ValidaCajero_Result CurrentUser;
        public CajaMenuPrincipal(ValidaCajero_Result currentUser = null)
        {
            InitializeComponent();
            if(currentUser != null) {
                CurrentUser = currentUser;
                if (currentUser.Nombre.Length > 0)
                    WelcomeLabel.Text = $"Bienvenido/a {currentUser.Nombre}";
                if (currentUser.Sucursal.Length > 0)
                    this.Text += $" - {currentUser.Sucursal}";
            }
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            Login form_Login = new Login();
            this.Hide();
            form_Login.Show();
        }

        private void CajaMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProfileEditorBTN_Click(object sender, EventArgs e)
        {
            Cajero.EditProfile formProfileEditor = new Cajero.EditProfile(CurrentUser);
            formProfileEditor.ShowDialog();
        }
    }
}
