using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public abstract class EnemigoPrototype 
    {

        protected string color;
        protected string nombre;
        public string Color { set => color = value; }
        public string Nombre { set => nombre = value; }
        public abstract EnemigoPrototype Clonar();

        public abstract string VerEnemigo();


    }
}
