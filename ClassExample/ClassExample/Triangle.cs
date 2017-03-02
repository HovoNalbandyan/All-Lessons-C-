using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public sealed class Triangle
    {
        private double a;
        public double b;
        private double c;
        private double P=0;
      
       
        //Ctor      Default
        public  Triangle()
        {
            a = 3;
            b = 3;
            c = 3;
        }
        //Ctor Not Default
        public Triangle(double b,double c)
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
        public Triangle(double a,double b,double c)
        {
            this.a = a;
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