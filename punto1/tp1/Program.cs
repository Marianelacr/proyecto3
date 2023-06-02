using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            int vase;
            int altura;
            int perimetros;

            Console.WriteLine("ingrese la base del rectagulo");
            vase = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura del rectangulo");
            altura = int.Parse(Console.ReadLine());
            area = vase * altura;
             perimetros = 2 * altura + 2 * vase;
            Console.WriteLine("el area del recatangulo es: " + area);
            
            Console.WriteLine("el perimetro del rectangulo es: " + perimetros);
           

            Console.ReadKey();
              


        }
    }
}
