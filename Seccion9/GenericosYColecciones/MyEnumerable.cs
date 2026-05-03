namespace GenericosYColecciones;

public class MyEnumerable
{
    public void Ejercicio()
    {
        var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var dias = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        ImprimirEnConsola(numeros);
        ImprimirEnConsola(dias);
    }

    internal void ImprimirEnConsola<T>(IEnumerable<T> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

}
