using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.Ejercicio_3
{
    internal abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }
        public virtual double CalcularArea(int a, double b) {
            double resultado=0;
            return resultado;
        }
        public virtual double CalcularPerimetro(int a, double b)
        {
            double resultado =0;
            return resultado;
        }
    }
}
