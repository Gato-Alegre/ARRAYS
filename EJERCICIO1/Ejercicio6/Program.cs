using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mesesDelAnio = {"enero","Febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre"};

            int input = (Convert.ToInt32(Console.ReadLine()) - 1); // -1 porque las arrays empiezan del 0 numero de posicion y lo que introducimos es numero de cantidad
            Console.WriteLine($"el mes correspondiente a numero {input + 1} es {mesesDelAnio[input]}");

        }
    }
}
