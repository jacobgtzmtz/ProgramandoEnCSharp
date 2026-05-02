using System;

namespace GenericosYColecciones;

public class Diccionario
{
    Dictionary<string, int> MiDiccionario = new Dictionary<string, int>();

    public void AgregarElementos()
    {
        MiDiccionario.Add("Uno", 1);
        MiDiccionario["Dos"] = 2;
    }

    public void ObtenerElementos()
    {
        foreach (var item in MiDiccionario.Values)
        {
            Console.WriteLine(item);
        }
    }

    public void ParImpar()
    {
        //Creamos el diccionario con 2 llaves, cada una con una lista de enteros vacia;
        var dicionario = new Dictionary<string, List<int>>();
        dicionario.Add("Par", new List<int>()); 
        dicionario.Add("Impar", new List<int>());

        //Actualizamos la lista de enteros de cada llave
        for (int i = 1; i <=10 ; i++)
        {
            string llave = i%2 == 0 ? "Par" : "Impar";
            dicionario[llave].Add(i);
        }

        //Imprimimos las dos llaves del diccionario con su respectiva lista de valores
        foreach (var llave in dicionario)
        {
            Console.WriteLine(llave.Key);
            foreach (var valor in llave.Value)
            {
                Console.WriteLine(valor);
            }
        }
    }

}
