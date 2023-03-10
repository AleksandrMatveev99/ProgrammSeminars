// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumberPow(int firstNumber, int secondNumber)
{
    if (secondNumber == 0) return 1;
    return NumberPow(firstNumber, secondNumber - 1) * firstNumber;
}

Console.Write("Введите натуральное число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write(NumberPow(A, B));