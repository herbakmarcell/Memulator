using MemulatorDLL;
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

        double memory = 0;
        double y = 0;
        List<string> chars = new List<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void division_Click(object sender, EventArgs e)
        {

        }
        // Verzió 1.2 - Marci
        private void num1_Click(object sender, EventArgs e)
        {
            if (chars.Count == 0)
            {
                chars.Add("1");
                displayOP.Text += "1";
                return;
            } else if (chars[0] == "0")
            {
                chars.RemoveAt(0);
                displayOP.Text = "";
                chars.Add("1");
                foreach (var chara in chars)
                {
                    displayOP.Text += chara;
                }
                return;
            }
            chars.Add("1");
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
        // Verzió 1.2 - Marci
        private void num0_Click(object sender, EventArgs e)
        {
            if (chars.Count == 0)
            {
                chars.Add("0");
                displayOP.Text += "0";
                return;
            }
            else if (chars[0] == "0")
            {
                return;
            }
            chars.Add("0");
            displayOP.Text += "0";
        }

        // Javítás
        private void plus_Click(object sender, EventArgs e)
        {
            if (displayOP.Text == "")
            {

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            
        }
        // Verzió 1.3 - Marci
        private void equals_Click(object sender, EventArgs e)
        {
            if (displayOP.Text == "")
            {
                try
                {
                    displayEQ.Text = memory.ToString();
                }
                catch (Exception)
                {
                    displayEQ.Text = "= SYNTAX ERROR";
                    return;
                }
                return;
            }

            try
            {
                memory = double.Parse(displayOP.Text);
            }
            catch (Exception)
            {
                // Ideiglenes
                throw;
            }
            displayEQ.Text = memory.ToString();
            chars.Clear();
            displayOP.Text = "";

        }

        private void squareroot_Click(object sender, EventArgs e)
        {

        }
    }
}
