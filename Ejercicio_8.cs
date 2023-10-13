/* Ejercicio 8: Secuencia de Patrones


Desarrolla un programa que genere y muestre
la siguiente secuencia de patrones:


*


**


***


****


*****

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
