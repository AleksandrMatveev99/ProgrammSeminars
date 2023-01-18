/* Напишите программу, которая принимает на вход число (N)
 * и выдаёт таблицу квадратов чисел от 1 до N.*/
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
}