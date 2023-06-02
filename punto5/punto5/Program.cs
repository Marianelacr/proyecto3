using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Un colegio desea saber qué porcentaje de niños y qué porcentaje de niñas hay en el
            //curso actual. Diseñar un programa para este propósito. Recuerda que para calcular el
            //porcentaje puedes hacer una regla de 3 simple.El programa debe solicitar al usuario
            //que ingrese la cantidad total de niños, y la cantidad total de niñas que hay en el curso.
            int niños;
            int niñas;
            int totalaulumnos;
            int tniños;
            int tniñas;

            Console.WriteLine("ingrese la cantidad de niños ");
            niños = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de nilas ");
            niñas = int.Parse(Console.ReadLine());

            totalaulumnos = niños + niñas;
            tniños = (niños + 100) / totalaulumnos;
            tniñas = (niñas + 100) / totalaulumnos;

            Console.WriteLine("el porcentaje de niños en el curso es " + tniños + "%");
            Console.WriteLine("el porcentaje de niñas en el curso es " + tniñas + "%");

            Console.ReadKey();
        }
    }
}
