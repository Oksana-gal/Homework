// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.

// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Write("Введите первое число: ");
int NumN = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int NumM = Convert.ToInt32(Console.ReadLine()); 

for (int i = NumN; i <= NumM; i++)
{
    if (i > NumN) {  
        Console.Write(", ");
    }

    int pow3 = (int) Math.Pow(i, 3);
    Console.Write($"{pow3}");
}




