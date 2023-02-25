// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenArr(int lenght, int left, int right)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(left, right + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] myArray = GenArr(5, 10, 99);
PrintArray(myArray);
System.Console.WriteLine(SumOdd(myArray));
