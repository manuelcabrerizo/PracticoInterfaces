using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    abstract class SuperHeroe
    {
        protected String nombre;
        protected String superPoder;

        public SuperHeroe(String nombre, String superPoder)
        {
            this.nombre = nombre;
            this.superPoder = superPoder;
        }
    }
}
