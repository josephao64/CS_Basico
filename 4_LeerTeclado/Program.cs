﻿namespace programa4
{
    /// <summary>
    /// Leer datos desde teclado
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos numeros");
            Console.Write("Ingresa el numero 1: ");
            //Los datos se leen como cadena
            string dato = Console.ReadLine();
            // Convertir a numero con int.Parse
            int n1 = int.Parse(dato);

            Console.Write("Ingresa el numero 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);
        }
    }
}