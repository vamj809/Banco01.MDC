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
        public CajaMenuPrincipal()
        {
            InitializeComponent();
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
