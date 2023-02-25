// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
int NumOfEvenNum(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}
var myArray = GenArr(10,100, 999);
PrintArray(myArray);
System.Console.WriteLine(NumOfEvenNum(myArray));