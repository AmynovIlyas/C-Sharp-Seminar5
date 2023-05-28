// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// минус оставляем и попробуем решить через преобразование чисел по модулю

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int Prompt()
{
    Console.Write("Введите искомое число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void FindNumArray(int[] array, int num)
{
    bool check = false;
    foreach(int el in array)
    {
        if(el == num || el == -num)
        {
            Console.WriteLine($"{num}; массив [{String.Join(" ", array)}] --> да");
            check = true;
            break;
        }
    }
    if(check == false)
    {
        Console.WriteLine($"{num}; массив [{String.Join(", ", array)}] --> нет");
    }
}

int[] array = CreateArray(10, -10, 10); int number = Prompt();
FindNumArray(array, number);
