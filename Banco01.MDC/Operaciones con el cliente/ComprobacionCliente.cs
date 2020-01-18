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

                SqlConnection prueba = new SqlConnection();
                prueba.ConnectionString = con;

                prueba.Open();


                SqlCommand check_Client = new SqlCommand("SELECT COUNT(*) FROM [tblCliente] WHERE (Cedula = @cedula) ", prueba);
                check_Client.Parameters.AddWithValue("@cedula", textBox1.Text);
                int UserExist = (int)check_Client.ExecuteScalar();

                SqlCommand check_LastName = new SqlCommand("SELECT COUNT(*) FROM [tblCliente] WHERE (Apellido = @apellido) AND Cedula="+textBox1.Text, prueba);
                check_LastName.Parameters.AddWithValue("@apellido", textBox2.Text);
                int lastNameExist = (int)check_Client.ExecuteScalar();


                SqlCommand check_FirstName = new SqlCommand("SELECT COUNT(*) FROM [tblCliente] WHERE (Nombre = @nombre) AND Cedula=" + textBox1.Text, prueba);
                check_Client.Parameters.AddWithValue("@nombre", textBox3.Text);
                int FirstNameExist = (int)check_Client.ExecuteScalar();

                if (UserExist == 1 && lastNameExist == 1 && FirstNameExist == 1)
                {
                    //SqlCommand insertCommand = new SqlCommand("INSERT INTO tblMoviminetos (Fecha, id_transaccion, Monto, Tipo_transaccion) VALUES (@0, @1, @2, @3)", prueba);
                    //insertCommand.Parameters.Add(new SqlParameter("0", deposito.Fecha));
                    //insertCommand.Parameters.Add(new SqlParameter("1", deposito.ID));
                    //insertCommand.Parameters.Add(new SqlParameter("2", deposito.Monto));
                    //insertCommand.Parameters.Add(new SqlParameter("3", "Deposito"));

                    //insertCommand.ExecuteNonQuery();
                    //prueba.Close();

                    //MessageBox.Show("Deposito realizado con exito");
                    //ReciboDeposito form_ReciboDConectado = new ReciboDeposito(deposito.ID);
                    //this.Hide();
                    //form_ReciboDConectado.Show();


                    MessageBox.Show("Datos correctos", "Datos Correctos");
                    Retirar form_Retiro = new Retirar(textBox1.Text , Balance, CurrentUser);
                    this.Hide();
                    form_Retiro.Show();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no se encuentran en la base de datos. Por favor ingrese datos validos.");
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
