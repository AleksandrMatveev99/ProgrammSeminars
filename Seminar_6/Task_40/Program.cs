// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Treangle(int x, int y, int z)
{
    if (x < y + z && y < z + x && z < x + y)
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Такой треугольник существует? {Treangle(a, b, c)}");