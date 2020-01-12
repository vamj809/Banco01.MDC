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

namespace Banco01.MDC.Cajero
{
    public partial class EditProfile : Form
    {
        private ValidaCajero_Result CurrentUser;
        public EditProfile(ValidaCajero_Result _currentUser = null)
        {
            InitializeComponent();
            if(_currentUser != null) {
                CurrentUser = _currentUser;
                label1.Text = CurrentUser.Usuario + "\n" +
                              CurrentUser.Nombre + "\n" +
                              CurrentUser.Sucursal;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
