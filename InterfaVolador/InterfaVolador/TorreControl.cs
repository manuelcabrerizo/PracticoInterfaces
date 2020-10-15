using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    class TorreControl
    {
        private List<Ivolador> voladores = new List<Ivolador>();

        public List<Ivolador> GetVoladores()
        {
            return this.voladores;
        }

        public void VuelanTodos()
        {
            foreach(Ivolador volador in voladores)
            {
                volador.Volar();
            }
        }

        public void AgregarVolador(Ivolador volador)
        {
            voladores.Add(volador);
            Console.WriteLine("Se Agrego un Volador");
            Console.WriteLine("Ingresa una tecla para Volver");
            Console.ReadKey();
        }
    }
}
