//Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.


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

int[] array = GetArray(10, 0, 10);

Console.WriteLine();
int sum= 0;
for (int i = 0; i < array.Length; i++)

    if (i % 2 != 0)
    {
        Console.Write($"{array[i]} ");
        sum= sum+array[i];
               
    }
Console.WriteLine();
Console.WriteLine(sum);