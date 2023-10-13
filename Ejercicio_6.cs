/* Ejercicio 6: Pare e Impar


Escribe un programa que diga si un número
es par o impar.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }

        Console.ReadLine();
    }
}
