// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Случайное число
int number = new Random().Next(10, 100);

// Первая цифра числа number
int firstDigit = number / 10;

// Вторая цифра числа number
int secondDigit = number % 10;

// Вывод числа
Console.WriteLine($"Случайное число: {number}");

// Условие
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}
else if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}
else
{
    Console.WriteLine("Цифры в числе равны");
}
