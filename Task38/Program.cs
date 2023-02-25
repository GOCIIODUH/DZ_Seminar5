// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenArr(int lenght, int left, int right)
{
    double[] array = new double[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = Math.Round(random.Next(left, right) + random.NextDouble(), 2);
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}
double LookMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
double LookMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
void Dif(double numberMax,double numberMin)
{
    System.Console.Write($"Разница составляет: {numberMax - numberMin}");
}
double[] myArray = GenArr(5, 1, 10);
PrintArray(myArray);

System.Console.WriteLine($"Максимальный элемент массива: {LookMax(myArray)}");
System.Console.WriteLine($"Минимальный элемент массива: {LookMin(myArray)}");
Dif(LookMax(myArray), LookMin(myArray));