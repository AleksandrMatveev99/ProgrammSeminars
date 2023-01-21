// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void FindNumber(int[] massive, int findNumber)
{
    bool answer = false;
    for (int index = 0; index < massive.Length; index++)
    {
        if (massive[index] == findNumber)
        {
            answer = true;
            break;
        }
    }
    if (answer == true)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

Console.Write("Введите длину массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
if (sizeArr < 1)
{
    Console.WriteLine("Число должно быть положительным");
    return;
}

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое значение: ");
int findValue = Convert.ToInt32(Console.ReadLine());

int[] arr = GetRandomArray(sizeArr, minValue, maxValue);
Console.WriteLine(string.Join(" ", arr));

FindNumber(arr, findValue);