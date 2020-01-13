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

namespace Banco01.MDC.Operaciones_con_el_cliente
{
    public partial class ComprobacionCliente : Form
    {
        private ValidaCajero_Result CurrentUser;
        public ComprobacionCliente(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            OperacionesCliente form_OpClientes = new OperacionesCliente();
            this.Hide();
            form_OpClientes.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Datos correctos", "Datos Correctos");
                Retirar form_Retiro = new Retirar();
                this.Hide();
                form_Retiro.Show();

            }
            else
                MessageBox.Show("Por favor llene todos los campos");
        }
    }
}
