/* Genericos genericos = new Genericos();
genericos.Ejercicio(); */


int[] numeros = []; // = { 1, 2, 3, 4, 5, 6 ,7, 8, 9 };
string[] vocales = { "a", "e", "i", "o", "u" };
DateTime[] fechas = { DateTime.Now, DateTime.Now.AddDays(1) };

var utilidades = new UtilidadesArreglos<string>();
utilidades.GetLongitud(vocales);

