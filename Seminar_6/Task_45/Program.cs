// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
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

int[] arr = GetRandomArray(sizeArr, minValue, maxValue);

int[] newArr = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    newArr[i] = arr[i];
}

arr[0] = -1000;

Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(string.Join(" ", newArr));