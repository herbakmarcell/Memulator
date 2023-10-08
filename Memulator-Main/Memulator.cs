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
using System.Media;

namespace Memulator_Main
{
    public partial class Memulator : Form
    {
        public Memulator()
        {
            InitializeComponent();
            num0.BackColor = DefaultBackColor;
            num1.BackColor = DefaultBackColor;
            num2.BackColor = DefaultBackColor;
            num3.BackColor = DefaultBackColor;
            num4.BackColor = DefaultBackColor;
            num5.BackColor = DefaultBackColor;
            num6.BackColor = DefaultBackColor;
            num7.BackColor = DefaultBackColor;
            num8.BackColor = DefaultBackColor;
            num9.BackColor = DefaultBackColor;
            dot.BackColor = DefaultBackColor;
            equals.BackColor = DefaultBackColor;
            division.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            plus.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            allclear.BackColor = DefaultBackColor;
            del.BackColor = DefaultBackColor;
            squareroot.BackColor = DefaultBackColor;
            logxy.BackColor = DefaultBackColor;
            factorial.BackColor = DefaultBackColor;
            pow.BackColor = DefaultBackColor;
            exit.BackColor = DefaultBackColor;
            Mode.BackColor = Color.FromArgb(255, 0, 0);

            displayOP.Text = "0"; // Default value            
        }

        double memory = 0; // First argument and requirement for saving the 
        double y = 0; // Second argument (if needed)
        string operation = "";
        bool equalUsed = false;
        bool error = false;
        bool isModeOn = false;

        // Saved for backtrack purposes
        //bool secondState = false; // Used by operators with 2 arguments
        //bool addUsed = false; // If an addition was invoked
        //bool subUsed = false; // If a subtraction was invoked
        //bool mulUsed = false; // If a multiplication was invoked

