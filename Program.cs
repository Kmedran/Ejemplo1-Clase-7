using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clase_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones;

            calificaciones = new int[] { 85, 92, 77, 68, 94, 65, 78, 23, 96, 45};

            Console.WriteLine(calificaciones[2]);

            float promedi = 0;
            foreach (int numero in calificaciones)
            {
                Console.WriteLine(numero);
                promedi += numero;

            }
            Console.WriteLine($"El promedio es de: {promedi/ calificaciones.Length}");

            EjemploExists();
        }

        static void formula()
        {
            int[] calificaciones;

            calificaciones = new int[] { 85, 92, 77, 68, 94, 65, 78, 23, 96, 45 };

            for (int i = 0; i < calificaciones.Length; i++)
            {

                Console.WriteLine($"Calificación {i + 1}: {calificaciones[i]}");
            }



        }

        static void despliege(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }
        }
        static void Ejemplo10()
        {
            int[] elementos = new int[] { 50, 20, 80, 90, 60};
            Console.WriteLine("Original");
            foreach(int item in elementos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordenado");
            Array.Sort(elementos);
            foreach (int item in elementos)
                despliege(elementos);
            Array.Reverse(elementos);
            foreach (int item in elementos)
                despliege(elementos);
            //Buscar el numero 90 y 60
            int indice = Array.IndexOf(elementos, 90, 60);
            Console.WriteLine($"Los numeros encontrados son:{indice}");
        }

        static void EjemploExists()
        {
            int[] calificaciones = { 85, 92, 77, 68, 94 };
            bool hayAprobados = Array.Exists(calificaciones, calif => calif >= 60);
            Console.WriteLine($"Los aprobados son: {hayAprobados}");
            
        }
        
    }
}
