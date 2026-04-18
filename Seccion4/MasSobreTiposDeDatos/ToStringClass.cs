class ToStringClass
{
    public void ejercicio()
    {
        var cantidad = 5;
        if(cantidad.ToString() == "5")
        {
            Console.WriteLine("Son iguales");
        }
        else
        {
            Console.WriteLine("No son iguales");
        }


        var hoy = DateTime.Now;
        Console.WriteLine(hoy.ToString());
        Console.WriteLine($"Hoy es {hoy.ToString("dddd dd/MM/yyyy")}");
    
    }
}