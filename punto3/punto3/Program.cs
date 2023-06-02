using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir de una conocida cantidad de días que el usuario ingresa a través del teclado,
            //escriba un programa para convertir los días en horas, en minutos y en segundos.


            int horas;
            int minutos;
            int segundos; 
            int dias;


            Console.WriteLine("ingrese la cantidad de dias: ");
            dias = int.Parse(Console.ReadLine());

            horas = dias * 24;
            minutos = dias * 1440;
            segundos = dias * 86400;
            Console.WriteLine("la cantidad de horas son: "+horas );
            Console.WriteLine("la cantidad de minutos son: " + minutos);
            Console.WriteLine("la cantidad de segundos son: " + segundos);
            Console.ReadKey();





        }
    }
}
