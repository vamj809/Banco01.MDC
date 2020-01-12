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
        private UserData CurrentUser;
        public EditProfile(UserData _currentUser = null)
        {
            InitializeComponent();
            if(_currentUser != null) {
                label1.Text = _currentUser.Usuario + "\n" +
                              _currentUser.Nombre + "\n" +
                              _currentUser.Sucursal;
            }
        }
    }
}
