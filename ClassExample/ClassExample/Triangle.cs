using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double P;
        //Ctor      Default
        public Triangle()
        {
            this.a = 7;
            this.b = 8;
            this.c = 9;
        }
        //Ctor Not Default
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //Ctor 2 argument and 1 default argument
        public Triangle(double b, double c)
        {
            this.a = 7;
            this.b = b;
            this.c = c;
        }
        //This method calculate Paragic of Triangle
        public double Paragic()
        {
            P = a + b + c;
            return P;
        }
        //This method calculate Area of Triangle
        public double Area()
        {
            Paragic();
            double S = 1;
            return S = (P - a) * (P - b) * (P - c) * P;
        }
    }
}