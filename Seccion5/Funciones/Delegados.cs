/*
    Action, func y Predicate son delegate pero cuando se necesita que ele retorno de la función sea un parámetro out
    solo se puede hacer usando delegate.
    *****Los delegados se declaran a nivel de la clase, no se pueden declarar dentro de los métodos.*****
*/

// Delegate miDelegado(int, int);
class Delegados
{
    delegate bool TryParseDelegado(string valor, out int resultado);
    public void ejercicio()
    {
        TryParseDelegado miTryParse = TryParse2;
    
        bool TryParse2(string valor, out int resultado)
        {
            return int.TryParse(valor, out resultado);
        }

        int cantidad;
        if(miTryParse("5", out cantidad))
        {
            Console.WriteLine(cantidad);     
        }

       
    }
}

