// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-2]+array[i-1];
    }
    return array;
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = Fibonacci(n);
Console.WriteLine(string.Join(" ", arr));