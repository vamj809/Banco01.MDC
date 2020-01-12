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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void _testBTN_Click(object sender, EventArgs e)
        {
            TestDB_Connection tdbc = new TestDB_Connection();
            this.Hide();
            tdbc.ShowDialog();
            this.Close();
        }

        private void buttonAcceso_Click(object sender, EventArgs e)
        {
            CajaMenuPrincipal Menu = new CajaMenuPrincipal();
            this.Hide(); //Esconde esta ventana.
            Menu.Show(); //Muestra el menu
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
