using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        private double CalcP()
        {
            double P = (this.A + this.B + this.C)/2;
            return P;
        }

        public double Area()
        {
            double p = CalcP();
            double area = (Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C)));
            return Math.Round(area,2);
        }
    }

    
}
