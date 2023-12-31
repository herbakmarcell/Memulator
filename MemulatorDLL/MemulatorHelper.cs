﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemulatorDLL
{
    public class MemulatorHelper
    {
        
        //double x;
        //double y;

        //public void SetX(double x)
        //{
        //    this.x = x;
        //}

        //public void SetY(double y)
        //{
        //    this.y = y;
        //}

        public static double Addition(double x, double y)
        {
            double value = 0;
            value = x + y;
            return value;
        }

        public static double Subtract(double x, double y)
        {
            double value = 0;
            value = x - y;
            return value;
        }


        public static double Division(double x, double y)
        {
            double value = 0;
            value = x / y;
            return value;
        }

        public static double Multiply(double x, double y)
        {
            double value = 0;
            value = x * y;
            return value;
        }


        public static double Sqrt(double x)
        {
            double value = 0;
            value = Math.Sqrt(x);
            return value;
        }

        public static long Factorial(long x)
        {
            if (x == 0)
            {
                return 1;
            }

            long value = 1;
            for (int i = 1; i < x; i++) 
            { 
                value = value * (i + 1); 
            }
            return value;
        }

        public static double Power(double x, double y)
        {
            double value = 0;
            value = Math.Pow(x, y);
            return value;
        }

        public static double LogXY(double x, double y)
        {
            double value = 0;
            value = Math.Log(y,x);
            return value;
        }

        public static double PrefixChanger(double x)
        {
            double value = x;
            value *= -1;
            return value;
        }


    }
}
