// Вывести первые N строк треугольника Паскаля

int Factorial(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

int[,] TrianglePascal(int size)
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            matrix[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) break;
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = TrianglePascal(m);
PrintMatrix(array);