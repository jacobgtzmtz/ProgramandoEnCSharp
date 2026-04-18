class PatronesLogicos
{
    public void ejercicio()
    {
        // Ejemplo 1: Not
        string? apellido = null;
        if(apellido is not null)
        {
            Console.WriteLine(apellido.ToUpper());
        }
        Console.WriteLine("Fin ejemplo Not");

        //Ejemplo 2: And
        int temperatura = 28;
        string mensaje = temperatura switch
        {
            < 37 => "No tienes temperatura",
            >= 37 and < 39 => "Tienes temperatura",
            _ => "Debes acudir al médico"  
        };
        Console.WriteLine(mensaje);

        //Ejemplo 3: Or

        var mes = DateTime.Now.Month;
        var estacion = mes switch
        {
            1 or 2 or 12 => "Invierno",
            3 or 4 or 5 => "Primavera",
            6 or 7 or 8 => "Verano",
            9 or 10 or 11 => "Otoño",
            _ => "Mes incorrecto"
        };
        Console.WriteLine(estacion);    
    }
}