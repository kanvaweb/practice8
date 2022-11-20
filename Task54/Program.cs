// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

 void SortArrayByDesc(int[,] array)
{
    int tempElement;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 1; z < array.GetLength(1); z++)
            {
                if (array[i,z] > array[i,z-1])
                {
                    tempElement = array[i,z-1];
                    array[i,z-1] = array[i,z];
                    array[i,z] = tempElement;
                }
            }
        }
    }
    
    // return resultArray;
}

    int[,] tableArray = CreateRandomArray();
    Console.Clear();
    Console.WriteLine("Исходный массив :");
    PrintArray(tableArray);
    Console.WriteLine("\nОтсортированный по убыванию массив:");
    SortArrayByDesc(tableArray);
    PrintArray(tableArray);
    Console.WriteLine("\n");
