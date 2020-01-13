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

namespace Banco01.MDC.Cuadre
{
    public partial class FinalDelDia : Form
    {
        public FinalDelDia()
        {
            InitializeComponent();
        }

        private void FinalDelDia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDC_LocalDBDataSet.HistorialTransacciones' table. You can move, or remove it, as needed.
            this.historialTransaccionesTableAdapter.Fill(this.mDC_LocalDBDataSet.HistorialTransacciones);
            int DateID = -1;
            using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                foreach (var data in localDBEntity.CuadreDiario) {
                    if (data.Fecha.Date == DateTime.Now.Date) {
                        DateID = data.ID;
                        break;
                    }
                }
                CuadreDiario datos_cuadre = localDBEntity.CuadreDiario.Find(DateID);
                DateLabel.Text = datos_cuadre.Fecha.ToShortDateString();
                MontoInicioLabel.Text = datos_cuadre.Monto_Inicio.ToString("C");
                MontoFinLabel.Text = datos_cuadre.Monto_Fin?.ToString("C");
            }
        }
    }
}
