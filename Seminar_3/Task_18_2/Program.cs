// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Запрос ввода четверти у пользователя
Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine($"Допустимые значения {number}й четверти: x > 0, y > 0");
        break;
    
    case 2:
        Console.WriteLine($"Допустимые значения {number}й четверти: x < 0, y > 0");
        break;
    
    case 3:
        Console.WriteLine($"Допустимые значения {number}й четверти: x < 0, y < 0");
        break;
    
    case 4:
        Console.WriteLine($"Допустимые значения {number}й четверти: x > 0, y < 0");
        break;
    
    default:
    Console.WriteLine($"Такой четверти не существует");
        break;
}