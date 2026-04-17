class FechaYHora
{
    public void Ejercicio()
    {
        DateTime fechaActual = DateTime.Now;
        DateTime primerDiaDelAño = new DateTime(fechaActual.Year, 1, 1);
        DateTime Mañana = DateTime.Now.AddDays(1);
        Console.WriteLine($"Fecha Actual: {fechaActual}");
        Console.WriteLine($"Primer día del año: {primerDiaDelAño}");
        Console.WriteLine($"Mañana es: {Mañana.DayOfWeek} {Mañana}");
    
        
    }
}