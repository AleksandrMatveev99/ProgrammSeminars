// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.).

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void Reverse(int[] sourceArray)
{
    for (int index = 0; index < sourceArray.Length / 2; index++)
    {
        int temp = sourceArray[index];
        sourceArray[index] = sourceArray[sourceArray.Length - 1 - index];
        sourceArray[sourceArray.Length - 1 - index] = temp;
    }
}

const int sizeArr = 5;
const int minValue = -9;
const int maxValue = 9;

int[] arr = GetRandomArray(sizeArr, minValue, maxValue);
Console.WriteLine(string.Join(" ", arr));
Reverse(arr);
Console.WriteLine(string.Join(" ", arr));