// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadInt (string message)
{
    System.Console.WriteLine($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray( int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd+1);
    }
    return array;
}
int length = ReadInt("Введите длину массива ");
int minRnd = ReadInt("Введите границу минимума ");
int maxRnd = ReadInt("Введите границу максимума ");
int[] array = CreateArray(length, minRnd, maxRnd);
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int maxarray = array[0];
int minarray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxarray)
    {
        maxarray = array[i];
    }
    if (array[i] < minarray)
    {
        minarray = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxarray - minarray}");
