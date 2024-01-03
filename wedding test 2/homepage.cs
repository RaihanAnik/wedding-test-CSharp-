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
    public partial class clienthome : Form
    {
      
        public clienthome()
        {
            InitializeComponent();
        }

      

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new bookvenue().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new clientprofile().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new bookstage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new bookfood().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }*/

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
  
        clientprofile c1 = new clientprofile();
            c1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookstage b1 = new bookstage();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookfood f1 = new bookfood();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookPhotography p1 = new BookPhotography();
            p1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingItem b2 = new BookingItem();
            b2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review r1 = new Review();
            r1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookvenue b3 = new bookvenue();
            b3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
