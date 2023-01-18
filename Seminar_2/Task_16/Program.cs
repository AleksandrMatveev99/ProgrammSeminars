// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int first = 0;
int second = 0;

// Запрос ввода чисел
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0)
{
    first = number1 * (-1);
}
else
{
    first = number1;
}
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 0)
{
    second = number2 * (-1);
}
else
{
    second = number2;
}

// Проверка условия
if (Math.Sqrt(first) == second & number1 > 0)
{
    Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
}
else if (Math.Sqrt(second) == first & number2 > 0)
{
    Console.WriteLine($"Второе число {number2} является квадратом первого числа {number1}");
}
else
{
    Console.WriteLine("Условие не выполняется");
}
