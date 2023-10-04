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

        //Marcinak: Amennyiben egészen számolunk long, amennyiben tört double. 

        double x = 0;
        double y = 0;
        double temp = 0;


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

        private void num4_Click(object sender, EventArgs e)
        {
            displayOP.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            displayOP.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            displayOP.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            displayOP.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            displayOP.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            displayOP.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            displayOP.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (displayOP.Text=="")
            {
                return;
            }
            try
            {
                temp = double.Parse(displayOP.Text);
            }
            catch (Exception)
            {
                displayEQ.Text = "= Not A Number!";
                displayOP.Text = "";
                throw;
            }
            x += temp;
            temp = 0;
            displayEQ.Text = "= "+x.ToString();
            displayOP.Text = "";


        }
    }
}
