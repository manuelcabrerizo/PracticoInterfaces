using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    abstract class Avion
    {
        protected String nombre;

        public Avion(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
