class UtilidadesArreglos<T>
{
        internal int GetLongitud(T[] arreglo)
        {
            Console.WriteLine(arreglo.Length);
            return arreglo.Length;
        }

        internal T? PrimerElemento(T[] arreglo)
        {
            T value = default;
            if (arreglo.Length != 0)
            {
                value = arreglo[0];
            }
            return value;
        }

}