// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

 
Console.Write("Введите число : "); 
string? input = Console.ReadLine();
if (string.IsNullOrEmpty(input)) {
    return;
}
if (input.Length < 3) 
{
    Console.Write("Третьего числа нет");
} 
else 
{
    Console.Write($"Третья цифра числа - {input[2]}");
}
