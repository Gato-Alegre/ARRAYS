using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int veinte = 20;
            //int[] vs = new int[10];
            //int numero = 20 - 11;
            //Console.WriteLine("");

            //for (int i = 0; i <= numero; i++) //le pongo<= porque asi 
            //{
            //    vs[i] = veinte;
            //    Console.WriteLine(vs[i]);
            //    veinte--;
            //}

            Console.WriteLine("selecione desde que numero quiere empezar");

            int veinte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("selecione hasta que numero quiere llegar en la cunta regresiva");
            int[] vs = new int[veinte];
            int numero = vs.Length - Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i <= numero; i++)
            {

                vs[i] = veinte;
                Console.WriteLine(vs[i]);
                veinte--;
            }
        }
    }
}
