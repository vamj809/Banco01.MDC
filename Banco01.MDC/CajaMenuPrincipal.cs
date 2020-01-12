using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco01.MDC
{
    public partial class CajaMenuPrincipal : Form
    {
        public CajaMenuPrincipal(string nombre = null, string sucursal = null)
        {
            InitializeComponent();
            if (nombre != null)
                WelcomeLabel.Text = $"Bienvenido/a {nombre}";
            if (sucursal != null)
                this.Text += $" - {sucursal}";
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
    }
}
