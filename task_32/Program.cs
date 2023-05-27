// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// Например:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    Console.Write("{");
    for(int i = 0; i < size - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[size - 1]}" + "}" + " --> {");
    return array;
}



int[] Replacement(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            arr[i] -= Math.Abs(arr[i]) * 2; 
        }
        else
        {
            arr[i] += Math.Abs(arr[i]) * 2;
        }
    }
    return arr;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}" + "}");
}

int[] array = CreateArray(4, -10, 10);
int[] array1 = Replacement(array);
PrintArray(array1);

