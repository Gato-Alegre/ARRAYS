using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int[] array = new int[10];
            string[] posicion = { "primero", "segundo", "tercero", "cuarto", "quinto", "sexto", "septimo", "octavo", "noveno", "decimo" };
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = aleatorio.Next(1, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"En la posicion {i + 1}º - {posicion[i]}: {array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                int numero = array[i];
                suma += numero;
            }

            double numero1 = Convert.ToDouble(suma); //lo convierto a double ya que si divido un numero int y aunque el resultado sea decimal me aparecera exacto.

            double media = numero1 / 10; //cuando suma sale del for sal con el valor con el que ha finalizado el for
            Console.WriteLine(media);



        }
    }
}
