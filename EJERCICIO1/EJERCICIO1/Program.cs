using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

            int[] numeros;
            numeros = new int[10];



            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = (i+1);
            //    Console.WriteLine(numeros[i]);
            //}

            int[] array = new int[10];
            int num = 1;
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = num;
                num++;
            }
            for (int i = 0; i < array.Length;  i++)
            {
                Console.WriteLine(array[i]);
            }










                //y = 0;
                //y = 0;
                //if (j == x)
                //{
                //    int y = x + 1;
                //    numeros[i] = y;
                //}

                //Console.WriteLine(numeros[i]);
                //x = x + 1;
                //j = j + 1;


        }
    }
}
