// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Запрос ввода четверти у пользователя
Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 4)
{
    Console.WriteLine("Такой четверти нет");
    return;
}
if (number == 1)
{
    Console.WriteLine("Допустимый диапазон: x > 0, y > 0");
}

else if (number == 2)
{
    Console.WriteLine("Допустимый диапазон: x < 0, y > 0");
}

else if (number == 3)
{
    Console.WriteLine("Допустимый диапазон: x < 0, y < 0");
}

if (number == 4)
{
    Console.WriteLine("Допустимый диапазон: x > 0, y < 0");
}