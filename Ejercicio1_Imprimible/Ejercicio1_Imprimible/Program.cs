using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Imprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String opcion; 

            Contrato c = new Contrato();
            Foto f = new Foto();
            Documento d = new Documento();
            Impresora i = new Impresora();

            do
            {
                Console.Clear();

                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Agregar Contrato a la cola de impresión");
                Console.WriteLine("2. Agregar Foto a la cola de impresión");
                Console.WriteLine("3. Agregar Documento a la cola de impresión");
                Console.WriteLine("4. Imprimir todo");
                Console.WriteLine("5. Salir");
                opcion = Console.ReadLine();
                num = Convert.ToInt32(opcion);

                switch (num)
                {
                    case 1:
                        i.AgregarImprimible(c);
                        break;
                    case 2:
                        i.AgregarImprimible(f);
                        break;
                    case 3:
                        i.AgregarImprimible(d);
                        break;
                    case 4:
                        i.ImprimirTodo();
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Adios :)");
                        break;
                    default:
                        Console.WriteLine("ERROR. La opcion seleccionada no existe");
                        break;
                }
            }
            while (num != 5);

            Console.ReadKey();
        }
    }
}
