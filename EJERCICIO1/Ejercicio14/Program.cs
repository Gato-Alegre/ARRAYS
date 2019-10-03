using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular la media de la clase
            //Escribir los alumnos cuya nota es mayor que la media.
            //Calcular la nota máxima y quienes la han conseguido
            //Calcular la nota mínima y quienes la han conseguido l

            Console.WriteLine("cuantos alumnos hay: ");
            int numeroAlumnos = Convert.ToInt32(Console.ReadLine());

            string[] nombre = new string[numeroAlumnos];
            double[] notas = new double[numeroAlumnos];
            double suma = 0;
            double[] min = new double[1];
            double[] max = new double[1];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"intruce el nombre del {i + 1}º de {numeroAlumnos}");
                nombre[i] = Console.ReadLine();

                Console.WriteLine($"intruce la nota de {nombre[i]}:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[1];
            }

            double notaMedia = suma / numeroAlumnos;

            for (int i = 0; i < notas.Length; i++)//bucle para los que tinen una nota mayor a la media
            {
                if (notas[i] > notaMedia)
                {
                    Console.WriteLine($"{nombre[i]} tine una nota de {notas[i]}");
                }
            }//bucle para los que tinen una nota mayor a la media

            for (int i = 0; i < notas.Length; i++)//bucle para calcular el minio
            {
                for (int j = 0; notas[i] < notas[j]; j++)
                {
                    min[0] = notas[i];
                }
            }//bucle para calcular el minio

            Console.WriteLine($"La nota mas baja es {min}");

            for (int i = 0; i < notas.Length; i++)//bucle para calcular el max
            {
                for (int j = 0; notas[i] > notas[j]; i++)
                {
                    min[0] = notas[i];
                }
            }//bucle para calcular el max

            Console.WriteLine($"La nota mas baja es {max}");

        }
    }
}
