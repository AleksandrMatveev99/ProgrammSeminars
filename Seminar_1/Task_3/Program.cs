// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Запрос числа от пользователя
Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

// Условия
if(number == 1)
{
    Console.WriteLine($"{number} день недели - понедельник");
}
else if(number == 2)
{
    Console.WriteLine($"{number} день недели - вторник");
}
else if(number == 3)
{
    Console.WriteLine($"{number} день недели - среда");
}
else if(number == 4)
{
    Console.WriteLine($"{number} день недели - четверг");
}
else if(number == 5)
{
    Console.WriteLine($"{number} день недели - пятница");
}
else if(number == 6)
{
    Console.WriteLine($"{number} день недели - суббота");
}
else if(number == 7)
{
    Console.WriteLine($"{number} день недели - воскресенье");
}
else
{
    Console.WriteLine($"Такого дня недели не существует");
}