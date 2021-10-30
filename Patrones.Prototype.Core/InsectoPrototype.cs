using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class InsectoPrototype : EnemigoPrototype
    {
        public override EnemigoPrototype Clonar()
        {
            return (InsectoPrototype)this.MemberwiseClone();
        }
        public override string VerEnemigo()
        {
            return $"Insecto {nombre} Color {color}";
        }
    }
}
