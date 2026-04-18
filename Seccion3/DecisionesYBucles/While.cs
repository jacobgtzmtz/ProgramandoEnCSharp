class While
{
    public void ejercicio()
    {
        int contador = 1;
        while(contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        decimal balance = 200m;
        decimal interes = 1.07m;
        int contInversionAños = 1;

        while(contInversionAños <= 10)
        {
            balance *= interes;
            contInversionAños++;
        }
        Console.WriteLine(balance);

    }
}