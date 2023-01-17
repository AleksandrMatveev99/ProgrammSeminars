// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// Запрос ввода чисел
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Проверка на ноль, дальше кратность
if (number2 == 0)
{
    Console.WriteLine("Второе число не может быть нулём");
}
else  
{
    int rest = number1 % number2;
    if(rest == 0)
    {
        Console.WriteLine($"Второе число {number2} кратно первому числу {number1}");
    }
    else
    {
        Console.WriteLine($"Второе число {number2} не кратно первому числу {number1}, остаток от деления - {rest} ");
    }
}
