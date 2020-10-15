using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    class Boing747 : Avion, Ivolador
    {
        private int horasDeVuelo;

        public Boing747(String nombre) : base(nombre)
        {
            this.horasDeVuelo = 0;
        }

        public void Volar()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un Avion...");
        }

        public void MostarStats()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("BOING747: ");
            Console.WriteLine("nombre: " + this.nombre);
            Console.WriteLine("horasDeVuelo: " + this.horasDeVuelo);
        }
    }
}
