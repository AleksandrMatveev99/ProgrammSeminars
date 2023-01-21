//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

const int size = 12;
const int leftRange = -9;
const int rightRange = 9;

int[] massive = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine(string.Join(" ", massive));
int sumP = 0;
int sumN = 0;

for (int index = 0; index < massive.Length; index++)
{
    if (massive[index] >= 0)
    {
        sumP += massive[index];
    }
    else
    {
        sumN += massive[index];
    }
}
Console.WriteLine($"Сумма положительных чисел = {sumP}");
Console.WriteLine($"Сумма отрицательных чисел = {sumN}");