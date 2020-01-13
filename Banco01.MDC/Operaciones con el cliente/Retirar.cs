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

namespace Banco01.MDC.Operaciones_con_el_cliente
{
    public partial class Retirar : Form
    {
        private ValidaCajero_Result CurrentUser;
        private decimal BalanceCaja;
        public Retirar(ValidaCajero_Result _currentUser = null, decimal _balanceCaja = 0)
        {
            if (_currentUser == null) {
                _currentUser = new CajeroEspecial();
            }
            CurrentUser = _currentUser;
            BalanceCaja = _balanceCaja;
            InitializeComponent();
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
            label7.Text = BalanceCaja.ToString("C");
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
            if (comboBox1.SelectedIndex != 0   && textBox1.Value != 0)
            {
                DialogResult dr2 = MessageBox.Show("¿Esta seguro de que estos son los datos correctos?", "Confirmacion de datos ", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    var context = new MDC_LocalDBEntities();

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
                        ///**** Verificacion de Balance Suficiente (en la caja) ****///
                        if (textBox1.Value > BalanceCaja) {
                            var entrada = new HistorialTransacciones() {
                                IDCajero = id_cajero,
                                IDCuadre = id_cuadre,
                                Tipo = "Entrada",
                                Monto = textBox1.Value * 1.5M //M: Tipo Decimal
                            };
                            context.HistorialTransacciones.Add(entrada);
                        }
                        ///**** Verificacion de Balance Suficiente (en la caja) ****///
                        
                        var transaccion = new HistorialTransacciones() {
                            IDCajero = id_cajero,
                            IDCuadre = id_cuadre,
                            Tipo = "Retiro",
                            Monto = -textBox1.Value
                        };
                        context.HistorialTransacciones.Add(transaccion);
                        context.SaveChanges();
                    }
                    //**** Sección de Cuadre ****//

                    MessageBox.Show("Retiro realizado con exito");
                    //OperacionesCliente form_OpClientes = new OperacionesCliente();
                    //this.Hide();
                    //form_OpClientes.Show();
                    CajaMenuPrincipal form_MainMenu = new CajaMenuPrincipal(CurrentUser);
                    this.Hide();
                    form_MainMenu.Show();
                }


            } else {
                DialogResult dr = MessageBox.Show("Debe llenar los campos pertinentes.", "Accion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
