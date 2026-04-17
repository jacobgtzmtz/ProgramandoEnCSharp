class PatronesRelacionales
{
    
    public void ejercicio()
    {
        var temperatura = 35;    
        var mensaje = temperatura switch
        {
             <= 37 => "Qué calor!",
             > 37 => "Tienes fiebre"
        };
        Console.WriteLine(mensaje);
    
    }
    
}