// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string NumberRec(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber) return $"{firstNumber}, " + NumberRec(firstNumber + 1, secondNumber);
    else return $"{secondNumber}";
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(NumberRec(M,N));