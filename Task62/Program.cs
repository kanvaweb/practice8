// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string GetNumWith0(int currNum, int matrixSize)
{
    int lenMatrixSize = matrixSize.ToString().Length;
    string currNumStr = currNum.ToString();
    while (currNumStr.Length < lenMatrixSize)
        currNumStr = "0" + currNumStr;
    return currNumStr;
}

string[,] CreateSpiralArray()
{
    Console.Write("Введите сколько строк и колонок будет в квадратной матрице: ");
    int tableRowsAndCols = int.Parse(Console.ReadLine());

    string[,] resultArray = new string[tableRowsAndCols, tableRowsAndCols];
    int matrixSize = resultArray.GetLength(0) * resultArray.GetLength(1);

    int currNum = 1; // Счетчик значений и порядковый номер заполнения массива
    int numTurn = 0; // кол-во разворотов на 360 градусов

    if (tableRowsAndCols % 2 == 0)
        matrixSize = matrixSize;
    else
        matrixSize = matrixSize + 1;

    while (currNum < matrixSize) // количество итераций присваивания массива не более чем кол-во элементов двумерного массива
    {
        int currJ = numTurn;
        int currI = numTurn;
        for (int j = currJ; j < resultArray.GetLength(1) - numTurn; j++)
        {
            resultArray[numTurn,j] = GetNumWith0(currNum, matrixSize);
            currNum++;
            currJ = j;
        }
        for (int i = currI+1; i < resultArray.GetLength(0) - numTurn; i++)
        {
            resultArray[i,currJ] = GetNumWith0(currNum, matrixSize);
            currNum++;
            currI = i;
        }
        for (int j = currJ-1; j >= numTurn; j--)
        {
            resultArray[currI,j] = GetNumWith0(currNum, matrixSize);
            currNum++;
            currJ = j;
        }
        numTurn++;
        for (int i = currI-1; i >= numTurn; i--)
        {
            resultArray[i,currJ] = GetNumWith0(currNum, matrixSize);
            currNum++;
            currI = i;
        }
    }

    return resultArray;
}


 void PrintArray(string[,] array)
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

    string[,] tableArray = CreateSpiralArray();
    Console.WriteLine($"Матрица {tableArray.GetLength(0)} x {tableArray.GetLength(1)} со спиральным заполнением:");
    PrintArray(tableArray);
    Console.WriteLine("\n");
