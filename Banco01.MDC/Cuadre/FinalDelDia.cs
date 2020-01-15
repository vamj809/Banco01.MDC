using System;
using System.Windows.Forms;
using Banco01.MDC.Resources;
using Banco01.MDC.Cajero;
using System.Data.Entity;

namespace Banco01.MDC.Cuadre
{
    public partial class FinalDelDia : Form
    {
        private readonly ValidaCajero_Result CurrentUser;
        public FinalDelDia(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void FinalDelDia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDC_LocalDBDataSet.HistorialTransacciones' table. You can move, or remove it, as needed.
            //dataGridView1.DataSource = new MDC_LocalDBEntities().HistorialTransacciones;
            //this.historialTransaccionesTableAdapter.Fill(this.mDC_LocalDBDataSet.HistorialTransacciones);
            int DateID = -1;
            using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                localDBEntity.DetallesCuadre.Load();
                this.detallesCuadreBindingSource.DataSource = localDBEntity.DetallesCuadre.Local.ToBindingList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            CajaMenuPrincipal mm = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            mm.Show();
        }
    }
}
