// See https://aka.ms/new-console-template for more information



// 1. Write a C# program to print Hello and your name in the same line


using System.Diagnostics.CodeAnalysis;

internal class Program {

    private static void Main(string[] args)
    {

        // 1. Write a C# program to print Hello and your name in the same line

        string a = "Hello";
        string b = "Katerina";

        Console.WriteLine(a + " " + b);

        Console.ReadLine();



        // 2.  Write a C# program to print the sum of two numbers and the division
        //of those two numbers.

        // my 2 numbers
        int numberOne = 10;
        int numberTwo = 2;

        // the division
        int numberSum = numberOne + numberTwo;
        int numberDiv = numberOne/numberTwo;

        Console.WriteLine(" 10 + 2 equals " + numberSum);
        Console.WriteLine(" 10 / 2 equals " + numberDiv);

        Console.ReadLine();

        // 3. Write a C# program to print the result of the specified operations:



        // 4. Write a C# program that assigns an age...

        int age = 33;
        string gender = "Apachi Helicopter";
        Console.WriteLine("You are an " + gender + "and look younger than " + age);
        Console.ReadLine();

        // 5.  Write a C# program that takes an integer representing seconds

        Console.WriteLine("Enter number of seconds:");
        int sec = 0;
        // Check if user input correct integer
        while (!int.TryParse(Console.ReadLine(), out sec))
        {
            Console.WriteLine("Your data is invalid. Please input again:");
        }

        TimeSpan t = TimeSpan.FromSeconds(sec);
        int days = t.Days;
        int years = days / 365;
        int months = days / 12;
        int hours = t.Hours;
        int minutes = t.Minutes;

        Console.WriteLine($"years= {years} , days= {days}, months= {months} , hours= {hours}, minutes={minutes}");
        Console.ReadLine();

        // 6. 

        // 7. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit

        Console.Write("Enter the amount of Celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        Console.ReadLine();


    }





}
