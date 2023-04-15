//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    if (i % 2 != 0)
    {
        result += array[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");
