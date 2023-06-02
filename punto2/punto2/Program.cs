using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que calcule el volumen de un cilindro. Para ello se deberá
            //solicitar al usuario que ingrese el radio y la altura. Mostrar el resultado por pantalla.
            double volumen;
            double radio;
            double altura;

            Console.WriteLine("ingrese la altura del cilindro");
            altura =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el radio del cilindro");
            radio = Convert.ToDouble(Console.ReadLine());
            volumen = 3.14 * radio*radio * altura;
            Console.WriteLine("el volumen del cilindro es: " + volumen);
            Console.ReadKey();
        }
    }
}
