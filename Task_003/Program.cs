// Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string cleanedInput = input.Replace(" ", "").ToLower();

        char[] charArray = cleanedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        if (cleanedInput == reversedInput)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }
}

