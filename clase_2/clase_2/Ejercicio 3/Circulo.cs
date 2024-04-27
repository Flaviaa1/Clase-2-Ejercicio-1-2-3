using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.Ejercicio_3
{
    internal class Circulo:FiguraGeometrica
    {
        public int Radio { get; set; }
        public double pi { get; set; }

        public override double CalcularArea(int a, double b)
        {
            double resultado1=(b*(a*a));
            return resultado1 ;
        }
        public override double CalcularPerimetro(int a, double b)
        {
            double resultado2 = (2 * b * a);
            return resultado2;
        }


    }
}
