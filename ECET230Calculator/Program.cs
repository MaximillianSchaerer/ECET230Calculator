using System;

int num1  = 0;
int num2 = 0;

Console.WriteLine("Console Calculator in C#");
Console.WriteLine("------------------------\n");

Console.WriteLine("Enter the first integer number, then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer number, then press Enter");
num2  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an operation from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");

switch(Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;

    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;

    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;

    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.Write("Press any key to close the console");
Console.ReadKey();