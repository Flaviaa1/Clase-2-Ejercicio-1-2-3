using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.Ejercicio_1
{
    internal class Animal
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void EmitirSonido() { Console.WriteLine("Sonido generico de animal"); }

    }
}
