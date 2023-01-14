// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Запрос чисел у пользователя
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Развилка
if(number1 == number2 * number2)
{
    Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
}
else
{
    Console.WriteLine($"Первое число {number1} не является квадратом второго числа {number2}");
}