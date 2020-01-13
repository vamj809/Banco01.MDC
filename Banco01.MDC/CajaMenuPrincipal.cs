using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Banco01.MDC.Resources;
using Banco01.MDC.Cajero;
using Banco01.MDC.Cuadre;
using log4net;
using System.Globalization;

namespace Banco01.MDC
{
    public partial class CajaMenuPrincipal : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);
        private ValidaCajero_Result CurrentUser;
        public CajaMenuPrincipal(ValidaCajero_Result _currentUser = null)
        {
            if(_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
            TimeOfDayLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            if (_currentUser != null) {
                CurrentUser = _currentUser;
                if (_currentUser.isAdmin) {
                    CashInputButton.Visible = true;
                    newUserMenuItem.Visible = true;
                    newUserSeparator.Visible = true;
                }
                if (_currentUser.Nombre.Length > 0)
                    WelcomeLabel.Text = $"Bienvenido/a {_currentUser.Nombre}";
                if (_currentUser.Sucursal.Length > 0)
                    this.Text += $" - {_currentUser.Sucursal}";
            }
        }

        private void CajaMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOffMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrentUser != null)
                Logger.Info($"{CurrentUser.Usuario} acaba de cerrar sesión via menu.");
            Login form_Login = new Login();
            this.Hide();
            form_Login.Show();
        }

        private void EditMyProfile_Click(object sender, EventArgs e)
        {
            Cajero.EditProfile formProfileEditor = new Cajero.EditProfile(CurrentUser);
            this.Hide();
            formProfileEditor.Show();
        }

        private void worldTimer_Tick(object sender, EventArgs e)
        {
            TimeOfDayLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult slctDeEfectivo = MessageBox.Show("ADVERTENCIA: Esta opcion enviara una solicitud a la sucursal principal para que envien mas fondos a esta sucursal. ¿Desea Proseguir? ", "Solicitud de Fondos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (slctDeEfectivo == DialogResult.Yes)
                MessageBox.Show("La solicitud fue enviada y aprobada satisfactoriamente, los fondos llegaran en breve.", "Solicitud aprobada");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CajaMenuPrincipal_Load(object sender, EventArgs e)
        {
            using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                foreach(var data in localDBEntity.CuadreDiario) {
                    if (data.Fecha.Date == DateTime.Now.Date) {
                        if(data.Monto_Fin != null)
                            BalanceActualLabel.Text = data.Monto_Fin?.ToString("C");
                        return;
                    }
                }
                //Si llega a este significa que no ha iniciado el cuadre del dia.
                CuadreDiario detalles_cuadre = new CuadreDiario {
                    Monto_Inicio = new Random().Next(20, 100) * 1000,
                    Fecha = DateTime.Now.Date
                };
                detalles_cuadre.Monto_Fin = detalles_cuadre.Monto_Inicio;
                localDBEntity.CuadreDiario.Add(detalles_cuadre);
                //Logger.Debug($"{detalles_cuadre.Fecha.ToShortDateString()} - {detalles_cuadre.Monto_Inicio}");
                //Logger.Debug($"{detalles_cuadre.ID} - ID antes del cambio.");
                localDBEntity.SaveChanges();
                //Logger.Debug($"{detalles_cuadre.ID} - ID después del cambio.");
                string message = $"Dia inició con {detalles_cuadre.Monto_Inicio.ToString("C")} en caja.";
                BalanceActualLabel.Text = detalles_cuadre.Monto_Inicio.ToString("C");
                MessageBox.Show(message,"Inicio de la jornada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Logger.Info(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesCliente form_OpClientes = new OperacionesCliente();
            this.Hide();
            form_OpClientes.Show();
        }

        private void CashInputButton_Click(object sender, EventArgs e)
        {
            CashInputForm inputForm = new CashInputForm();
            decimal montoAgregado = 0;
            bool addedCash = false;
            if (inputForm.ShowDialog(this) == DialogResult.OK) {
                //formato: $900,000,000,000,000.00
                addedCash = true;
                montoAgregado = inputForm.Monto.Value;
            }
            //Realizado de esta forma porque Entity Framework no permite varias ventanas al mismo tiempo,
            //... cuando se ejecutará una transacción SQL.
            if (addedCash) {
                inputForm.Close();
                inputForm.Dispose();
                int DateID = -1;
                using (MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities()) {
                    foreach (var data in localDBEntity.CuadreDiario) {
                        if (data.Fecha.Date == DateTime.Now.Date) {
                            DateID = data.ID;
                            break;
                        }
                    }
                    decimal BalanceActual = Decimal.Parse(BalanceActualLabel.Text, NumberStyles.Currency);
                    CuadreDiario datos_cuadre = localDBEntity.CuadreDiario.Find(DateID);
                    datos_cuadre.Monto_Fin = (BalanceActual + montoAgregado);
                    localDBEntity.SaveChanges();
                    Logger.Info($"Han entrado {montoAgregado.ToString("C")} a la caja.");
                    BalanceActualLabel.Text = (BalanceActual + montoAgregado).ToString("C");
                }
            }
        }

        private void newUserMenuItem_Click(object sender, EventArgs e)
        {
            AddProfile nuevoPerfil = new AddProfile();
            nuevoPerfil.ShowDialog();
        }
    }
}
