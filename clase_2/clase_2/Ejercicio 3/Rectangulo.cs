using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.Ejercicio_3
{
    internal class Rectangulo:FiguraGeometrica
    {
        public int Altura { get; set; }
        public int Base { get; set; }
        public override double CalcularArea(int a,double b)
        {
            double resultado = (a*b);
            return (resultado);
        }
        public override double CalcularPerimetro(int a, double b)
        {
            double resultado2 =2* (a + b);
            return resultado2 ;
        }
    }
}
