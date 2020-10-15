using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            String nombre = "";
            TorreControl torreDeContro = new TorreControl();


            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("Que quiere Agregar a la Cola: ");
                Console.WriteLine("1: Pato");
                Console.WriteLine("2: Boing747");
                Console.WriteLine("3: Superman");
                Console.WriteLine("4: Correr y ver Stats");
                Console.WriteLine("5: Salir");
                opcion = Convert.ToInt32(Console.ReadLine());


                if (opcion >= 1 && opcion <= 3)
                {
                    Console.WriteLine("Ingresa el Nombre");
                    nombre = Console.ReadLine();
                }

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingresa la cantidad de energia inicial");
                            int energia = Convert.ToInt32(Console.ReadLine());
                            torreDeContro.AgregarVolador(new Pato(nombre, energia));
                        }break;
                    case 2:
                        {
                            torreDeContro.AgregarVolador(new Boing747(nombre));
                        }break;
                    case 3:
                        {
                            Console.WriteLine("Ingresa Cual es su super Poder");
                            String superPoder = Console.ReadLine();
                            torreDeContro.AgregarVolador(new Superman(nombre, superPoder));
                        }break;
                    case 4:
                        {
                            Console.Clear();
                            torreDeContro.VuelanTodos();

                            foreach(Ivolador volador in torreDeContro.GetVoladores())
                            {
                                volador.MostarStats();
                            }

                            Console.WriteLine("Ingresa una tecla para Volver");
                            Console.ReadKey();
                        }
                        break;
                }
            }

        }
    }
}
