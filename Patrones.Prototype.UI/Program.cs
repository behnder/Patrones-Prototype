using Patrones.Prototype.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrero insecto = new Guerrero();
            insecto.Descripcion = "Guerrero";
            insecto.Edad = 30;
            insecto.Nombre = "Tarhh";
            insecto.Poder = 1930;
            Console.WriteLine(insecto.ToString());
            Console.WriteLine("===========");
            Guerrero insectocopia = insecto.ClonacionProfunda() as Guerrero;
            insectocopia.Edad = 998;
            Console.WriteLine(insectocopia.ToString());
            Console.WriteLine("===========");
            Console.WriteLine(insecto.ToString());



            Console.ReadKey();
        }
    }
}
