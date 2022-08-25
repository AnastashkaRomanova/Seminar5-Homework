//Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), 2);


        Console.Write($"{res[i]} ");
    }
    return res;
}

double[] array = GetArray(10);
int i = 0;
double maxValue = array[0];
double minValue = array[1];
while (i < array.Length)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
    i++;
}
Console.WriteLine();
Console.WriteLine($"Максимальное число массива= {maxValue}");
Console.WriteLine($"Минимальное число массива= {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {maxValue - minValue}");
