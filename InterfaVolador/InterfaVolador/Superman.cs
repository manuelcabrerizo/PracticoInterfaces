using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    class Superman : SuperHeroe, Ivolador
    {
        private int experiencia;

        public Superman(String nombre, String superPoder) : base(nombre, superPoder)
        {
            this.experiencia = 0;
        }

        public void Volar()
        {
            this.experiencia += 3;
            Console.WriteLine("Estoy volanddo como un Campeon...");
        }

        public void MostarStats()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("SUPERMAN: ");
            Console.WriteLine("nombre: " + this.nombre);
            Console.WriteLine("superPoder: " + this.superPoder);
            Console.WriteLine("experiencia: " + this.experiencia);
        }
    }
}
