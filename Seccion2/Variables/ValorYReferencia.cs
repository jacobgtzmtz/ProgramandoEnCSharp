class ValorYReferencia
{
    public void Ejercicio()
    {
        /*
            Los tipos de valor guardan su contenido en el stack (Valor de la variable).
            Los tipos de referencia guardan un lugar en el heap (Se guarda la referencia).
            
            Si una variable es null
                -Es un tipo de referencia.
                -No contiene una referencia a algún valor en el heap.

            string es un tipo de referencia.
            tipos de valor: int, decimal, float, double, bool y DateTime
        */

        // Con el ? podemos hacer una variable nullable
        int? poder = null;
        Console.WriteLine("--- Ejercicio ---");
        Console.WriteLine($"Poder: {poder}");
        Console.WriteLine("--- Ejercicio ---");
    }
}