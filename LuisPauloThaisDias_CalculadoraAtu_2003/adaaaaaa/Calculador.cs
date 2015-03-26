using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculador
    {



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
            return a * (b / 100);
        }

        public double FatorialRecursiva(double num)
        {
            double result;

            if (num == 0)
            {
                return 1;
            }
                result = num * FatorialRecursiva(num - 1);
                return result;
        }

        public double FatorialIterativa(double n)
        {
            double num = 1; 
            
            for (int i = 0; i < n; i++)
            {
                num = num * (i+1);  
            }

            return num; 
        }

        public double FiboRecursiva(double num)
        {
                if (num <= 1) 
                {
                    return 1; 
                }

                return FiboRecursiva(num - 2) + FiboRecursiva(num - 1); 
        }

        public double FiboIterativa(double n)
        {
            double num = 1;

            for (int i = 0; i < n; i++)
            {
                num = num + (i + 1);
            }

            return num; 
            
        }
    }
    } 

