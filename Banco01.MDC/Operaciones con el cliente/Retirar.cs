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
    public partial class Retirar : Form
    {
        private ValidaCajero_Result CurrentUser;
        private decimal BalanceCaja;
        public Retirar(string nroCuenta, decimal _balanceCaja = 0, ValidaCajero_Result _currentUser = null)
        {
            if (_currentUser == null)
            {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            BalanceCaja = _balanceCaja;

            InitializeComponent();

            label8.Text = nroCuenta;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Retirar_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSetParaRecibos.tblCuenta' table. You can move, or remove it, as needed.
            this.tblCuentaTableAdapter.Fill(this.dataSetParaRecibos.tblCuenta, label8.Text);
            // TODO: This line of code loads data into the 'dataSetParaRecibos.TablaPrueba' table. You can move, or remove it, as needed.
            this.tablaPruebaTableAdapter.Fill(this.dataSetParaRecibos.TablaPrueba);
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Value != 0)
            {
                DialogResult dr2 = MessageBox.Show("¿Esta seguro de que estos son los datos correctos?", "Confirmacion de datos ", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    var context = new MDC_LocalDBEntities();

                    //**** Sección de Cuadre ****//
                    int id_cuadre = -1;
                    foreach (var data in context.CuadreDiario)
                    {
                        if (data.Fecha.Date == DateTime.Now.Date)
                        {
                            id_cuadre = data.ID;
                            break;
                        }
                    }
                    int id_cajero = -1;
                    foreach (var data in context.GetCajero(CurrentUser.Usuario))
                    {
                        id_cajero = data.ID;
                        break;
                    }
                    if (id_cuadre != -1 && id_cajero != -1)
                    {
                        ///**** Verificacion de Balance Suficiente (en la caja) ****///
                        if (textBox1.Value > BalanceCaja)
                        {
                            var entrada = new HistorialTransacciones()
                            {
                                IDCajero = id_cajero,
                                IDCuadre = id_cuadre,
                                Fecha_Hora = DateTime.Now,
                                Tipo = "Entrada",
                                Monto = textBox1.Value * 1.5M //M: Tipo Decimal
                            };
                            context.HistorialTransacciones.Add(entrada);
                        }
                        ///**** Verificacion de Balance Suficiente (en la caja) ****///

                        var transaccion = new HistorialTransacciones()
                        {
                            IDCajero = id_cajero,
                            IDCuadre = id_cuadre,
                            Fecha_Hora = DateTime.Now,
                            Tipo = "Retiro",
                            Monto = -textBox1.Value
                        };
                        context.HistorialTransacciones.Add(transaccion);
                        context.SaveChanges();
                    }
                    //**** Sección de Cuadre ****//


                    if (label6.Text == "Conectado")
                    {


                        string con = "Data Source=banquito.database.windows.net;initial catalog=DataBaseCore;persist security info=True;user id=lcabrera;password=cabreraL10";

                        SqlConnection prueba = new SqlConnection();
                        prueba.ConnectionString = con;
                        Random rnd = new Random();
                        prueba.Open();


                        var retiro = new DepositoDatos()
                        {
                            Benefactor = "",
                            Especificaciones = Convert.ToString(textBox2).Remove(0, 36),
                            Monto = Convert.ToDecimal(textBox1.Text),
                            Fecha = DateTime.Now,
                            Nro_de_Cuenta = comboBox1.Text
                        };


                        SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [tblCuenta] WHERE (id_cuenta = @user)", prueba);
                        check_User_Name.Parameters.AddWithValue("@user", comboBox1.Text);
                        int UserExist = (int)check_User_Name.ExecuteScalar();

                        if (UserExist > 0)
                        {
                            SqlCommand insertCommand = new SqlCommand("INSERT INTO tblMoviminetos (Fecha, id_transaccion, Monto, Tipo_transaccion) VALUES (@0, @1, @2, @3)", prueba);
                            insertCommand.Parameters.Add(new SqlParameter("0", retiro.Fecha));
                            insertCommand.Parameters.Add(new SqlParameter("1", retiro.ID));
                            insertCommand.Parameters.Add(new SqlParameter("2", retiro.Monto));
                            insertCommand.Parameters.Add(new SqlParameter("3", "Retiro"));

                            insertCommand.ExecuteNonQuery();
                            prueba.Close();

                            MessageBox.Show("Retiro realizado con exito");
                            ReciboDeposito form_ReciboDConectado = new ReciboDeposito(retiro.ID);
                            this.Hide();
                            form_ReciboDConectado.Show();

                        }
                        else
                        {
                            MessageBox.Show("Retiro fuera de linea realizado con exito");
                            CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal(CurrentUser);
                            this.Hide();
                            form_MainMenu.Show();
                        }

                        //OperacionesCliente form_OpClientes = new OperacionesCliente();
                        //this.Hide();
                        //form_OpClientes.Show();

                    }


                }

            }
            else
            {
                DialogResult dr = MessageBox.Show("Debe llenar los campos pertinentes.", "Accion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }

        }
    }
}
