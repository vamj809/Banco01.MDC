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
        public CajaMenuPrincipal(ValidaCajero_Result currentUser = null)
        {
            InitializeComponent();
            TimeOfDayLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            if (currentUser != null) {
                CurrentUser = currentUser;
                if (currentUser.isAdmin) {
                    CashInputButton.Visible = true;
                    newUserMenuItem.Visible = true;
                    newUserSeparator.Visible = true;
                }
                if (currentUser.Nombre.Length > 0)
                    WelcomeLabel.Text = $"Bienvenido/a {currentUser.Nombre}";
                if (currentUser.Sucursal.Length > 0)
                    this.Text += $" - {currentUser.Sucursal}";
            }
        }

        private void CajaMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOffMenuItem_Click(object sender, EventArgs e)
        {
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesCLiente form_OpClientes = new OperacionesCLiente();
            this.Hide();
            form_OpClientes.Show();
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

        private void newUserMenuItem_Click(object sender, EventArgs e)
        {
            AddProfile nuevoPerfil = new AddProfile();
            nuevoPerfil.ShowDialog();
        }
    }
}
