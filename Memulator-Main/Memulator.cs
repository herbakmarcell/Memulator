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

        //Marcinak: Amennyiben egészen számolunk long, amennyiben tört double. 
        bool usedOperator = false;
        bool addition = false;
        double x = 0;
        double y = 0;
        double memory = 0;

        


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
            if (usedOperator)
            {
                return;
            }

            if (displayOP.Text=="")
            {
                return;
            }
            try
            {
                x = double.Parse(displayOP.Text);

            }
            catch (Exception)
            {
                displayEQ.Text = "= Not Number!";
            }


            addition = true;
            displayEQ.Text = x.ToString();
            displayOP.Text = "";
            

        }

        private void minus_Click(object sender, EventArgs e)
        {
            
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (displayEQ.Text=="")
            {
                if (usedOperator)
                {
                    y = 0;
                }
                else
                {
                    x = 0;
                    y = 0;
                }


            }
            if (addition)
            {
                if (memory != 0)
                {
                    try
                    {
                        y = double.Parse(displayOP.Text);
                    }
                    catch (Exception)
                    {
                        displayEQ.Text = "Not A Number!";
                        memory = 0;
                        x = 0;
                        y = 0;
                        usedOperator = false;
                        addition = false;
                        return;
                    }
                    displayEQ.Text = "= " + MemulatorHelper.Addition(memory, y).ToString();
                    memory = MemulatorHelper.Addition(memory, y);
                    usedOperator = false;
                    addition = false;
                    displayOP.Text = "";
                }
                try
                {
                    y = double.Parse(displayOP.Text);
                }
                catch (Exception)
                {
                    displayEQ.Text = "Not A Number!";
                    memory = 0;
                    x = 0;
                    y = 0;
                    usedOperator = false;
                    addition = false;
                    return;
                }
                displayEQ.Text = "= "+MemulatorHelper.Addition(x,y).ToString();
                memory = MemulatorHelper.Addition(x, y);
                usedOperator = false;
                addition = false;
                displayOP.Text = "";
            }
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (displayOP.Text=="")
            {
                return;
            }
            try
            {
                x = double.Parse(displayOP.Text);
            }
            catch (Exception)
            {
                displayEQ.Text = "Syntacs Error!";
                x = 0;
                y = 0;
                memory = 0;
                return;
            }
            if (x<0)
            {
                displayEQ.Text = "MATH Error!";
            }
            memory = MemulatorHelper.Sqrt(x);
            displayEQ.Text = memory.ToString();
            x = 0;
            displayOP.Text = "";

        }
    }
}
