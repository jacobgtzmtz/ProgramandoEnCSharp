class FuncionesSimples
{
    //Para los nombres de las funciones se utiliza la misma convención que al nombrar las variables, pero se usa PascalCase
    //Ejemplo 1: Función simple
    public string ObtenerNombre()
    {
        return "Jacob";
    }

    //Ejemplo 2: Función sin valor de retorno
    public void MostrarNombre()
    {
        Console.WriteLine("Jacob");
    }

    //Ejemplo 3: Función con parámetros
    public int Duplicar(int numero)
    {
        return numero * 2;
    }

    //Ejemplo 4 orden y nombre de parámetros
    public void ImprimirMensaje(string mensaje, int numero)
    {
        Console.WriteLine($"{mensaje} {numero}");
    }


}