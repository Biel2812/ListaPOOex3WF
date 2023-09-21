using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ03
{
    internal class Quadrado
    {
        //atributos
        private double d;
        private double a;

        //metodos 
        public void setDiagonal(double p)
        {
            d = p;
        }

        public double getDiagonal()
        {
            return d;
        }

        public double getArea()
        {
            return a;
        }

        public void calcularArea()
        {
            a = (d * d) / 2;
        }
    }
}
