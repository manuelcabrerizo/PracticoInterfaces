using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    class Pato : Animal, Ivolador
    {
        private int energia;

        public Pato(String nombre, int energia) : base(nombre)
        {
            this.energia = energia;
        }

        public void Volar()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un Pato... Cuak!");
        }

        public void MostarStats()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("PATO: ");
            Console.WriteLine("nombre: " + this.nombre);
            Console.WriteLine("energia: " + this.energia);
        }
    }
}
