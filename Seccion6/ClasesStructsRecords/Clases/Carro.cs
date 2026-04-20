using System;

namespace ClasesStructsRecords.Clases;

internal class Carro
{
    internal Carro()
    {
        
    }

    internal Carro(string mark)
    {
        _mark = mark;
    }
    //Por convencióin los nombres de los campos empiezan con guión bajo, con acceso privado
    private string? _mark;

    //Para no exponer los campos de la clase podemos crear propiedades
    internal string? Mark //Esta es la manera larga de declarar las propiedades.
    { 
        get  
        { 
            return _mark; 
        } 
        set 
        { 
            _mark = value; 
        } 
    }
    /*
        Si no se van a transformar los valores de las propiedades, no es necesario que existan sus campos,
        Esta es la maner corta de declarar las propiedades,
        a esta forma se le conoce como propiedad autoimplementada.
    */
    internal int Year { get; set; } = 1990; //Esta forma es si se desea agregar un valor por defecto
    internal string? Color { get; set; }
    internal double Price { get; set; }
    internal string Cilindros { get; } = "4"; //si deseamos que la propiedad sea de solo lectura, se puede quitar la opción set
    internal bool fuelInyection => true; //Esta tmb es una propiedad de solo lectura, pero se conoce como propiedad de lectura calculada.
    internal int Velocidad { get; private set;} = 170; //Los modificadores de acceso del get y el set son individuales.
    private int VelocidadMaxima => 200;

    //Metodos
    internal void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidad + 10 < VelocidadMaxima)
        {
            Velocidad += 10;
            Console.WriteLine($"Velocidad: {Velocidad}");
        }
        else
        {
            Console.WriteLine("Velocidad máxima alcanzada");
        }
    }

    internal void Frenar()
    {
        Console.WriteLine("Frenando...");
    }


internal void ImprimirDetalles()
    {
        var detalles = $@"
        Marca: {_mark}
        Año: {Year}
        Color: {Color}
        Precio: {Price}
        Cilindros: {Cilindros}
        Velocidad: {Velocidad}
        ";
        Console.WriteLine(detalles);
    }

}
