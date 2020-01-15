using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Banco01.MDC.Resources;
using System.Data.Entity;

namespace Banco01.MDC.Cuadre
{
    public partial class CentroCuadres : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);
        public CentroCuadres()
        {
            InitializeComponent();
        }

        private void CentroCuadres_Load(object sender, EventArgs e)
        {
            MDC_LocalDBEntities localDBEntity = new MDC_LocalDBEntities();
            localDBEntity.DetallesCuadre.Load();
            this.detallesCuadreBindingSource.DataSource = localDBEntity.DetallesCuadre.Local.ToBindingList();
        }
    }
}
