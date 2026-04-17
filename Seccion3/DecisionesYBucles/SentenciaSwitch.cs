class SentenciaSwithc
{
    public void ejercicio()
    {
        var lugar = 1;

        switch (lugar)
        {
            case 1:
            Console.WriteLine("Felicidades por tu primer lugar");
            break;

            case 2:
            Console.WriteLine("Felicidades por tu segundo lugar");
            break;

            case 3:
            Console.WriteLine("Felicidades por tu tercer lugar");
            break;  
            
            default:
            Console.WriteLine("no te rindas, sigue intentando");
            break;
        
        }
    }
}