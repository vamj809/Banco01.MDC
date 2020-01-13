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

namespace Banco01.MDC.Cuadre
{
    public partial class CentroCuadres : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);
        public CentroCuadres()
        {
            InitializeComponent();
        }

        private void CashInputButton_Click(object sender, EventArgs e)
        {
            CashInputForm inputForm = new CashInputForm();
            if (inputForm.ShowDialog(this) == DialogResult.OK) {
                //formato: $900,000,000,000,000.00
                decimal valor = inputForm.Monto.Value;
                decimal old_value = Decimal.Parse(BalanceActualLabel.Text, NumberStyles.Currency);
                BalanceActualLabel.Text = (valor + old_value).ToString("C");
                Logger.Info($"Han entrado {valor} a la caja.");
            }
        }

        private void CentroCuadres_Load(object sender, EventArgs e)
        {
            using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                DateTime hoy = DateTime.Now.Date;
                foreach (var data in localDBEntity.CuadreDiario) {
                    if (data.Fecha.Date == DateTime.Now.Date) {
                        if(BalanceActualLabel.Text == "$0.00")
                            BalanceActualLabel.Text = data.Monto_Inicio.ToString("C");
                        return;
                    }
                }
                //Si llega a este significa que no ha iniciado el cuadre del dia.
                CuadreDiario detalles_cuadre = new CuadreDiario {
                    Monto_Inicio = new Random().Next(20, 100) * 1000,
                    Fecha = DateTime.Now.Date
                };
                localDBEntity.CuadreDiario.Add(detalles_cuadre);
                //Logger.Debug($"{detalles_cuadre.Fecha.ToShortDateString()} - {detalles_cuadre.Monto_Inicio}");
                //Logger.Debug($"{detalles_cuadre.ID} - ID antes del cambio.");
                localDBEntity.SaveChanges();
                //Logger.Debug($"{detalles_cuadre.ID} - ID después del cambio.");
                string message = $"Dia inició con {detalles_cuadre.Monto_Inicio.ToString("C")} en caja.";
                BalanceActualLabel.Text = detalles_cuadre.Monto_Inicio.ToString("C");
                MessageBox.Show(message, "Inicio de la jornada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Info(message);
            }
        }
    }
}
