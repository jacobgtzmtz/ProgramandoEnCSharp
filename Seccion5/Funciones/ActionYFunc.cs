class ActionYFunc
{
    public void ejercicio()
    {
        //las Action solo sirven para trabajar con funciones que no retornan valores, es decir declaradas como void
        // Ejemplo 1: Actions que no reciben parámetros.
        Action imprimirMensaje;
        void ImprimirFechaYHora() => Console.WriteLine(DateTime.Now);
        void ImprimirMiNombre() => Console.WriteLine("Jacob");
        imprimirMensaje = ImprimirFechaYHora;
        imprimirMensaje();
        imprimirMensaje = ImprimirMiNombre;
        imprimirMensaje();

        // Ejemplo 2: Actions con funciones que reciben parámetros.
        Action<int> alterarNumero;
        void Agregar1(int numero) => Console.WriteLine($"EL número {numero} más 1 es: {numero + 1}");
        alterarNumero = Agregar1;
        alterarNumero(5);

        //Las func sirven para trabajar con funciones que sí retornan un valor
        // Ejemplo 3: func que no recibe parámetros
        Func<string> retornaString;

        string ObtenerFechaYHora() => DateTime.Now.ToString();
        retornaString = ObtenerFechaYHora;
        Console.WriteLine(retornaString());

        //Ejemplo 3: Func que recibe parámetros.
        Func<int, int, string>realizarOperacion;
        string suma(int num1, int num2)
        {
            return $"La suma de {num1} y {num2} es {num1 + num2}";
        }

        realizarOperacion = suma;
        Console.WriteLine(realizarOperacion(5,6));

        //Los predicate son func que siempre retornan un booleano
        //Ejemplo 4

        bool EsPar(int numero) => numero % 2 == 0;
        Predicate<int> esPar;
        esPar = EsPar;
        Console.WriteLine($"El número 8 es par: {esPar(8)}");
                    
    }
}