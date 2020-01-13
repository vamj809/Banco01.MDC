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
            using(MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                CuadreDiario detalles_cuadre = localDBEntity.CuadreDiario.Where(d => d.Fecha.Equals(DateTime.Now.Date))?.First();
                if(detalles_cuadre == null) {
                    detalles_cuadre.Monto_Inicio = new Random().Next(20, 100) * 1000;
                    detalles_cuadre.Fecha = DateTime.Now.Date;
                    localDBEntity.CuadreDiario.Add(detalles_cuadre);
                    localDBEntity.SaveChanges();
                    Logger.Info($"Dia inició con {detalles_cuadre.Monto_Inicio} en caja.");
                }
            }
        }
    }
}
