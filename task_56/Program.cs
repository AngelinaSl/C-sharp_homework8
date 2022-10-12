/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] FillAndPrintTwoDimArray(int rowsNumbers, int columnNumbers)
{
    int[,] myArray = new int[rowsNumbers, columnNumbers];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{myArray[i, j]}  ");
        }
        Console.WriteLine();
    }
    return myArray;
}

int[] SumArray(int[,] array)
{
    int i = 0;
    int index = 0;
    int[] sumArray = new int[array.GetLength(0)];
    while (i < array.GetLength(0))
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumArray[index] = sum; 
        i++;
        index++;
    }
    return sumArray;
}


void SearchMinSumInString(int[] array)
{
    int i = 0;
    int minSum = array[0];
    for (i = 1; i < array.Length; i++)
    {
        if (minSum > array[i])
        {
            minSum = array[i];
        }
    }
    i = 0;
    int index = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == minSum)
            index = i;
    }
    Console.WriteLine($"В(o) {index + 1} строке наименьшая сумма элементов.");
}

int rowsNumbers = new Random().Next(3, 5);
int columnNumbers = new Random().Next(3, 5);
int[,] array = FillAndPrintTwoDimArray(rowsNumbers, columnNumbers);
Console.WriteLine();
int[] sumArray = SumArray(array);
Console.WriteLine();
SearchMinSumInString(sumArray);