using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que solicite al usuario que ingrese el precio de un producto al
            //inicio del año, y el precio del mismo producto al finalizar el año. El programa debe
            //calcular cuál fue el porcentaje de aumento que tuvo ese producto en el año y
            //mostrarlo por pantalla.

            double inaño;
            double finaño;
            double aumento;
            double porcentaje;

            Console.WriteLine("ingrse el precio del producto a principio de año");
            inaño = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el precio del producto a fin de año");
            finaño = Convert.ToDouble(Console.ReadLine());
            aumento = finaño - inaño;
            porcentaje = (aumento / inaño) * 100;
            Console.WriteLine("el porcentaje de aumento de el producto es:" + porcentaje + "%");
            Console.ReadKey();



        }
    }
}
