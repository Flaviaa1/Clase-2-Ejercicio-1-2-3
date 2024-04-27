using clase_2.Ejercicio_1;
using clase_2.Ejercicio_3;
using clase_2.Ejercicion_2;
using System.Runtime.Serialization;

namespace clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"


            Perro perro = new Perro() { Edad = 2, Nombre = "Buddy" };
            Gato gato = new Gato() { Edad = 5, Nombre = "Michi" };
            Console.WriteLine("Soy un perro");
            perro.EmitirSonido();
            Console.WriteLine("Soy un gato");
            gato.EmitirSonido();
          


            #endregion


            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno
            Notebook notebook = new Notebook() { Marca = "asus", Peso = 1 };
            PcEscritorio pcEscritorio = new PcEscritorio() { Marca = "Acer", Refactorizada = true };

            Console.WriteLine($"{notebook.Marca},{notebook.Peso} ");
            Console.WriteLine($"{pcEscritorio.Marca},{pcEscritorio.Refactorizada} ");

            #endregion


            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Rectangulo rectangulo= new Rectangulo() {Nombre="RECTANGULO",Altura=5,Base=10 };

          double perimetro=  rectangulo.CalcularPerimetro(rectangulo.Base,rectangulo.Altura);
          double area = rectangulo.CalcularArea(rectangulo.Altura,rectangulo.Base);

            Console.WriteLine(rectangulo.Nombre+" Perimetro;"+perimetro+" area;"+area);

            Circulo circulo = new Circulo() {   Nombre="CIRCULO",Radio=5,pi=3.14 };
            double area2 = circulo.CalcularArea(circulo.Radio, circulo.pi);
            double perimetro2=circulo.CalcularPerimetro(circulo.Radio,circulo.pi);
            Console.WriteLine(circulo.Nombre + " Perimetro;" + perimetro2 + " area;" + area2);

            #endregion

        }
    }
}
