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
using log4net;
using System.Data.SqlClient;

namespace Banco01.MDC.Operaciones_con_el_cliente
{
    public partial class Deposito : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);
        private ValidaCajero_Result CurrentUser;
        public Deposito(ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Value != 0)
            {
                string nombre = textBox1.Text;
                string NumeroCuenta = textBox2.Text;
                decimal monto = textBox3.Value;




                DialogResult dr2 = MessageBox.Show("¿Esta seguro de que estos son los datos correctos?", "Confirmacion de datos ", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    var context = new MDC_LocalDBEntities();
                    var deposito = new DepositoDatos()
                    {
                        Benefactor = nombre,
                        Especificaciones = Convert.ToString(textBox4).Remove(0, 36),
                        Monto = monto,
                        Fecha = DateTime.Now,
                        Nro_de_Cuenta = NumeroCuenta
                    };

                    //**** Sección de Cuadre ****//
                    int id_cuadre = -1;
                    foreach (var data in context.CuadreDiario) {
                        if (data.Fecha.Date == DateTime.Now.Date) {
                            id_cuadre = data.ID;
                            break;
                        }
                    }
                    int id_cajero = -1;
                    foreach (var data in context.GetCajero(CurrentUser.Usuario)) {
                        id_cajero = data.ID;
                        break;
                    }
                    if (id_cuadre != -1 && id_cajero != -1) {
                        var transaccion = new HistorialTransacciones() {
                            IDCajero = id_cajero,
                            IDCuadre = id_cuadre,
                            Fecha_Hora = DateTime.Now,
                            Tipo = "Deposito",
                            Monto = monto,
                        };
                        context.HistorialTransacciones.Add(transaccion);
                    }
                    //**** Sección de Cuadre ****//

                   

                    
                    if (label7.Text == "Conectado")
                    {
                        string conn = "Data Source=banquito.database.windows.net;initial catalog=DataBaseCore;persist security info=True;user id=lcabrera;password=cabreraL10";
                        SqlConnection prueba = new SqlConnection();
                        prueba.ConnectionString = conn; 

                        prueba.Open();

                        SqlCommand insertCommand = new SqlCommand("INSERT INTO tblMoviminetos (Fecha, id_transaccion, Monto, Tipo_transaccion) VALUES (@0, @1, @2, @3)", prueba);
                        insertCommand.Parameters.Add(new SqlParameter("0", deposito.Fecha));
                        insertCommand.Parameters.Add(new SqlParameter("1", deposito.ID));
                        insertCommand.Parameters.Add(new SqlParameter("2", deposito.Monto));
                        insertCommand.Parameters.Add(new SqlParameter("3", "Deposito"));

                        insertCommand.ExecuteNonQuery();

                        prueba.Close();
                        MessageBox.Show("Deposito realizado con exito");

                    }
                    else
                    {
                        context.DepositoDatos.Add(deposito);


                    }

                    context.SaveChanges();
                    Logger.Info($"Han sido depositados {monto.ToString("C")} a la caja.");

                    //OperacionesCliente form_OpClientes = new OperacionesCliente();
                    //this.Hide();
                    //form_OpClientes.Show();
                    ReciboDeposito form_ReciboD = new ReciboDeposito(deposito.ID);
                    this.Hide();
                    form_ReciboD.Show();

                    //CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal(CurrentUser);
                    //this.Hide();
                    //form_MainMenu.Show();
                }

                
            }
            else { 
                
                DialogResult dr2 = MessageBox.Show("Parece que algun campo se quedo vacio. Por favor introduzca todos los datos", "Datos no introducidos",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            string con = "Data Source=banquito.database.windows.net;initial catalog=DataBaseCore;persist security info=True;user id=lcabrera;password=cabreraL10";
            try { 
                SqlConnection prueba = new SqlConnection();
                prueba.ConnectionString = con;

                prueba.Open();

                label7.ForeColor = Color.Green;
                label7.Text = "Conectado";
                
                prueba.Close();


            }

            catch (Exception ConnectionError)
            {
                MessageBox.Show(ConnectionError.Message);
                label7.ForeColor = Color.Red;
                label7.Text = "No conectado";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OperacionesCliente form_OpClientes = new OperacionesCliente();
            //this.Hide();
            //form_OpClientes.Show();

            CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal(CurrentUser);
            this.Hide();
            form_MainMenu.Show();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
