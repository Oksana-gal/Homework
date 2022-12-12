// Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear(); 
Console.Write("Введите размер массива элементов: "); 
int arraySize = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[arraySize];
Random rnd = new Random();
for (int i = 0; i < arraySize; i++) 
{
    array[i] = rnd.Next(100);
}

Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

int[] arrayRotateRight(int[] array) 
{
    int size = array.Length;
    int[] result = new int[array.Length];
    int temp = array[size - 1];        
    while (size > 1) 
    {
        result[size - 1] = array[size - 2];
        size--;
    }
    result[0] = temp;
    return result;
}
  
Console.WriteLine($"Сдвиг вправо: [{string.Join(", ", arrayRotateRight(array))}]");

int[] arrayRotateLeft(int[] array) 
{
    int size = array.Length - 1;
    int[] result = new int[array.Length];
    int temp = array[0];
    for (int i = 0; i < size; i++) result[i] = array[i + 1];
    result[size] = temp;
    return result;
}
Console.WriteLine($"Сдвиг влево: [{string.Join(", ", arrayRotateLeft(array))}]"); 