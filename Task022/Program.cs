// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром.");
    }
    else Console.WriteLine($"{number} - не палиндром.");
}

if (number!.Length == 5)
{
    CheckNumber(number);
}
else Console.WriteLine($"incorrect");