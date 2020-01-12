using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco01.MDC
{
    public partial class TestDB_Connection : Form
    {
        public TestDB_Connection()
        {
            InitializeComponent();
        }

        private void TestDB_Connection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'temp_MDC_LocalDBDataSet.Test_Table' table. You can move, or remove it, as needed.
            this.test_TableTableAdapter.Fill(this.temp_MDC_LocalDBDataSet.Test_Table);

        }
    }
}
