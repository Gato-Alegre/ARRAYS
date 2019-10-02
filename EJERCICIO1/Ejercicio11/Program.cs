using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.Cargar una tabla de 20 componentes enteros y calcular la suma
            //de los componentes de posición par y el producto de los componentes 
            //de posición impar.Los valores se generarán aleatoriamente entre 1 y 100.

            int[] array = new int[20];
            Random aleatorio = new Random();
            double sumaPar = 0;
            double productoImparDouble= 1; //este no lo iniciamos a cero porque es multilicacion y odo nuemro multiplicado por 0 es cero asi q...
            decimal productoImparDecimal= 1; //este no lo iniciamos a cero porque es multilicacion y odo nuemro multiplicado por 0 es cero asi q...

            for (int i = 0; i < array.Length; i++)//aqui vamos a introducir los numeros aleatorios del 1 - 100. 
            {
                array[i] = aleatorio.Next(1, 100);
            }//aqui vamos a introducir los numeros aleatorios del 1 - 100. 

            //ahora vamos a empezar con lo que nos pide el programa que mostremos
            //TABLA PAR
            Console.WriteLine("tabla de las posiciones pares\n");
            Console.WriteLine($"Poicion ---- Valor");
            for (int i = 0; i < array.Length; i++)//bucle para mostrar la tabla de los pares
            {
                int numero=i;
                
                if (numero % 2 == 0)
                {
                    sumaPar += array[i];                    
                    Console.WriteLine($"  {i}     ----  {array[i]} ");                    
                }
            }//bucle para mostrar la tabla de los pares
            Console.WriteLine($"\nLa suma total sera {sumaPar}");
            //TABLA IMPAR
            Console.WriteLine("tabla de las posiciones impares\n");
            Console.WriteLine($"Poicion ---- Valor");
            for (int i = 0; i < array.Length; i++)//bucle para mostrar la tabla de los impares
            {
                int numero = i;           
                
                if (numero % 2 != 0)
                {
                    productoImparDouble *= array[i];
                    productoImparDecimal *= array[i];
                    Console.WriteLine($"  {i}     ----  {array[i]} ");
                }

            }//bucle para mostrar la tabla de los impares
            Console.WriteLine($"\nEl producto total sera (double) {productoImparDouble}");
            Console.WriteLine($"\nEl producto total sera (decimal){productoImparDecimal}");






        }
    }
}
