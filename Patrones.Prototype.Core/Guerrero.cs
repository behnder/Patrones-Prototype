using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.Core
{
    public class Guerrero : DeepCopy, ICopy
    {

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Edad { get; set; }
        public int Poder { get; set; }


        public object ClonacionProfunda()
        {
            var tempObject = this.MemberwiseClone() as Guerrero;
            tempObject.Nombre = string.Copy(this.Nombre);
            tempObject.Descripcion = string.Copy(this.Descripcion);

            return tempObject;

        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone() as Guerrero;
        }

        public override string ToString()
        {
            return $"NOMBRE : {Nombre}\nDESCRIPCIÓN: {Descripcion}\nEDAD: {Edad}\nPODER: {Poder}";
            
        }
    }
}
