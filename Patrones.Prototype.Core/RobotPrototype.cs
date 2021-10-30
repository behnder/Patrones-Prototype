using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class RobotPrototype : EnemigoPrototype
    {
        public override EnemigoPrototype Clonar()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }
        public override string VerEnemigo()
        {
            return $"Robot {nombre} color {color}";
        }
    }
}
