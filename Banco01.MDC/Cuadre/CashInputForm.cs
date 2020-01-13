using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco01.MDC.Cuadre
{
    public partial class CashInputForm : Form
    {
        public CashInputForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
                    "La solicitud fue enviada y aprobada satisfactoriamente, " +
                    "los fondos llegaran en breve.", "Solicitud aprobada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
