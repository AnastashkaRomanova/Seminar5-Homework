//Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(10, 100, 1000);

Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
    {

        Console.Write($"{array[i]} ");

        count++;
    }
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в масиве=  {count} ");
