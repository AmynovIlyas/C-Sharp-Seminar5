// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// попытка решения путем возвращения массива (успешная!)

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] MultiplicationsPairs(int[] array)
{
    if (array.Length % 2 != 0)
    {
        int[] arr1 = new int[array.Length / 2 + 1];
        arr1[array.Length / 2] = array[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            arr1[i] = array[i] * array[array.Length - 1 - i];
        }
        return arr1;
    }
    else
    {
        int[] arr1 = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            arr1[i] = array[i] * array[array.Length - 1 - i];
        }
        return arr1;
    }
}

int[] array = CreateArray(8, -10, 10);
Console.Write($"[{String.Join(", ", array)}]" + " --> ");
int[] arr1 = MultiplicationsPairs(array);
Console.Write($"[{String.Join(", ", arr1)}]");
