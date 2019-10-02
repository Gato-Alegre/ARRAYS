using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            Console.WriteLine("introduzca un número entre 0 y 9, si desea termniar la secuncia puede introduccir salir cunado quiera\n");
            int contador = 1;
            string input;
            string salir;
            bool letra = false;
            bool siPulsaSalir = false;

            do
            {
                Console.WriteLine($"Introduzca {contador}º numero");
                input = Console.ReadLine().ToLower();

                for (int i = 0; i < input.Length; i++)// bucle para saber si tine letra
                {
                    char caracterLetra = Convert.ToChar(input.Substring(i, 1));
                    if (char.IsLetter(caracterLetra))
                    {
                        letra = true;
                    }


                } // bucle para saber si tine letra

                if (letra)//si contine letra entra
                {
                    Console.WriteLine("introduce solo numeros por favor\n");
                    if (input.Contains("salir"))
                    {
                        siPulsaSalir = true;
                    }

                } //si contine letra entra y nos dice que solo numeros

                else if (!letra)//operacion si solo hay numeros
                {
                    int numero1;
                    if (int.TryParse(input.Substring(0), out numero1)) // como el input sigue en string lo que hacemos es tranformarlo en int ya que solo tine numero
                    {
                        if (numero1 < array.Length && numero1 >= 0) //si se cumple las condiciones
                        {
                            array[numero1] = array[numero1] * 2;
                            Console.WriteLine($"el numero dentro de la array es {array[numero1]} en la posicion {numero1}");
                            Console.WriteLine("");
                        }//si se cumples las condiciones
                        else if (numero1 >= array.Length || numero1 < 0)//si no se cumple si metes un numero mayor o menor
                        {
                            Console.WriteLine("Hemos dicho que es del 0 al 9 si quieres salir escribelo o continua");
                            salir = Console.ReadLine().ToLower();
                            if (salir.Contains("sal"))
                            {
                                siPulsaSalir = true;
                            }
                            else if (salir.Contains("con"))
                            {
                                siPulsaSalir = false;
                            }
                        }//si no se cumple si metes un numero mayor o menor

                        contador++; //el contador es para saber en que numero introducido vas

                    }// como el input sigue en string lo que hacemos es tranformarlo en int ya que solo tine numero
                } //operaccion si solo hay numero

                letra = false; //pongo que letra vuelve a ser false para reinicir el bool si no se buguea el programa

            } while (!siPulsaSalir); //siPulsaSalir ==false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"posicion --- valor");
                Console.WriteLine($"   {i}   ---   {array[i]}");
            }


        }
    }
}
