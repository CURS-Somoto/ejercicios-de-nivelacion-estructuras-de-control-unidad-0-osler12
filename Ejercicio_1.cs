/*Ejercicio 1: Impresión de Números Pares


Escribe un programa
que muestre los números pares del 2 al 20. */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números pares del 2 al 20:");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
