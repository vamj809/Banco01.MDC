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
using Banco01.MDC.Cajero;
using System.Data.SqlClient;

namespace Banco01.MDC.Operaciones_con_el_cliente
{
    public partial class ComprobacionCliente : Form
    {
        private ValidaCajero_Result CurrentUser;
        private decimal Balance;
        public ComprobacionCliente(ValidaCajero_Result _currentUser = null, decimal _balance = 0)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            Balance = _balance;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            form_MainMenu.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && label6.Text == "Conectado" )
            {
                string con = "Data Source=banquito.database.windows.net;initial catalog=DataBaseCore;persist security info=True;user id=lcabrera;password=cabreraL10";
                try
                {
                    SqlConnection prueba = new SqlConnection();
                    prueba.ConnectionString = con;

                    prueba.Open();
                    

                    prueba.Close();


                    MessageBox.Show("Datos correctos", "Datos Correctos");
                    Retirar form_Retiro = new Retirar(CurrentUser, Balance);
                    this.Hide();
                    form_Retiro.Show();


                }

                catch (Exception ConnectionError)
                {
                    MessageBox.Show(ConnectionError.Message);
                    label6.ForeColor = Color.Red;
                    label6.Text = "No conectado";
                }

                //MessageBox.Show("Datos correctos", "Datos Correctos");
                //Retirar form_Retiro = new Retirar(CurrentUser, Balance);
                //this.Hide();
                //form_Retiro.Show();
            }
            else
                MessageBox.Show("El sistema no esta disponible actualmente. Los retiros no estan permitidos por esa razon");
        }

        private void ComprobacionCliente_Load(object sender, EventArgs e)
        {
            string con = "Data Source=banquito.database.windows.net;initial catalog=DataBaseCore;persist security info=True;user id=lcabrera;password=cabreraL10";
            try
            {
                SqlConnection prueba = new SqlConnection();
                prueba.ConnectionString = con;

                prueba.Open();

                label6.ForeColor = Color.Green;
                label6.Text = "Conectado";

                prueba.Close();


            }

            catch (Exception ConnectionError)
            {
                MessageBox.Show(ConnectionError.Message);
                label6.ForeColor = Color.Red;
                label6.Text = "No conectado";
            }
        }
    }
}
