using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"introduce el valor {i + 1}");

                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"En la posicion {i + 1} {array[i]}");
            }

            if (array[0] < array[1] && array[0] < array[2])
            {
                Console.WriteLine($"El numero mas pequeño es {array[0]} ");
            }
            else if (array[1] < array[0] && array[1] < array[2])
            {
                Console.WriteLine($"El numero mas pequeño es {array[1]} ");
            }
            else
            {
                Console.WriteLine($"El numero mas pequeño es {array[2]} ");
            }

            //int minValue = array[2];
            //Console.WriteLine($"El numero mas pequeño es {array[2]} ");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (true)
            //    {
            //        Console.WriteLine(array[i] + "");
            //        minValue = array[i];

            //    }
            //}







        }
    }
}

