using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memulator_Main
{
    public partial class Memulator : Form
    {
        public Memulator()
        {
            InitializeComponent();
        }

        double x = 0;
        double y = 0;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            displayOP.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            displayOP.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            displayOP.Text += "3";
        }
    }
}
