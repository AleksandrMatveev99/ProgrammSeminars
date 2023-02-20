// Перевести десятичное число в двоичное

void PrintBinaryView(int n)
{
    if (n <= 0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}

int number = 13;
PrintBinaryView(number);