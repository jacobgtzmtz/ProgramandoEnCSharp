using System;
using Microsoft.VisualBasic;

namespace ModuloLINQ;

public class Filtro
{
    int[] numeros = Enumerable.Range(1, 20).ToArray();
    List<Persona> personas = new List<Persona>()
    {
        new Persona { nombre = "Juan", edad = 20 },
        new Persona { nombre = "Fulano", edad = 18 },
        new Persona { nombre = "Sutano", edad = 15 },
        new Persona { nombre = "Perengano", edad = 25 },
        new Persona { nombre = "Oscar", edad = 17 },
        new Persona { nombre = "Damian", edad = 40 }
        
    };

    public void Ejercicio()
    {
        var numerosParesMayoresA10 = numeros.Where(n => n % 2 == 0 && n > 10);
        Console.WriteLine(string.Join(", ", numerosParesMayoresA10));

        var personasMayoresDeEdad = personas.Where(p => p.edad >= 18);
        foreach (var p in personasMayoresDeEdad) Console.WriteLine($"Nombre: {p.nombre}, Edad: {p.edad}");
    }


}
