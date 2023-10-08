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
            this.SuspendLayout();
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(263, 340);
            this.factorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(67, 62);
            this.factorial.TabIndex = 53;
            this.factorial.Text = "!x";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // squareroot
            // 
            this.squareroot.Location = new System.Drawing.Point(337, 341);
            this.squareroot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(67, 62);
            this.squareroot.TabIndex = 52;
            this.squareroot.Text = "sqrt";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.squareroot_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(263, 410);
            this.multiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(67, 62);
            this.multiply.TabIndex = 51;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // displayEQ
            // 
            this.displayEQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayEQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayEQ.Location = new System.Drawing.Point(39, 15);
            this.displayEQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayEQ.Name = "displayEQ";
            this.displayEQ.Size = new System.Drawing.Size(365, 22);
            this.displayEQ.TabIndex = 50;
            this.displayEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(337, 203);
            this.del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(67, 62);
            this.del.TabIndex = 49;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // allclear
            // 
            this.allclear.Location = new System.Drawing.Point(263, 203);
            this.allclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allclear.Name = "allclear";
            this.allclear.Size = new System.Drawing.Size(67, 62);
            this.allclear.TabIndex = 48;
            this.allclear.Text = "AC";
            this.allclear.UseVisualStyleBackColor = true;
            this.allclear.Click += new System.EventHandler(this.allclear_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(263, 479);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(67, 62);
            this.plus.TabIndex = 47;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(337, 479);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(67, 62);
            this.minus.TabIndex = 46;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(337, 410);
            this.division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(67, 62);
            this.division.TabIndex = 45;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click_1);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(188, 478);
            this.equals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(67, 62);
            this.equals.TabIndex = 44;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(113, 479);
            this.num0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(67, 62);
            this.num0.TabIndex = 43;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(39, 478);
            this.dot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(67, 62);
            this.dot.TabIndex = 42;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(188, 410);
            this.num3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(67, 62);
            this.num3.TabIndex = 41;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(113, 410);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(67, 62);
            this.num2.TabIndex = 40;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(39, 409);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(67, 62);
            this.num1.TabIndex = 39;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(188, 341);
            this.num6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(67, 62);
            this.num6.TabIndex = 38;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(113, 341);
            this.num5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(67, 62);
            this.num5.TabIndex = 37;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(39, 340);
            this.num4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(67, 62);
            this.num4.TabIndex = 36;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(188, 272);
            this.num9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(67, 62);
            this.num9.TabIndex = 35;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(113, 272);
            this.num8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(67, 62);
            this.num8.TabIndex = 34;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(39, 271);
            this.num7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(67, 62);
            this.num7.TabIndex = 33;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Mode.Location = new System.Drawing.Point(39, 201);
            this.Mode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(132, 63);
            this.Mode.TabIndex = 32;
            this.Mode.Text = "Mode";
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // logxy
            // 
            this.logxy.Location = new System.Drawing.Point(263, 272);
            this.logxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(67, 62);
            this.logxy.TabIndex = 54;
            this.logxy.Text = "logxY";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.logxy_Click);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(337, 272);
            this.pow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(67, 62);
            this.pow.TabIndex = 55;
            this.pow.Text = "Pow";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // displayOP
            // 
            this.displayOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayOP.Location = new System.Drawing.Point(39, 169);
            this.displayOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayOP.Name = "displayOP";
            this.displayOP.ReadOnly = true;
            this.displayOP.Size = new System.Drawing.Size(365, 22);
            this.displayOP.TabIndex = 56;
            this.displayOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Memulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 567);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Memulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memulator";
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
    }
}

