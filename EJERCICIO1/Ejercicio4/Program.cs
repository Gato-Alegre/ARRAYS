using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"introduce el valor {i + 1}");
                //string input = Console.ReadLine();
                //array[i] = input;
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {                
                Console.WriteLine($"En la posicion {i+1} {array[i]}");                
            }
        }
    }
}
