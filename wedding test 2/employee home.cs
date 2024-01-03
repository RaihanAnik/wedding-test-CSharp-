using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wedding_test_2
{
    public partial class EmpHome : Form
    {
        public EmpHome()
        {
            InitializeComponent();
        }

      

        private void EmpHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
