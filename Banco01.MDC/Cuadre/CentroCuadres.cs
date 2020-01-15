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
        MDC_LocalDBEntities localDBEntity;
        public CentroCuadres(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void updateFilters()
        {
            var filteredData = localDBEntity.DetallesCuadre.Local.ToBindingList()
                .Where(x => (
                    x.Hora.Date.CompareTo(Fecha_Inicio.Value.Date) >= 0 && 
                    x.Hora.Date.CompareTo(Fecha_Fin.Value.Date) <= 0)
                );
            this.detallesCuadreBindingSource.DataSource = filteredData.Count() > 0 ?
                filteredData : filteredData.ToArray();
        }

        private void CentroCuadres_Load(object sender, EventArgs e)
        {
            localDBEntity = new MDC_LocalDBEntities();
            localDBEntity.DetallesCuadre.Load();
            this.detallesCuadreBindingSource.DataSource = localDBEntity.DetallesCuadre.Local.ToBindingList();
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending); //Columna 1 = Fecha/Hora

            //Toma todas las fechas, y busca la más antigua y la más reciente.
            var dateTimes = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Select(x => (DateTime) x.Cells[1].Value); //Columna 1 = Fecha_Hora
            var minValue = dateTimes.Min();
            var maxValue = dateTimes.Max();

            Fecha_Inicio.Value = maxValue;
            Fecha_Inicio.MinDate = minValue;
            Fecha_Inicio.MaxDate = maxValue;

            Fecha_Fin.Value = maxValue;
            Fecha_Fin.MinDate = minValue;
            Fecha_Fin.MaxDate = maxValue;
            //// Manejo de Fechas ^^^
        }

        private void CentroCuadres_FormClosing(object sender, FormClosingEventArgs e)
        {
            CajaMenuPrincipal mm = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            mm.Show();
        }

        private void OnlyTodayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyTodayCheck.Checked) {
                Fecha_Inicio.Enabled = false;
                Fecha_Fin.Enabled = false;
                var filteredData = localDBEntity.DetallesCuadre.Local.ToBindingList()
                .Where(x => x.Hora.Date.CompareTo(DateTime.Now.Date) == 0);
                this.detallesCuadreBindingSource.DataSource = filteredData.Count() > 0 ?
                    filteredData : filteredData.ToArray();
            } else {
                Fecha_Inicio.Enabled = true;
                Fecha_Fin.Enabled = true;
                updateFilters();
            }
        }

        private void Fecha_Inicio_ValueChanged(object sender, EventArgs e)
        {
            if (Fecha_Inicio.Value > Fecha_Fin.Value) {
                MessageBox.Show("La fecha de inicio debe ser menor o igual a la final.");
                Fecha_Inicio.Value = Fecha_Fin.Value;
            }
            updateFilters();
        }

        private void Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            if (Fecha_Fin.Value > Fecha_Fin.Value) {
                MessageBox.Show("La fecha fin debe ser mayor o igual a la de inicio.");
                Fecha_Fin.Value = Fecha_Inicio.Value;
            }
            updateFilters();
        }
    }
}
