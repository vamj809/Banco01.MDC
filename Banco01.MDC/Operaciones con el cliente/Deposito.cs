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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3 != null)
            {

            }
            else { 
                
                DialogResult dr2 = MessageBox.Show("Parece que algun campo se quedo vacio. Por favor introduzctodos los datos", "Datos no introducidos",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperacionesCLiente form_OpClientes = new OperacionesCLiente();
            this.Hide();
            form_OpClientes.Show();
        }
    }
}
