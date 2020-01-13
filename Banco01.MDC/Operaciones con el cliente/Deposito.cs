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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
            {
                string nombre = textBox1.Text;
                string NumeroCuenta = textBox2.Text;
                decimal monto = Convert.ToDecimal(textBox3.Text);


                DialogResult dr2 = MessageBox.Show("¿Esta seguro de que estos son los datos correctos?", "Confirmacion de datos ", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    MessageBox.Show("Deposito realizado con exito");
                }

                
            }
            else { 
                
                DialogResult dr2 = MessageBox.Show("Parece que algun campo se quedo vacio. Por favor introduzca todos los datos", "Datos no introducidos",MessageBoxButtons.OK, MessageBoxIcon.Information);

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
