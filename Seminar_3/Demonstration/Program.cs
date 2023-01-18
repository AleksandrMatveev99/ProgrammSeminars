// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Запрос ввода координат
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите у: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не могут равняться нулю");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}