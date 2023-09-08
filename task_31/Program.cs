// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Console.Write("{");
    for (int i = 0; i < length - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[length - 1]}" + "}");
    return array;
}

int[] array = GetArray(12, -9, 9);
GetSum(array);


void GetSum(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            positiveSum += el;
        }
        else
        {
            negativeSum += el;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");
}



