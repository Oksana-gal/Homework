/*  Задайте значения M и N. Напишите программу, 
которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/
Console.Clear();
Console.Write("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"НОД чичел M = {m}; N = {n} -> {FindNod(m, n)}"); 
int FindNod(int m, int n)
{
    int nod = 0;
    if (m == 0 || n == 0) { nod = m + n; }
    else
        if (m > n) { nod = FindNod(m % n, n); }
        else       { nod = FindNod(m, n % m); }
    return nod;
    }