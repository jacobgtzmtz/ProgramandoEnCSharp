class ParseYTryParse
{
    public void ejercicio()
    {
        var cantidadString = "5";
        int cantidadNumero = int.Parse(cantidadString);
        cantidadNumero++;

        Console.WriteLine(cantidadNumero);

        var supuestoNumero = "cinco";
        if (int.TryParse(supuestoNumero, out cantidadNumero))
        {
            cantidadNumero++;
            Console.WriteLine(cantidadNumero);
        }
        else
        {
            Console.WriteLine("No se pudo parsear");
        }


    }
}