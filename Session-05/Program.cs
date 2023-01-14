// See https://aka.ms/new-console-template for more information


// Write a C# program that reverses a given string (your name)

using System;

class SessionFive
{

    public static string Reverse(string Input)
    {

        // Converting string to character array
        char[] charArray = Input.ToCharArray();

        // Declaring an empty string
        string reversedString = String.Empty;

        // Iterating the each character from right to left
        for (int i = charArray.Length - 1; i > -1; i--)
        {

            // Append each character to the reversedstring.
            reversedString += charArray[i];
        }

        // Return the reversed string.
        return reversedString;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("Katerina"));
        Console.ReadLine();


        // Write a C# program that asks the user for an integer (n) and gives them
        // the possibility to choose between computing the sum and computing the product of 1..n


        Console.Write("Input  a number(integer): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
        Console.ReadLine();


        int num, product = 1;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Repeat the steps till n becomes 0
        while (num != 0)
        {
            product = product * (num % 10);

            // Remove the last digit from n
            num = num / 10;
        }

        Console.WriteLine("Product of digits = " + product);

        Console.ReadLine();

    }
 }