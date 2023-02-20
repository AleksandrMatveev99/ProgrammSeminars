// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigit(int number)
{
    if (number == 0) return number;
    return number % 10 + SumDigit(number / 10);
}

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumDigit(N);
Console.Write(sum);