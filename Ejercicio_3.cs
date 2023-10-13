/*Ejercicio 3: Numero primo


Escribe un
programa que determine si un número dado es primo o no.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine(numero + " es un número primo.");
        }
        else
        {
            Console.WriteLine(numero + " no es un número primo.");
        }

        Console.ReadLine();
    }
}
