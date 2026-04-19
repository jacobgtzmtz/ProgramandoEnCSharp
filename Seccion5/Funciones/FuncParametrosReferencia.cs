class FuncParametrosReferencia
{
    public void ejercicio()
    {
        int cantidadValor = 2;
        int cantidadReferencia = 2;

        Console.WriteLine($"Antes");
        Console.WriteLine($"Valor: {cantidadValor}");
        Console.WriteLine($"Referencia: {cantidadReferencia}");

        modificarValor(cantidadValor);
        modificarReferencia(ref cantidadReferencia);

        Console.WriteLine($"Después");
        Console.WriteLine($"Valor: {cantidadValor}");
        Console.WriteLine($"Referencia: {cantidadReferencia}");
    }

    internal void modificarValor(int valor)
    {
        valor *= 2;
    }

    internal void modificarReferencia(ref int valor)
    {
        valor *= 2;
    }
}