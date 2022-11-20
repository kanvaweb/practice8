// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandomArray(int quantity1, int quantity2, int quantity3)
{
    List<int> listElements = new List<int>(); // список всех значений для поиска не повторяющихся

    Random rnd = new Random();
    if (quantity1 == 0)
        quantity1 = rnd.Next(2,5);
    if (quantity2 == 0)
        quantity2 = rnd.Next(2,5);
    if (quantity3 == 0)
        quantity3 = rnd.Next(2,5);

    int[,,] resultArray = new int[quantity1, quantity2, quantity3];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int z = 0; z < resultArray.GetLength(2); z++)
            {
                bool findUniqueNumber = true;
                int currUniqueNumber = 0;
                while (findUniqueNumber)
                {
                    currUniqueNumber = rnd.Next(10,100); // от 10 до 99
                    findUniqueNumber = listElements.Contains(currUniqueNumber);
                    // Console.WriteLine($"findUniqueNumber = {findUniqueNumber}   currUniqueNumber = {currUniqueNumber}");
                }
                listElements.Add(currUniqueNumber);  
                resultArray[i,j,z] = listElements.Last(); 
            }
        }
    }
    // Console.WriteLine(String.Join(", ", listElements)); 
    return resultArray;
}


 void PrintArray(int[,,] array)
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,z]}({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

    int[,,] array = CreateRandomArray(2, 2, 2);
    Console.WriteLine($"Трехмерный массив уникальных двухзначных чисел размером ({array.GetLength(0)},{array.GetLength(1)},{array.GetLength(2)})");
    PrintArray(array);
    Console.WriteLine("\n");
