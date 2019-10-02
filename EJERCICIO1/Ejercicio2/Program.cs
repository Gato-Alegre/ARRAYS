using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"introduce el valor {i+1}");
                //string input = Console.ReadLine();
                //array[i] = input;
                array[i] = Console.ReadLine();
            }

            Console.WriteLine($"En la posicion 1 {array[0]}");
            Console.WriteLine($"En la posicion 2 {array[1]}");
            Console.WriteLine($"En la posicion 3 {array[2]}");



            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

        }
    }
}
