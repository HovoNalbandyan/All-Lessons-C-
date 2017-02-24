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
            a = 3;
            b = 3;
            c = 3;
        }
        //Ctor Not Default
        public Triangle(double b,double c,double g,double i)
        {
            this.a = 9;
            this.b = b;
            this.c = c;
        }
        public Triangle(double a)
        {
            this.a = a;
            this.b = 5;
            this.c = 5;
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