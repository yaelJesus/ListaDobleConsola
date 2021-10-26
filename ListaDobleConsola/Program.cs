using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDoble ld = new ListaDoble();

            ld.Cargar("testListaCircular");
            Console.WriteLine(ld.ToString());
            Nodo nuevo = new Nodo(3, "Jose", 5, "pilas");
            ld.Agregar(nuevo);
            Console.WriteLine(ld.ToString());
            Console.WriteLine("¿Que nodo desea buscar?");
            if (ld.Buscar(int.Parse(Console.ReadLine()), ref nuevo))
            {
                Console.WriteLine("Si Existe \n");
                Console.WriteLine(nuevo.ToString() + "\n");
            }
            else
            {
                Console.WriteLine("No existe \n");
            }
            Console.WriteLine("¿Que nodo desea modificar?");
            int numero = int.Parse(Console.ReadLine());
            if (ld.Buscar(numero, ref nuevo))
            {
                Console.WriteLine("ingrse nombre a cambiar:");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrse equipo a cambiar:");
                int equipo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrse tema a cambiar:");
                string tema = Console.ReadLine();
                ld.Modificar(numero, nombre, equipo, tema);
                Console.WriteLine(ld.ToString());
            }
            else
            {
                Console.WriteLine("No existe \n");
            }
            Console.ReadKey();
            ld.Guardar("testListaCircular");

            Console.ReadKey();
        }
    }
}
