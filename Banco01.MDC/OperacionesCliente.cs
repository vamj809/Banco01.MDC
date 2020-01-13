using Banco01.MDC.Operaciones_con_el_cliente;
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
using Banco01.MDC.Cajero;

namespace Banco01.MDC
{
    public partial class OperacionesCliente : Form
    {
        private ValidaCajero_Result CurrentUser;
        public OperacionesCliente(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposito form_Deposito = new Deposito();
            this.Hide();
            form_Deposito.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal();
            this.Hide();
            form_MainMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComprobacionCliente form_Comprobacion = new ComprobacionCliente();
            this.Hide();
            form_Comprobacion.Show();
        }

        private void OperacionesCLiente_Load(object sender, EventArgs e)
        {

        }
    }
}
