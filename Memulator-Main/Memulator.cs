﻿using MemulatorDLL;
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
            displayOP.Text = "0"; // Default value
        }

        double memory = 0; // First argument and requirement for saving the 
        double y = 0; // Second argument (if needed)
        string operation = "";
        bool equalUsed = false;

        // Saved for backtrack purposes
        //bool secondState = false; // Used by operators with 2 arguments
        //bool addUsed = false; // If an addition was invoked
        //bool subUsed = false; // If a subtraction was invoked
        //bool mulUsed = false; // If a multiplication was invoked

        private void num0_Click(object sender, EventArgs e)
        {
            if (displayOP.Text == "0")
            {
                return;
            }
            displayOP.Text += "0";

            //if (chars.Count == 0)
            //{
            //    chars.Add("0");
            //    displayOP.Text += "0";
            //    return;
            //}
            //else if (chars[0] == "0")
            //{
            //    return;
            //}
            //chars.Add("0");
            //displayOP.Text += "0";
        }
        // Verzió 1.2 - Marci - Egész számokra működik
        private void num1_Click(object sender, EventArgs e)
        {
            if (displayOP.Text == "0")
            {
                displayOP.Text = "1";
                return;
            }
            displayOP.Text += "1";

            // Saved for backtrack purposes
            //if (chars.Count == 0)
            //{
            //    chars.Add("1");
            //    displayOP.Text += "1";
            //    return;
            //} else if (chars[0] == "0")
            //{
            //    chars.RemoveAt(0);
            //    displayOP.Text = "";
            //    chars.Add("1");
            //    foreach (var chara in chars)
            //    {
            //        displayOP.Text += chara;
            //    }
            //    return;
            //}
            //chars.Add("1");
            //displayOP.Text += "1";

        }

        private void num2_Click(object sender, EventArgs e)
        {
           
        }

        private void num3_Click(object sender, EventArgs e)
        {
           
        }

        private void num4_Click(object sender, EventArgs e)
        {
           
        }

        private void num5_Click(object sender, EventArgs e)
        {
            
        }

        private void num6_Click(object sender, EventArgs e)
        {
            
        }

        private void num7_Click(object sender, EventArgs e)
        {

        }

        private void num8_Click(object sender, EventArgs e)
        {
            
        }

        private void num9_Click(object sender, EventArgs e)
        {
           
        }

        // Verzió 0.6 - Marci - Újragondolva (Aludtam rá 8+2 órát)
        private void plus_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                memory = MemulatorHelper.Addition(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }
            operation = "+";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }
            
            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";


            // Saved for backtrack purposes
            //// Ez kell minden művelet előtti tesztre
            //if (subUsed && secondState)
            //{
            //    subUsed = false;
            //    y = double.Parse(displayOP.Text);
            //    memory = MemulatorHelper.Subtract(memory, y);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = memory.ToString();
            //}

            //addUsed = true;
            ////Amennyiben megcsináltad a többi műveletet, rakd itt false-ra
            //if (!secondState)
            //{
            //    memory = double.Parse(displayOP.Text);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = memory.ToString();
            //    addUsed = true;
            //    secondState = true;
            //    return;
            //}
            //if (secondState)
            //{
            //    if (displayOP.Text == "")
            //    {
            //        return;
            //    }
            //    y = double.Parse(displayOP.Text);
            //    memory = MemulatorHelper.Addition(memory, y);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = memory.ToString();
            //    return;
            //}
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (operation == "-")
            {
                memory = MemulatorHelper.Subtract(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "-";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
        }

        // Verzió 0.5 - Marci - Működő összeadás
        private void equals_Click(object sender, EventArgs e)
        {
            equalUsed = true;
            y = double.Parse(displayOP.Text);

            switch (operation)
            {
                case "+":
                    memory = MemulatorHelper.Addition(memory, y);
                    operation = "";
                    break;
                case "-":
                    memory = MemulatorHelper.Subtract(memory, y);
                    operation = "";
                    break;
                case "*":
                    memory = MemulatorHelper.Multiply(memory, y);
                    operation = "";
                    break;
                default:
                    break;
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";

            //if (addUsed && secondState)
            //{
            //    y = double.Parse(displayOP.Text);
            //    memory = MemulatorHelper.Addition(memory, y);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = "= " + memory.ToString();
            //    addUsed = false;
            //    return;
            //}

            //if (subUsed && secondState)
            //{
            //    y = double.Parse(displayOP.Text);
            //    memory = MemulatorHelper.Subtract(memory, y);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = "= " + memory.ToString();
            //    subUsed = false;
            //    return;
            //}

            //if (mulUsed && secondState)
            //{
            //    y = double.Parse(displayOP.Text);
            //    memory = MemulatorHelper.Multiply(memory, y);
            //    chars.Clear();
            //    displayOP.Text = "0";
            //    chars.Add("0");
            //    displayEQ.Text = memory.ToString();
            //    mulUsed = false;
            //    secondState = false;
            //    return;
            //}

            //memory = double.Parse(displayOP.Text);
            //displayEQ.Text = "= " + displayOP.Text;
            //chars.Clear();
            //displayOP.Text = "0";
            //chars.Add("0");

        }

        private void squareroot_Click(object sender, EventArgs e)
        {

        }

        private void allclear_Click(object sender, EventArgs e)
        {
            memory = 0;
            displayEQ.Text = "";
            y = 0;
            displayOP.Text = "0";
            operation = "";
            equalUsed = false;


            //secondState = false;
            ////Amennyiben megcsináltad a többi műveletet írd a state-jét ide
            //addUsed = false;
            //subUsed = false;
            //mulUsed = false;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operation == "*")
            {
                memory = MemulatorHelper.Multiply(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "*";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {

        }
    }
}
