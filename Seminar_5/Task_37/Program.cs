// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] workNumbers(int[] array)
{
    int newSize = array.Length / 2 + array.Length % 2; // int newSize = (array.Length + 1) / 2;
    int[] newArray = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (newSize % 2 != 0)
    {
        newArray[newSize - 1] = array[newSize - 1];
    }
    return newArray;
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
Console.WriteLine(string.Join(" ", arr));

int[] newArr = workNumbers(arr);
Console.WriteLine(string.Join(" ", newArr));