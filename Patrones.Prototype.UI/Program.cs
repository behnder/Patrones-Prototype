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
            Guerrero guerrero = new Guerrero();
            guerrero.Descripcion = "Guerrero";
            guerrero.Edad = 30;
            guerrero.Nombre = "Tarhh";
            guerrero.Poder = 1930;
            Console.WriteLine(guerrero.ToString());
            Console.WriteLine("===========");
            Guerrero guerreroCopia = guerrero.ClonacionProfunda() as Guerrero;
            guerreroCopia.Edad = 998;
            Console.WriteLine(guerreroCopia.ToString());
            Console.WriteLine("===========");
            Console.WriteLine(guerrero.ToString());



            Console.ReadKey();
        }
    }
}
