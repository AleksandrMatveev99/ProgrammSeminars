// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write($"{collection[index]} ");
    }
}
int count = ReadNumber("Введите количество чисел: ");
if(count>0)
{
    int[] array = new int[count];
    FillArray(array);
    PrintArray(array);
}
else
{
    Console.WriteLine("Число должно быть >= 1");
}