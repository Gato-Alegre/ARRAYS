using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hasta que numeros vas a introduccir: ");
            int cantidaNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"introduce numeros del 0 al {cantidaNumero}\n");
            int[] array = new int[cantidaNumero + 1];
            int input;            
            int contador = 1;
            do
            {              
                Console.WriteLine($"Introduzca {contador}º numero");              
                                
                input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0 && input < array.Length)
                {
                    array[input] ++;
                }
                else if (input > array.Length-1)
                {
                    Console.WriteLine($"Es del 0 al {cantidaNumero}, no te pases\n");
                }

                contador++;

            } while (input > 0);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} se repiten {array[i]} veces");
            }
        }
    }
}
