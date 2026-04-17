class Variables
{
    public void Ejercicio()
    {
        /*
            -Los nombres de las variables no pueden empezar con un número
            -pueden empezar con un _ o con un @
            -no pueden llevar "-" (Guion medio) per sí "_" (Guión bajo)
            -se recomienda seguir la convensión de camelCase
            ej.
            ejempos correctos:
            edadPersona, direccion_principal, @altura
            incorrecto:
            1Nombre, tipo-entidad
        */

        // Variables implicitamente tipadas (Deben ser inicializadas obligatoriamente).
        var edad = 45;
        var nombre = "Jacob";
        var fecha = DateTime.Now;

        // Valores por defecto
        int numero = default;
        bool isAdmin = default;
        decimal myDecimal = default;
        DateTime myFecha = default;
        string miString = default; //El valor por default de string es null
        char miChar = default;


        Console.WriteLine("--- Ejercicio ---");
        Console.WriteLine($"Edad: {edad} Nombre: {nombre} Fecha: {fecha}");
        Console.WriteLine($"Valores por defecto int: {numero}, bool: {isAdmin}, decimal: {myDecimal}, DateTime: {myFecha}");
        Console.WriteLine($"String: {miString}, char: {miChar}");
        Console.WriteLine("--- Ejercicio ---");
    }
}