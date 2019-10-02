using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {


            Random aleatorio = new Random();

            int[] numerosRandom = new int[20];

            int[] posicion = new int[10];

            for (int i = 0; i < numerosRandom.Length; i++)

            {

                numerosRandom[i] = aleatorio.Next(1, 10);

                posicion[numerosRandom[i]]++;

            }



            for (int i = 0; i < numerosRandom.Length; i++) 

            {

                Console.WriteLine(i + "\t" + numerosRandom[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < posicion.Length; i++)

            {

                Console.WriteLine($"El {i} aparece {posicion[i]} veces");

            }

            Console.ReadKey();


        }
    }
}
