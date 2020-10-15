using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    abstract class Animal
    {
        protected String nombre;

        public Animal( String nombre)
        {
            this.nombre = nombre;
        }
    }
}
