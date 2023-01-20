// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum+=i;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number > 0)
{
    int summa = GetSumToA(number);
    Console.WriteLine($"Сумма = {summa}");
}
else
{
    Console.WriteLine("Введено неверное число");
}