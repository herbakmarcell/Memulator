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
using System.Threading;

namespace Memulator_Main
{
    public partial class Memulator : Form
    {
        public Memulator()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            pizzatime.Visible = false;
            taunt.Visible = false;
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
            //logxy.BackColor = DefaultBackColor;
            factorial.BackColor = DefaultBackColor;
            pow.BackColor = DefaultBackColor;
            exit.BackColor = DefaultBackColor;
            plusMinus.BackColor = DefaultBackColor;
            Mode.BackColor = Color.FromArgb(255, 0, 0);

            displayOP.Text = "0"; // Default value            
        }
        int tauntnumber = 0;
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

            if (operation == "")
            {
                if (!equalUsed)
                {
                    operation = "+";
                    memory = double.Parse(displayOP.Text);
                    displayEQ.Text = memory.ToString();
                    displayOP.Text = "0";
                }
                operation = "+";
                y = double.Parse(displayOP.Text);
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
            }
            else
            {
                operation = "+";
            }

            if (!equalUsed && operation == "+")
            {
                y = double.Parse(displayOP.Text);
            }
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

            if (operation == "")
            {
                if (!equalUsed)
                {
                    operation = "-";
                    memory = double.Parse(displayOP.Text);
                    displayEQ.Text = memory.ToString();
                    displayOP.Text = "0";
                }
                operation = "-";
                y = double.Parse(displayOP.Text);
                displayEQ.Text = memory.ToString();
                displayOP.Text = "0";
            }
            else
            {
                operation = "-";
            }

