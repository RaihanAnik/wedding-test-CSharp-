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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

       

        private void MyAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
