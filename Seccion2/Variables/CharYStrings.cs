class charYStrings
{
    public void Ejercicio()
    {
        char letra = 'A';
        string nombre = "Jacob";
        // Cómo escapar las dobles comillas
        string saludo ="Saludo: \"hola amigos\"";
        // Si queremos imprimir la diagonal invertida
        string mensaje =" En C# usamos \\ para escapar una string";
        // String Verbatim para textos largos o con formato
        string carta = @"Hola amigo:
        Te escribo solo para saludarte.

        Saludos!!!
        Jacob Gutiérrez
        Archivo Adjunto ""C:\Mis Documentos\Mi Carpeta\Mi archivo.txt""
        ";

        // Literales de cadenas sin procesar...  se rodean con minimo 3 comillas dobles
        string miCSP = """ Hola "Jacob", el archivo es "C:\Proyecto\Archivo_Final.txt" """;
        //También se pueden utilizar las CSP para textos largos o con formatos.
        string miCartaconCSP = """
        Hola:
            Esto está formateado con sangría.

            Este es otro párrafo
                -Opción 1
                -Opción 2
        """;
        Console.WriteLine("--- Ejercicio ---");
        Console.WriteLine($"Letra: {letra}, Nombre: {nombre}");
        Console.WriteLine($"{saludo} Mensaje: {mensaje}");
        Console.WriteLine(carta);
        Console.WriteLine(miCSP);
        Console.WriteLine(miCartaconCSP);
        Console.WriteLine("--- Ejercicio ---");
    
    }
}