namespace Memulator_Main
{
    partial class Memulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.factorial = new System.Windows.Forms.Button();
            this.squareroot = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.displayEQ = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.allclear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.displayOP = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.factorial.Location = new System.Drawing.Point(197, 276);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(50, 50);
            this.factorial.TabIndex = 53;
            this.factorial.Text = "x!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // squareroot
            // 
            this.squareroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.squareroot.Location = new System.Drawing.Point(253, 277);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(50, 50);
            this.squareroot.TabIndex = 52;
            this.squareroot.Text = "sqrt";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.squareroot_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.Location = new System.Drawing.Point(197, 333);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 50);
            this.multiply.TabIndex = 51;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // displayEQ
            // 
            this.displayEQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayEQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayEQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayEQ.Location = new System.Drawing.Point(29, 12);
            this.displayEQ.Name = "displayEQ";
            this.displayEQ.Size = new System.Drawing.Size(274, 31);
            this.displayEQ.TabIndex = 50;
            this.displayEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.del.Location = new System.Drawing.Point(253, 165);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(50, 50);
            this.del.TabIndex = 49;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // allclear
            // 
            this.allclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allclear.Location = new System.Drawing.Point(197, 165);
            this.allclear.Name = "allclear";
            this.allclear.Size = new System.Drawing.Size(50, 50);
            this.allclear.TabIndex = 48;
            this.allclear.Text = "AC";
            this.allclear.UseVisualStyleBackColor = true;
            this.allclear.Click += new System.EventHandler(this.allclear_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(197, 389);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 47;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(253, 389);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 46;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.division.Location = new System.Drawing.Point(253, 333);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(50, 50);
            this.division.TabIndex = 45;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click_1);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equals.Location = new System.Drawing.Point(141, 388);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(50, 50);
            this.equals.TabIndex = 44;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num0.Location = new System.Drawing.Point(85, 389);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(50, 50);
            this.num0.TabIndex = 43;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dot.Location = new System.Drawing.Point(29, 388);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(50, 50);
            this.dot.TabIndex = 42;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num3.Location = new System.Drawing.Point(141, 333);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(50, 50);
            this.num3.TabIndex = 41;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num2.Location = new System.Drawing.Point(85, 333);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 50);
            this.num2.TabIndex = 40;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num1.Location = new System.Drawing.Point(29, 332);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 50);
            this.num1.TabIndex = 39;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num6.Location = new System.Drawing.Point(141, 277);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(50, 50);
            this.num6.TabIndex = 38;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num5.Location = new System.Drawing.Point(85, 277);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(50, 50);
            this.num5.TabIndex = 37;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num4.Location = new System.Drawing.Point(29, 276);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(50, 50);
            this.num4.TabIndex = 36;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num9.Location = new System.Drawing.Point(141, 221);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(50, 50);
            this.num9.TabIndex = 35;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num8.Location = new System.Drawing.Point(85, 221);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(50, 50);
            this.num8.TabIndex = 34;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num7.Location = new System.Drawing.Point(29, 220);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(50, 50);
            this.num7.TabIndex = 33;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mode.Location = new System.Drawing.Point(29, 163);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(99, 51);
            this.Mode.TabIndex = 32;
            this.Mode.Text = "Mode";
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // logxy
            // 
            this.logxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logxy.Location = new System.Drawing.Point(197, 221);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(50, 50);
            this.logxy.TabIndex = 54;
            this.logxy.Text = "logxY";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.logxy_Click);
            // 
            // pow
            // 
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pow.Location = new System.Drawing.Point(253, 221);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(50, 50);
            this.pow.TabIndex = 55;
            this.pow.Text = "Pow";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // displayOP
            // 
            this.displayOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayOP.Location = new System.Drawing.Point(29, 131);
            this.displayOP.Name = "displayOP";
            this.displayOP.ReadOnly = true;
            this.displayOP.Size = new System.Drawing.Size(274, 26);
            this.displayOP.TabIndex = 56;
            this.displayOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.Location = new System.Drawing.Point(141, 165);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 59;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(29, 212);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(274, 227);
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(228, 44);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 81);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(29, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 81);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Memulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayOP);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.squareroot);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.displayEQ);
            this.Controls.Add(this.del);
            this.Controls.Add(this.allclear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.division);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Mode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Memulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button squareroot;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.TextBox displayEQ;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button allclear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button Mode;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.TextBox displayOP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