            if (!equalUsed && operation == "-")
            {
                y = double.Parse(displayOP.Text);
            }
        }

        // Verzió 0.5 - Marci - Működő összeadás
        private async void equals_Click(object sender, EventArgs e)
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
                    if (y == 0)
                    {
                        if (isModeOn)
                        {
                            pictureBox3.Visible = true;
                            pictureBox3.Refresh();
                            pictureBox3.Image = Properties.Resources.nulladiv;
                            pictureBox3.BringToFront();
                            SoundPlayer nullaoszt = new SoundPlayer(Properties.Resources.nulladiv1);
                            nullaoszt.Play();
                            displayEQ.Text = "MATH ERROR!";
                            displayOP.Text = "Press AC";
                            error = true;
                            return;
                        }
                        displayEQ.Text = "MATH ERROR!";
                        displayOP.Text = "Press AC";
                        error = true;
                        return;
                    }
                    memory = MemulatorHelper.Division(memory,y);
                    operation = "";
                    break;
                case "":
                    memory = double.Parse(displayOP.Text);
                    displayEQ.Text = memory.ToString();
                    displayOP.Text = "0";
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
                        pictureBox3.Image = Properties.Resources.fersdaben;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 4:
                        SoundPlayer sound4 = new SoundPlayer(Properties.Resources.four);
                        sound4.Play();
                        pictureBox3.Image = Properties.Resources.jhinZao;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 5:
                        SoundPlayer sound5 = new SoundPlayer(Properties.Resources.ot5);
                        sound5.Play();
                        pictureBox3.Image = Properties.Resources.numero5;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 42:
                        SoundPlayer sound42 = new SoundPlayer(Properties.Resources.prophecy);
                        sound42.Play();
                        pictureBox3.Image = Properties.Resources._42;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 69:
                        SoundPlayer sound69 = new SoundPlayer(Properties.Resources.nice);
                        sound69.Play();
                        pictureBox3.Image = Properties.Resources.nice1;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 317:
                        SoundPlayer sound317 = new SoundPlayer(Properties.Resources.smurfcat);
                        sound317.Play();
                        pictureBox3.Image = Properties.Resources.welie;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 420:
                        SoundPlayer sound420 = new SoundPlayer(Properties.Resources.weed);
                        sound420.Play();
                        pictureBox3.Image = Properties.Resources.smokeweed;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        break;
                    case 911:
                        SoundPlayer sound911 = new SoundPlayer(Properties.Resources.nineeleven);
                        pictureBox3.Image = Properties.Resources.herekopterWA;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        sound911.Play();
                        break;
                    case 1989:
                        SoundPlayer sound1989 = new SoundPlayer(Properties.Resources._89);
                        pictureBox3.Image = Properties.Resources.nothing;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
                        sound1989.Play();
                        break;
                    case 9001:
                        SoundPlayer sound9001 = new SoundPlayer(Properties.Resources.over9k);
                        sound9001.Play();
                        break;
                    case (double) 2/3:
                        SoundPlayer soundBidesz = new SoundPlayer(Properties.Resources.bidesz);
                        soundBidesz.Play();
                        pictureBox3.Image = Properties.Resources.orbiwalk;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        pictureBox3.Refresh();
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
                if (double.Parse(displayOP.Text) < 0)
                {
                    displayEQ.Text = "MATH ERROR!";
                    displayOP.Text = "Press AC";
                    error = true;
                    return;
                }
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

            equalUsed = true;
            memory = MemulatorHelper.Sqrt(double.Parse(displayOP.Text));
            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
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
            pictureBox3.Visible = false;
            pictureBox3.Refresh();

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
                if (memory == 0)
                {
                    displayEQ.Text = "MEMORY IS 0!";
                    displayOP.Text = "Press AC";
                    error = true;
                    return;
                }
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
                if (double.Parse(displayOP.Text) % 1 != 0)
                {
                    displayEQ.Text = "MATH ERROR!";
                    displayOP.Text = "Press AC";
                    error = true;
                    return;
                }
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

            if (double.Parse(displayOP.Text) % 1 != 0)
            {
                displayEQ.Text = "MATH ERROR!";
                displayOP.Text = "Press AC";
                error = true;
                return;
            }
            equalUsed = true;
            memory = MemulatorHelper.Factorial(long.Parse(displayOP.Text));
            displayEQ.Text = memory.ToString();
            displayOP.Text = "0";
            return;
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
                pizzatime.Visible = true;
                button1.Visible = true;
                taunt.Visible = false;
                pictureBox3.Visible = false;
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
                //logxy.BackColor = Color.FromArgb(153, 204, 255);
                factorial.BackColor = Color.FromArgb(153, 204, 255);
                pow.BackColor = Color.FromArgb(153, 204, 255);
                exit.BackColor = Color.FromArgb(153, 204, 255);
                plusMinus.BackColor = Color.FromArgb(220, 80, 90);
                button1.BackColor = Color.FromArgb(255, 153, 255);
                pizzatime.BackColor = Color.FromArgb(150, 250, 50);
                displayEQ.BackColor = Color.FromArgb(204, 255, 255);
                displayOP.BackColor = Color.FromArgb(204, 255, 255);
                Mode.BackColor = Color.FromArgb(51, 255, 51);
            }
            else
            {
                pizzatime.Visible = false;
                taunt.Visible = false;
                button1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox3.Refresh();
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
                //logxy.BackColor = DefaultBackColor;
                factorial.BackColor = DefaultBackColor;
                pow.BackColor = DefaultBackColor;
                displayEQ.BackColor = DefaultBackColor;
                displayOP.BackColor = DefaultBackColor;
                exit.BackColor = DefaultBackColor;
                plusMinus.BackColor = DefaultBackColor;
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
                pictureBox3.Image = Properties.Resources.rickroll1;
                pictureBox3.Visible = true;
                pictureBox3.Refresh();
            }
            else
            {
                DialogResult msg = MessageBox.Show("Bezárja a programot?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.Yes))
                {
                    Application.Exit();
                }
            }

        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (error)
            {
                return;
            }
            if (displayOP.Text.Contains(","))
            {
                return;
            }
            displayOP.Text += ",";
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(displayOP.Text);
            displayOP.Text = (-1 * temp).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer fagyi = new SoundPlayer(Properties.Resources.bingchilling1);
            pictureBox3.Image = Properties.Resources.bingchilling;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Visible = true;
            pictureBox3.Refresh();
            fagyi.Play();
        }

        private void taunt_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            tauntnumber = rnd.Next(1,10);
            taunt.Visible = true;
            SoundPlayer tauntSound = new SoundPlayer(Properties.Resources.taunt);
            switch (tauntnumber)
            {
                case 1:
                    
                    pictureBox4.Image = Properties.Resources.taunt1;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;

                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.taunt2;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.taunt3;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 4:
                    pictureBox4.Image = Properties.Resources.taunt4;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources.taunt5;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    pictureBox4.Image = Properties.Resources.taunt6;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 7:
                    pictureBox4.Image = Properties.Resources.taunt7;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 8:
                    pictureBox4.Image = Properties.Resources.taunt8;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
                case 9:
                    pictureBox4.Image = Properties.Resources.taunt9;
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox4.Refresh();
                    tauntSound.Play();
                    Thread.Sleep(300);
                    pictureBox4.Visible = false;
                    break;
            }
        }

        private void pizzatime_Click(object sender, EventArgs e)
        {
            SoundPlayer pizzaTime = new SoundPlayer(Properties.Resources.pizzatime);
            pizzaTime.Play();
            if (!taunt.Visible)
            {
                DialogResult msg = MessageBox.Show("START PIZZA TIME?", "PIZZA TIME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.Yes))
                {
                    taunt.Visible = true;
                    pizzaTime.Stop();
                    
                }
                    else
                {
                    pizzaTime.Stop();
                }
            }
            else
            {
                DialogResult msg = MessageBox.Show("END PIZZA TIME?", "PIZZA TIME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg.Equals(DialogResult.Yes))
                {
                    taunt.Visible = false;
                    pizzaTime.Stop();
                }
                else
                { 
                    pizzaTime.Stop();
                }
            }

        }
    }
}
