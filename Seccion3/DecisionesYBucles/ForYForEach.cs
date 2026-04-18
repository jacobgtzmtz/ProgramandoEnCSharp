class ForYForEach
{
 public void ejercicio()
 {
    for(int i = 1; i <= 10; i++)
    {
        if(i == 5) continue;
        if(i == 8) break;
        Console.WriteLine(i);
    }

    var nombre = "Jacob";
    foreach (var letra in nombre)
    {
        Console.WriteLine(letra);
    }
 } 
}