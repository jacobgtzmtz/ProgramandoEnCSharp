using System;

namespace GenericosYColecciones;

public class Listas
{
    List<int> myList = new List<int>();

    public Listas(List<int> numeros)
    {
        myList = numeros;
    }

    public void AgregarElemento(int item)
    {
        myList.Add(item);
        ObtenerElementos();
    }

    public void ObtenerElementos()
    {
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
    public void EliminarElemento(int item)
    {
        myList.Remove(item);
        ObtenerElementos();
    }

    public void EliminarElementoPorPosicion(int posicion)
    {
        myList.RemoveAt(posicion);
        ObtenerElementos();
    }

    public void EliminarTodosLosElementos()
    {
        myList.Clear();
    }

}
