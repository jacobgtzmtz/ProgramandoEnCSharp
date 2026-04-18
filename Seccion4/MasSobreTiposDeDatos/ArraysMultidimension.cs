class ArraysMultidimension
{
    public void ejercicio()
    {
        //Ejemplo1
        int[,] miArray1 = new int[2, 2];
        miArray1[0, 0] = 1;
        miArray1[0, 1] = 2;
        miArray1[1, 0] = 3;
        miArray1[1, 1] = 4;

        Console.WriteLine(miArray1[0, 1]); // 2

        //Ejemplo 2
        int[,] miArray2 = new int[,]
        {
            {1,2},
            {4,6},
            {8,9}
        };
        Console.WriteLine(miArray2[2, 1]); // 9

        for (int fila = 0; fila < miArray2.GetLength(0); fila++)
        {
            for (int columna = 0; columna < miArray2.GetLength(1); columna++)
            {
                Console.Write(miArray2[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}