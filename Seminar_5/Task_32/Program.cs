// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GetRandomNumber(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
if (count<1) 
{
    Console.WriteLine("Введите положительное число");
    return;
}
Console.Write("Введите левую границу: ");
int range1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу: ");
int range2 = Convert.ToInt32(Console.ReadLine());

int[] arr = GetRandomNumber(count, range1, range2);
Console.WriteLine(string.Join(" ", arr));

for (int index = 0; index < arr.Length; index++)
{
    arr[index] *= -1;
}
Console.WriteLine(string.Join(" ", arr));