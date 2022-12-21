// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} -> {NaturalElementsSumm(m,n)}");

int NaturalElementsSumm(int m, int max)
{
    if (m > max) return 0;
    return m + NaturalElementsSumm(m + 1, max);
}
