/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, 1, 9);
PrintArray(array);
SortArrayDescending(array);
PrintArray(array);

void SortArrayDescending(int[,] array)
{
    int exchange = 0;
    for (int p = 0; p < array.GetLength(0); p++)
        for (int i = 0; i < array.GetLength(1) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
                if (array[p, i] < array[p, j])
                {
                    exchange = array[p, i];
                    array[p, i] = array[p, j];
                    array[p, j] = exchange;
                }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rowArray, int colArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    return resultArray;
}