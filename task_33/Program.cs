// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int size, int minValue, int maxValue)
{
    Console.Write("{");
    int[] array = new int[size];
    for(int i = 0; i < array.Length - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}" + "}");
    return array;
}

int FindNumber(int[] array, int number)
{
    int res = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            res = 1;
        }
    }
    return res;
}

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateNumber(int number)
{
    if(number == 0)
    {
        Console.Write(" --> нет");
        return false;
    }
    return true;
}

int number = Prompt();
int[] array = CreateArray(20, 1, 10);
int res = FindNumber(array, number);
if(ValidateNumber(res))
{
    Console.Write(" --> да");
}






