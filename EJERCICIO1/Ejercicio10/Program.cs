using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Programa que lee las edades de 20 alumnos(validado entre 18 y 35),
            //las almacena en un array y calcula y escribe su media(para probar, 
            //se pueden generar aleatoriamente entre 18 y 35).

            int[] array = new int[20];
            Random aleatoria = new Random();
            double suma=0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = aleatoria.Next(18, 35);
                suma += array[i];  // suma = suma + array[i]
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"El alumno {i + 1} tendra {array[i]} años");
            }
            Console.WriteLine($"\nLa suma de las edades = {suma}");
            double media = suma / 20;
            Console.WriteLine($"\nLa media de todos = {media}");

            
           
        }
    }
}
