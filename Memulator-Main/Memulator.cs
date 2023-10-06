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
            chars.Add("0"); // Default value
        }

        double memory = 0; // First argument and requirement for saving the number
        double y = 0; // Second argument (if needed)
        List<string> chars = new List<string>(); // Checklist for 0 and dot (.) at the beginning of the number

        bool secondState = false; // Used by operators with 2 arguments
        bool addUsed = false; // If an addition was invoked

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void division_Click(object sender, EventArgs e)
        {

        }
        // Verzió 1.2 - Marci - Egész számokra működik
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
            if (chars.Count == 0)
            {
                chars.Add("2");
                displayOP.Text += "2";
                return;
            }
            else if (chars[0] == "0")
            {
                chars.RemoveAt(0);
                displayOP.Text = "";
                chars.Add("2");
                foreach (var chara in chars)
                {
                    displayOP.Text += chara;
                }
                return;
            }
            chars.Add("2");
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
        // Verzió 1.3 - Marci - Egész számokra működik
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

        // Verzió 0.4.1 - Barnabás - Egész számokra működik
        private void plus_Click(object sender, EventArgs e)
        {
            addUsed = true;
            //Amennyiben megcsináltad a többi műveletet, rakd itt false-ra
            if (!secondState)
            {
                
                memory = double.Parse(displayOP.Text);
                chars.Clear();
                displayOP.Text = "0";
                chars.Add("0");
                displayEQ.Text = memory.ToString();
                secondState = true;
                return;
            }
            if (secondState)
            {
                if (displayOP.Text == "")
                {
                    return;
                }
                y = double.Parse(displayOP.Text);
                memory = MemulatorHelper.Addition(memory, y);
                chars.Clear();
                displayOP.Text = "0";
                chars.Add("0");
                displayEQ.Text = memory.ToString();
                return;
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            
        }

        // Verzió 0.5 - Marci - Működő összeadás
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
            
            if (addUsed && secondState)
            {
                y = double.Parse(displayOP.Text);
                memory = MemulatorHelper.Addition(memory, y);
                chars.Clear();
                displayOP.Text = "0";
                chars.Add("0");
                displayEQ.Text = "= " + memory.ToString();
                addUsed = false;
                return;
            }
            memory = double.Parse(displayOP.Text);
            displayEQ.Text = "= " + displayOP.Text;
            chars.Clear();
            displayOP.Text = "0";
            chars.Add("0");

        }

        private void squareroot_Click(object sender, EventArgs e)
        {

        }

        private void allclear_Click(object sender, EventArgs e)
        {
            memory = 0;
            y = 0;
            displayEQ.Text = "";
            chars.Clear();
            displayOP.Text = "0";
            chars.Add("0");
            secondState = false;
            addUsed = false;
            //Amennyiben megcsináltad a többi műveletet írd a state-jét ide
        }
    }
}
