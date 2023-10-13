/* Ejercicio 7: Conteo Regresivo


Imprime un conteo regresivo del 10 al 1
utilizando un bucle for.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
