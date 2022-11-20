// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int[,] resultArray = new int[rnd.Next(2,11), rnd.Next(2,11)];
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

 int FindRowMinimumSummOfArray(int[,] array)
{
    int resultMinimumRow = 0; 
    int sumMinimumRow = 0; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow = sumRow + array[i,j];
        if (sumRow < sumMinimumRow || resultMinimumRow == 0)
        {
            sumMinimumRow = sumRow;
            resultMinimumRow = i + 1;
        }
    }

    return resultMinimumRow;
}

    int[,] tableArray = CreateRandomArray();
    Console.Clear();
    Console.WriteLine("Исходная таблица:");
    PrintArray(tableArray);
    int minimumSumRow = FindRowMinimumSummOfArray(tableArray);
    Console.WriteLine($"\nСтрока с минимальной суммой: {minimumSumRow}");
    Console.WriteLine("\n");
