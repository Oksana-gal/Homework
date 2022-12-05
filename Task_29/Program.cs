// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите массив из 8 чисел через запятую (т.е. 1, 2, 3, 4, 5, 6, 7, 8)");
string? input = Console.ReadLine(); 
if (!String.IsNullOrEmpty(input)) 
{
    int[] result = input.Split(',').Select(numberAsString => Int32.Parse(numberAsString.Trim())).ToArray();
    if (result.Length != 8) 
    {
        Console.WriteLine($"Длина введенного массива: {result.Length}. Требуемая длина: 8");
        return;
    }
    Console.Write($"\nМассив чисел: [{String.Join(", ", result)}]");
}