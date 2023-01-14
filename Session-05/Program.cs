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




        int num, i, ctr, stno, enno;

        Console.Write("\n\n");
        Console.Write("Find the prime numbers within a range of numbers:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input starting number of range: ");
        stno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input ending number of range : ");
        enno = Convert.ToInt32(Console.ReadLine());
        Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

        for (num = stno; num <= enno; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
        Console.ReadLine() ;



















    }
 }