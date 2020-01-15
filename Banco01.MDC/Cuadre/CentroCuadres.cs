using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Banco01.MDC.Resources;
using System.Data.Entity;
using Banco01.MDC.Cajero;

namespace Banco01.MDC.Cuadre
{
    public partial class CentroCuadres : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);
        private readonly ValidaCajero_Result CurrentUser;
        public CentroCuadres(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void CentroCuadres_Load(object sender, EventArgs e)
        {
            MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities();
            localDBEntity.DetallesCuadre.Load();
            this.detallesCuadreBindingSource.DataSource = localDBEntity.DetallesCuadre.Local.ToBindingList();
            dataGridView1.Sort(dataGridView1.Columns["Hora"], ListSortDirection.Ascending);
            
            //Toma todas las fechas, y busca la más antigua y la más reciente.
            var dateTimes = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Select(x => (DateTime) x.Cells["Hora"].Value);
            var minValue = dateTimes.Min();
            var maxValue = dateTimes.Max();

            Fecha_Inicio.Value = maxValue;
            Fecha_Inicio.MinDate = minValue;
            Fecha_Inicio.MaxDate = maxValue;

            Fecha_Fin = Fecha_Inicio;
            //// Manejo de Fechas ^^^
        }

        private void CentroCuadres_FormClosing(object sender, FormClosingEventArgs e)
        {
            CajaMenuPrincipal mm = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            mm.Show();
        }

        private void Fechas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
