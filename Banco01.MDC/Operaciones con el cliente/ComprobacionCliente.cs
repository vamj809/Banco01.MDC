using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco01.MDC.Operaciones_con_el_cliente
{
    public partial class ComprobacionCliente : Form
    {
        public ComprobacionCliente()
        {
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
            OperacionesCLiente form_OpClientes = new OperacionesCLiente();
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