        private void num0_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
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
            if (error)
            {
                return;
            }
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
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "2";
                return;
            }
            displayOP.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "3";
                return;
            }
            displayOP.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "4";
                return;
            }
            displayOP.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "5";
                return;
            }
            displayOP.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "6";
                return;
            }
            displayOP.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "7";
                return;
            }
            displayOP.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "8";
                return;
            }
            displayOP.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text == "0")
            {
                displayOP.Text = "9";
                return;
            }
            displayOP.Text += "9";
        }

        // Verzió 0.6 - Marci - Újragondolva (Aludtam rá 8+2 órát)
        private void plus_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
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
            if (error)
            {
                return;
            }
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
            if (error)
            {
                return;
            }
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
                case "sqrt":
                    memory = MemulatorHelper.Sqrt(memory);
                    operation = "";
                    break;
                case "!":
                    memory = MemulatorHelper.Factorial((long)(memory));
                    operation = "";
                    break;
                case "log":
                    memory = MemulatorHelper.LogXY((long)(memory),y);
                    operation = "";
                    break;
                case "pow":
                    memory = MemulatorHelper.Power((long)(memory), y);
                    operation = "";
                    break;
                case "/":
                    if (y==0)
                    {
                        displayEQ.Text = "MATH ERROR!";
                        displayOP.Text = "Press AC";
                        error = true;
                        return;
                    }
                    memory = MemulatorHelper.Division(memory,y);
                    operation = "";
                    break;
                default:
                    break;
            }
            if (isModeOn)
            {
                switch (memory)
                {
                    case 1:
                        SoundPlayer sound1 = new SoundPlayer(Properties.Resources.maxver);
                        sound1.Play();
                        break;
                    case 4:
                        SoundPlayer sound4 = new SoundPlayer(Properties.Resources.four);
                        sound4.Play();
                        break;
                    case 5:
                        SoundPlayer sound5 = new SoundPlayer(Properties.Resources.ot5);
                        sound5.Play();
                        break;
                    case 42:
                        SoundPlayer sound42 = new SoundPlayer(Properties.Resources.prophecy);
                        sound42.Play();
                        break;
                    case 69:
                        SoundPlayer sound69 = new SoundPlayer(Properties.Resources.nice);
                        sound69.Play();
                        break;
                    case 317:
                        SoundPlayer sound317 = new SoundPlayer(Properties.Resources.smurfcat);
                        sound317.Play();
                        break;
                    case 420:
                        SoundPlayer sound420 = new SoundPlayer(Properties.Resources.weed);
                        sound420.Play();
                        break;
                    case 911:
                        SoundPlayer sound911 = new SoundPlayer(Properties.Resources.nineeleven);
                        sound911.Play();
                        break;
                    case 9001:
                        SoundPlayer sound9001 = new SoundPlayer(Properties.Resources.over9k);
                        sound9001.Play();
                        break;
                    default:
                        break;
                }
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

        // Levi: Faktoriális számolásnál, ha egy eredményt(=) szeretnél faktorializálni,  megnyomod a !, utána megint =. 

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (operation == "sqrt")
            {
                memory = MemulatorHelper.Sqrt(double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "sqrt";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = memory.ToString();
        }

        private void allclear_Click(object sender, EventArgs e)
        {
            error = false;
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
            if (error)
            {
                return;
            }
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

        private void division_Click_1(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (operation == "/")
            {
                if (double.Parse(displayOP.Text) == 0 && isModeOn == true)
                {

                }

                if (double.Parse(displayOP.Text)==0)
                {
                    
                    displayEQ.Text = "MATH ERROR!";
                    displayOP.Text = "Press AC";

                    error = true;
                    return;

                }
                
                memory = MemulatorHelper.Division(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "/";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text=="" || displayOP.Text=="0")
            {
                return;
            }
            displayOP.Text = displayOP.Text.Substring(0, displayOP.Text.Length - 1);
            if (displayOP.Text=="")
            {
                displayOP.Text = "0";
            }
        }


        // Levi: Faktoriális számolásnál, ha egy eredményt(=) szeretnél faktorializálni, megnyomod a sqrt, utána megint =. 
        private void factorial_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (operation == "!")
            {
                memory = MemulatorHelper.Factorial(long.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "!";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = memory.ToString();
        }

        private void logxy_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (operation == "log")
            {
                memory = MemulatorHelper.LogXY(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "log";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
        }

        private void pow_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (operation == "pow")
            {
                memory = MemulatorHelper.Power(memory, double.Parse(displayOP.Text));
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
                return;
            }

            operation = "pow";

            if (!equalUsed)
            {
                memory = double.Parse(displayOP.Text);
            }

            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
        }
        private void checkMainMode()
        {
            if (!isModeOn)
            {
                isModeOn = true;
                pictureBox1.Image = Properties.Resources.frogkicsi;
                pictureBox1.BringToFront();
                pictureBox2.Image = Properties.Resources.frogkicsiright;
                pictureBox2.BringToFront();
                Memulator.ActiveForm.BackgroundImage = Properties.Resources.hatter;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.csiribu);
                sound.Play();
                plus.BackColor = Color.FromArgb(153, 255, 153);
                minus.BackColor = Color.FromArgb(153, 255, 153);
                multiply.BackColor = Color.FromArgb(153, 255, 153);
                division.BackColor = Color.FromArgb(153, 255, 153);
                num6.BackColor = Color.FromArgb(255, 153, 204);
                num9.BackColor = Color.FromArgb(255, 153, 204);
                num0.BackColor = Color.FromArgb(153, 204, 255);
                num1.BackColor = Color.FromArgb(153, 204, 255);
                num2.BackColor = Color.FromArgb(153, 204, 255);
                num3.BackColor = Color.FromArgb(153, 204, 255);
                num4.BackColor = Color.FromArgb(153, 204, 255);
                num5.BackColor = Color.FromArgb(153, 204, 255);
                num7.BackColor = Color.FromArgb(153, 204, 255);
                num8.BackColor = Color.FromArgb(153, 204, 255);
                dot.BackColor = Color.FromArgb(153, 204, 255);
                equals.BackColor = Color.FromArgb(153, 204, 255);
                allclear.BackColor = Color.FromArgb(153, 204, 255);
                del.BackColor = Color.FromArgb(153, 204, 255);
                squareroot.BackColor = Color.FromArgb(153, 204, 255);
                logxy.BackColor = Color.FromArgb(153, 204, 255);
                factorial.BackColor = Color.FromArgb(153, 204, 255);
                pow.BackColor = Color.FromArgb(153, 204, 255);
                exit.BackColor = Color.FromArgb(153, 204, 255);
                displayEQ.BackColor = Color.FromArgb(204, 255, 255);
                displayOP.BackColor = Color.FromArgb(204, 255, 255);
                Mode.BackColor = Color.FromArgb(51, 255, 51);
            }
            else
            {
                isModeOn = false;
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                Memulator.ActiveForm.BackgroundImage = null;
                SoundPlayer sound2 = new SoundPlayer(Properties.Resources.normalmode);
                sound2.Play();
                num0.BackColor = DefaultBackColor;
                num1.BackColor = DefaultBackColor;
                num2.BackColor = DefaultBackColor;
                num3.BackColor = DefaultBackColor;
                num4.BackColor = DefaultBackColor;
                num5.BackColor = DefaultBackColor;
                num6.BackColor = DefaultBackColor;
                num7.BackColor = DefaultBackColor;
                num8.BackColor = DefaultBackColor;
                num9.BackColor = DefaultBackColor;
                dot.BackColor = DefaultBackColor;
                equals.BackColor = DefaultBackColor;
                division.BackColor = DefaultBackColor;
                multiply.BackColor = DefaultBackColor;
                plus.BackColor = DefaultBackColor;
                minus.BackColor = DefaultBackColor;
                allclear.BackColor = DefaultBackColor;
                del.BackColor = DefaultBackColor;
                squareroot.BackColor = DefaultBackColor;
                logxy.BackColor = DefaultBackColor;
                factorial.BackColor = DefaultBackColor;
                pow.BackColor = DefaultBackColor;
                displayEQ.BackColor = DefaultBackColor;
                displayOP.BackColor = DefaultBackColor;
                exit.BackColor = DefaultBackColor;
                Mode.BackColor = Color.FromArgb(255, 0, 0);
            }
        }
        
        private void Mode_Click(object sender, EventArgs e)
        {
            checkMainMode();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (isModeOn)
            {
                SoundPlayer sound3 = new SoundPlayer(Properties.Resources.rickroll);
                sound3.Play();
            }
            else
            {
                Application.Exit();
            }
           
            
        }
    }
}
