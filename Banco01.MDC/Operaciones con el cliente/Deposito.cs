﻿using System;
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
                        Fecha = DateTime.Now,
                        Especificaciones = Convert.ToString(textBox4),
                        Monto = monto,
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
                            Tipo = "Deposito",
                            Monto = monto
                        };
                        context.HistorialTransacciones.Add(transaccion);
                    }
                    //**** Sección de Cuadre ****//

                    context.DepositoDatos.Add(deposito);
                    context.SaveChanges();
                    Logger.Info("Deposito realizado con exito.");
                    MessageBox.Show("Deposito realizado con exito");


                    OperacionesCliente form_OpClientes = new OperacionesCliente();
                    this.Hide();
                    form_OpClientes.Show();
                }

                
            }
            else { 
                
                DialogResult dr2 = MessageBox.Show("Parece que algun campo se quedo vacio. Por favor introduzca todos los datos", "Datos no introducidos",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperacionesCliente form_OpClientes = new OperacionesCliente();
            this.Hide();
            form_OpClientes.Show();
        }
    }
}
