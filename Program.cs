// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");

