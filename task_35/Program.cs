// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void FindNumElements(int[] array, int userNumMin, int userNumMax)
{
    int n = 0;
    foreach(int el in array)
    {
        if(el >= userNumMin && el <= userNumMax)
        {
            n++;
        }
    }
    Console.WriteLine($"[{String.Join(", ", array)}] --> {n}(количество элементов массива, значения которых лежат в отрезке [{userNumMin};{userNumMax}])");
}

int[] array = CreateArray(123, -1000, 1000);
FindNumElements(array, 10, 99);


