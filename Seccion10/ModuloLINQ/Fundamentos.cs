using System;

namespace ModuloLINQ;

public class Fundamentos
{

    int[] numeros = Enumerable.Range(1, 5).ToArray();

    public void Ejercicio()
    {
        //Esto es LINQ (Sintaxis de métodos)
        var numerosPares = numeros.Where(n => n % 2 == 0); //Se crea la estructura pero no se dispara hasta que se itera.

        //Esto es LINQ (Sintaxis de Queries)
        var numerosNones = (from n in numeros where n % 2 != 0 select n).ToList(); //Se ejecuta directamente (con el ToList()).

        Console.WriteLine(string.Join(", ", numerosPares));
        foreach (var n in numerosNones) Console.WriteLine(n);
    }

}
