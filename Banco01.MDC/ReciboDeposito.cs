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
        public ReciboDeposito()
        {
            InitializeComponent();
        }

        private void ReciboDeposito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetParaRecibos.DepositoDatos' table. You can move, or remove it, as needed.
            this.DepositoDatosTableAdapter.Fill(this.DataSetParaRecibos.DepositoDatos);

            this.reportViewer1.RefreshReport();
        }
    }
}
