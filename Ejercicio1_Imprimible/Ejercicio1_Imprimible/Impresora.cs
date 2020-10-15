using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Imprimible
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            Console.Clear();
            foreach (Imprimible imp in ColaDeImpresion)
            {
                imp.imprimir();
            }

            Console.WriteLine("");
            Console.WriteLine("Precione una tecla para continuar...");
            Console.ReadKey();
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
