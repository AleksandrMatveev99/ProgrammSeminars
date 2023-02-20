// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NumberRecursion(int number)
{
    if (number == 0) return;
    NumberRecursion(number - 1);
    Console.Write($"{number} ");
}

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
NumberRecursion(N);