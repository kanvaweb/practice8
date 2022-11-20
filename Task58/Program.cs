// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandomArray(int quantityRows, int quantityColumns)
{
    Random rnd = new Random();
    if (quantityRows == 0)
        quantityRows = rnd.Next(2,6);
    if (quantityColumns == 0)
        quantityColumns = rnd.Next(2,6);

    int[,] resultArray = new int[quantityRows, quantityColumns];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(1,10); // от 1 до 9
        }
    }
    return resultArray;
}


 void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

 int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)]; // После умножения у матрицы кол-во строк равно кол-ву строк матрицы A, а кол-во колонок кол-ву колонок матрицы B

    for (int ci = 0; ci < matrixC.GetLength(0); ci++)
        for (int cj = 0; cj < matrixC.GetLength(1); cj++)
        {
            matrixC[ci,cj] = 0;
            for (int aj = 0; aj < matrixA.GetLength(1); aj++)
                // for (int bi = 0; bi < matrixB.GetLength(0); bi++)
                    matrixC[ci,cj] = matrixC[ci,cj] + (matrixA[ci,aj] * matrixB[cj,cj]);
        }
    return matrixC;
}

    int[,] tableArrayA = CreateRandomArray(0, 0);
    int[,] tableArrayB = CreateRandomArray(tableArrayA.GetLength(1), 0); // Кол-во строк у матрицы B должно быть равно кол-ву колонок матрицы А

    // Console.Clear();
    Console.WriteLine("Матрица A:");
    PrintArray(tableArrayA);
    Console.WriteLine("\nМатрица B:");
    PrintArray(tableArrayB);

    Console.WriteLine("\nРезультат перемножения матриц:");
    int[,] tableArrayC = MultiplicationMatrix(tableArrayA, tableArrayB);
    PrintArray(tableArrayC);
    Console.WriteLine("\n");
