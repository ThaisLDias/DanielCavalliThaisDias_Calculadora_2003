using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculador{



        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b; 
        }

        public double Dividir(double a, double b)
        {
            return a / b; 
        }

        public double Resto(double a, double b)
        {
            return a % b; 
        }
        public double Coseno(double a)
        {
            return Math.Cos(a * (Math.PI / 180.0));
        }
        public double Seno(double a)
        {
            return Math.Sin(a * (Math.PI / 180.0));
        }
        public double Tange(double a)
        {
            return Math.Tan(a * (Math.PI / 180.0));
        }
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Raiz(double a)
        {
            return Math.Sqrt(a);
        }
        public double Porcentagem(double a, double b)
        {
            return a * (b/100);
        }
      

 

    }
}

