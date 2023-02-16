// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CountNumber(int[,] matrix, int leftGrade, int rightGrade)
{
    int[] counters = new int[rightGrade - leftGrade + 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i, j];
            counters[index]++;
        }
    }
    for (int i = 0; i < counters.Length; i++)
    {
        if (counters[i] > 0) Console.WriteLine($"{i} встречается {counters[i]} раз");
    }
}

// void PrintCount(int numberMatrix, int countDuplicate)
// {
//     if (countDuplicate == 0) return;
//     else Console.WriteLine($"{numberMatrix} встречается {countDuplicate} раз");
// }

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int minValue = ReadNumber("Введите минимальное число: ");
int maxValue = ReadNumber("Введите максимальное число: ");


int[,] array = GetRandomMatrix(m, n, minValue, maxValue);
PrintMatrix(array);
Console.WriteLine();

CountNumber(array, minValue, maxValue);