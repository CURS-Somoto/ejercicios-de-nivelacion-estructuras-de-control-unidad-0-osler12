/*
Ejercicio 9: Mayor de Dos Números


Dado dos números, muestra el número mayor
utilizando una estructura if

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El número mayor es: " + numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El número mayor es: " + numero2);
        }
        else
        {
            Console.WriteLine("Ambos números son iguales");
        }

        Console.ReadLine();
    }
}
