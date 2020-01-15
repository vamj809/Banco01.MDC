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
    public partial class ReciboDeposito : Form
    {


        public ReciboDeposito(int ID)
        {
            InitializeComponent();

            
            label1.Text = Convert.ToString(ID);
            
        }

        private void ReciboDeposito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetParaRecibos.DepositoDatos' table. You can move, or remove it, as needed.
            this.DepositoDatosTableAdapter.Fill(this.DataSetParaRecibos.DepositoDatos , Convert.ToInt32(label1.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal();
            this.Hide();
            form_MainMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
