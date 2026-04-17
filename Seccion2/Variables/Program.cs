// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Sección 2: Variables en C# ---");

string nombreCurso = "Programando en C#";
int seccion = 2;
Console.WriteLine($"Bienvenido al curso {nombreCurso}. Actualmente estamos en la sección {seccion}.");

Console.WriteLine("--- ejercicio ---");

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

Console.WriteLine("--- ejercicio ---");
