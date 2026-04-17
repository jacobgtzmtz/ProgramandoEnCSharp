class OperacionesDeAsignacion
{
    public void Ejercicio()
    {
        var cantidad1 = 10;
        var cantidad2 = 5;
        Console.WriteLine("--- Ejercicio ---");
        cantidad1 += cantidad2;
        Console.WriteLine($"Cantidad 1: {cantidad1}");
        cantidad1 -= cantidad2;
        Console.WriteLine($"Cantidad 1: {cantidad1}");
        cantidad1 *= cantidad2;
        Console.WriteLine($"Cantidad 1: {cantidad1}");
        cantidad1 /= cantidad2;
        Console.WriteLine($"Cantidad 1: {cantidad1}");
        cantidad1 %= cantidad2;
        Console.WriteLine($"Cantidad 1: {cantidad1}");
        Console.WriteLine("--- Ejercicio ---");
    }
}