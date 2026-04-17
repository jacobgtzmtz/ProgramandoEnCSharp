class OperacionesUnarias
{
    public void Ejercicio()
    {
        var cantidad = 1;
        var cantidadModificada = -cantidad;
        Console.WriteLine("--- Ejercicio ---");
        Console.WriteLine($"Cantidad - 1:Cantidad modificada: {cantidadModificada}");
        cantidad++;
        Console.WriteLine($"Cantidad + 1: {cantidad}");
        cantidad--;
        Console.WriteLine($"Cantidad - 1: {cantidad}");
        ++cantidad;
        Console.WriteLine($"Cantidad + 1: {cantidad}");
        --cantidad;
        Console.WriteLine($"Cantidad - 1: {cantidad}");



        Console.WriteLine("--- Ejercicio ---");
    }
}