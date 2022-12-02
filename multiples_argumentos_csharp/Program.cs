using multiples_argumentos_csharp.includes;
using System;

namespace multiples_argumentos_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions func = new Functions();

            Console.WriteLine($"El resultado de la suma (2+2+8) es: {func.adicion(2,2,8)}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
