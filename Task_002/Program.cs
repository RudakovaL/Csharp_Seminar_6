//  Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        string inputString = "Hello World! This Is A Test String.";

        string lowerCaseString = inputString.ToLower();

        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка в нижнем регистре: " + lowerCaseString);
    }
}
