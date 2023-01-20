// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplicationNumber(int number)
{
    int proizved = 1;
    for (int i = 1; i <= number; i++)
    {
        proizved *= i;
    }
    return proizved;
}

int N = ReadNumber("Введите число: ");
if (N < 0)
{
    Console.WriteLine("Неверное число");
}
else
{
    int multiplication = MultiplicationNumber(N);
    Console.WriteLine(multiplication);
}