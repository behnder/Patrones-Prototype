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

            EnemigoPrototype prototipoInsecto = new InsectoPrototype();
            EnemigoPrototype prototipoRobot = new RobotPrototype();
       

            EnemigoPrototype insecto1 = prototipoInsecto.Clonar();
            insecto1.Nombre = "Mantis";
            insecto1.Color = "Azul";
            Console.WriteLine(insecto1.VerEnemigo());

            EnemigoPrototype insecto2 = prototipoInsecto.Clonar();
            insecto2.Nombre = "Escarabajo";
            insecto2.Color = "Violeta";
            Console.WriteLine(insecto2.VerEnemigo());

            EnemigoPrototype robot1 = prototipoRobot.Clonar();
            robot1.Nombre = "Robot miniatura";
            robot1.Color = "Oro";
            Console.WriteLine(robot1.VerEnemigo());

            EnemigoPrototype robot2 = prototipoRobot.Clonar();
            robot2.Nombre = "Robot humano";
            robot2.Color = "Plateado";
            Console.WriteLine(robot2.VerEnemigo());

            Console.ReadKey();
        }
    }
}
