class Arrays
{
    public void ejercicio()
    {
        //Ejemplo 1: declaración de array sin inicalizar
        char[] vocales = new char[5];
        vocales[0] = 'a';
        vocales[1] = 'e';
        vocales[2] = 'i';
        vocales[3] = 'o';
        vocales[4] = 'u';

        foreach (char vocal in vocales)
        {
            Console.WriteLine(vocal);
        }
        
        //Ejemplo 2: Declaración de Array e inicialización
        int[] numeros = {1,2,3,4,5};
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //Ejemplo 3: otra forma de incializar arrays
        int[] numeros2 = new int[] {1,2,3,4,5};

    }
}