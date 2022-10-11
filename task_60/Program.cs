/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillAndPrintThreeDimArray(int rowsNumbers, int columnNumbers, int heightNumbers)
{
    int[,,] myArray = new int[rowsNumbers, columnNumbers, heightNumbers];
    int number = 10;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i, j, k] = number;
                Console.Write($"{myArray[i, j, k]} ({i}, {j}, {k})  ");
                number++;
            }
             Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int rowsNumbers = new Random().Next(2, 5);
int columnNumbers = new Random().Next(2, 5);
int heightNumbers = new Random().Next(2, 5);
// Console.WriteLine($"m = {rowsNumbers}, n = {columnNumbers}, l = {heightNumbers}");
FillAndPrintThreeDimArray( rowsNumbers, columnNumbers, heightNumbers);
Console.WriteLine();