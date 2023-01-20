// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CountDigit(int remainingNumber)
{
    int count = 0;
    while (remainingNumber != 0)
    {
        remainingNumber = (remainingNumber - remainingNumber % 10) / 10;
        count++;
    }
    return count;
}
// int number = ReadNumber("Введите число: ");
// int countDig = CountDigit(number);
// Console.WriteLine(countDig);
Console.WriteLine(-546 % 10);