/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.Write("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = FillArray(size, size, 1, 5);
int[,] arrayB = FillArray(size, size, 1, 5);
Console.WriteLine("Первая матрица:");
PrintArray(arrayA);
Console.WriteLine("Вторая матрица:");
PrintArray(arrayB);
Console.WriteLine("Результат произведения матриц будет:");
PrintArray(CalculateMatrixProduct(arrayA, arrayB));

int[,] CalculateMatrixProduct(int[,] arrayA, int[,] arrayB)
{
    int size = arrayA.GetLength(0);
    int[,] result = new int[size, size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
            result[i, j] = 0;
            for (int p = 0; p < size; p++)
                result[i, j] += arrayA[i, p] * arrayB[p, j];
        }
    return result;
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