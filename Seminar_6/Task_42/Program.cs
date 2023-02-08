// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// int[] convertingToBinary(int decimalNumber)
// {
//     int count = 0;
//     int newNumber = decimalNumber;
//     while (newNumber > 0)
//     {
//         newNumber /= 2;
//         count++;

//     }
//     int[] array = new int[count];
//     int ost = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         ost = decimalNumber % 2;
//         decimalNumber = decimalNumber / 2;
//         array[array.Length - 1 - i] = ost;
//     }
//     return array;
// }


// Конкатенация - склеивание строк
string convertingToBin(int decimalNum)
{
    string binary = "";
    string k = "";
    while (decimalNum > 0)
    {
        k = Convert.ToString(decimalNum % 2);
        binary = k + binary;
        decimalNum /= 2;
    }
    return binary;
}

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int[] arr = convertingToBinary(number);
// Console.WriteLine(string.Join(" ", arr));

string binNumber = convertingToBin(number);
Console.WriteLine(binNumber);