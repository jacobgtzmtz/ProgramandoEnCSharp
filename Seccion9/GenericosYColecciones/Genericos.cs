using System;
using System.Collections.Generic;

class Genericos
{
    public void Ejercicio()
    {
        int[] numeros = []; // = { 1, 2, 3, 4, 5, 6 ,7, 8, 9 };
        string[] vocales = { "a", "e", "i", "o", "u" };
        DateTime[] fechas = { DateTime.Now, DateTime.Now.AddDays(1) };

        int getLongitud<T>(T[] arreglo){
            return arreglo.Length;
        }

        Console.WriteLine(getLongitud(numeros));
        Console.WriteLine(getLongitud(vocales));
        Console.WriteLine(getLongitud(fechas));

        T? PrimerElemento<T>(T[] arreglo){
            if (arreglo.Length == 0)
            {
                return default;
            }
            return arreglo[0];
        }

        Console.WriteLine(PrimerElemento(numeros));
        Console.WriteLine(PrimerElemento(vocales));
        Console.WriteLine(PrimerElemento(fechas));
    }
}