/*Ejercicio 5: Positivo o negativo


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else
        {
            Console.WriteLine("El número es cero");
        }

        Console.ReadLine();
    }
}
