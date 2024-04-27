using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.Ejercicion_2
{
    internal  abstract class Maquinas {
        public string Marca { get; set; }
        public void Encender() { Console.WriteLine("Se encendio la maquina!"); }
        public void Apagar() { Console.WriteLine("Se apago la maquina!"); }
    }

}
