class Casteos
{
    public void ejercicio()
    {
        //Ejemplo 1: Casteo explicito
        int numero1 = 7;
        int numero2 = 4;

        var division = (double)numero1 / numero2; //Casteo implicito resultado: 1.75
        Console.WriteLine(division);

        //Ejemplo 2: Otro casteo explicito
        byte miByte1;
        int miInt1 = 200;
        checked
        {
            //Hay que tener cuidado por que al hacer el casteo de un tipo más grande puede haber un overflow (Es mejor encerrarlo en bloque checked)
            miByte1 = (byte)miInt1; 
        }
        Console.WriteLine(miByte1);

        // Ejemplo3: Casteo implicito
        byte miByte2 = 127;
        int miInt2 = miByte2; //Un byte siempre va a caber en un int
        Console.WriteLine(miInt2);
    }
}