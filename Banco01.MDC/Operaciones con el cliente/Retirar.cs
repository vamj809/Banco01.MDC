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
    public partial class Retirar : Form
    {
        private ValidaCajero_Result CurrentUser;
        public Retirar(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Retirar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperacionesCliente form_OpClientes = new OperacionesCliente();
            this.Hide();
            form_OpClientes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0   && textBox1.Text != "")
            {


                DialogResult dr2 = MessageBox.Show("¿Esta seguro de que estos son los datos correctos?", "Confirmacion de datos ", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    MessageBox.Show("Retiro realizado con exito");
                    OperacionesCliente form_OpClientes = new OperacionesCliente();
                    this.Hide();
                    form_OpClientes.Show();
                }


            }
        }
    }
}
