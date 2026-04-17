class EnterosYDecimales
{
    public void Ejercicio()
    {
       // Console.WriteLine("--- ejercicio ---");
        int alturaEnCentimetros; // Declaración
        alturaEnCentimetros = 170; // Asignación
        int edad = 45; // Declaración y asignación en una sola línea
        int distanciaDeLaTierraAlSol = 149_600_000; //ASignación de valores enteros con separadores
        int maximoValorDeUnEntero = int.MaxValue; // Valor Máximo que se le puede asignar a un entero (2147483647)
        int minimoValorDeUnEntero = int.MinValue; // Valor Mínimo que se le puede asignar a un entero (-2147483648)

        Console.WriteLine($"Altura: {alturaEnCentimetros} Edad: {edad}");
        Console.WriteLine($"Distancia: {distanciaDeLaTierraAlSol}");
        Console.WriteLine($"Valor Máximo: {maximoValorDeUnEntero} Valor mínimo: {minimoValorDeUnEntero} ");

        /*
        Otros tipos de datos para guardar números enteros
        */
        uint miUint = uint.MaxValue; // 0 - 4294967295
        byte miByte = byte.MaxValue; // 0 - 255
        sbyte miSbyte = sbyte.MaxValue; // -128 - 127
        short miShort = short.MaxValue; // -32768 - 32767
        ushort miUShort = ushort.MaxValue; // 0 - 65535
        long miLong = long.MaxValue; // -9223372036854775808 - 9223372036854775807
        ulong miULong = ulong.MaxValue; // 0 - 18446744073709551615
        Console.WriteLine($"Byte: {miByte} Short: {miShort} Long: {miLong}");
        Console.WriteLine($"uint: {miUint} sbyte: {miSbyte} ushort: {miUShort} ulong: {miULong}");

        /*
        Otros tipos de datos para guardar números decimales
        */

        // Se debe especificar el sufifo F, precisión de 6 a 9 dígitos Ocupa 4 bytes.
        float miFloat = 3.141592653589793f; // si se especifica una cantidad mayor se trunca y se redondea (3.1415927).
        // es el tipo por default para los decimales, no es obligatorio agregar el sufijo d
        // Ocupa 8 bytes precisión 15 a 17 dígitos
        double miDouble = 3.141592653589793d;
        // se utilza tipicamente para cantidades financieras  precisión de 28 a 29 dígitos
        //Se debe especificar el sufijo m
        decimal miDecimal = 3000000000000000000.141592653589793m;

        Console.WriteLine($"Float: {miFloat}, Double: {miDouble}, Decimal: {miDecimal}");

        Console.WriteLine("--- ejercicio ---");
    }
    
}