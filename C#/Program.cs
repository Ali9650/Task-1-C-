

using System;
using System.Diagnostics.CodeAnalysis;

namespace alisnamespace;

class program
{
    static void Main(string[] args)
    {
        //MultiplyofTwoNumbers(1, 3);
        //TheSquareofTheNumber(6);
        //int[] arr = { 50, 100, 200 };
        //CheckNumbers(arr);
        //string Welcome = PrintWelcomeMessage("Ali", "Cahangirov");
        //Console.WriteLine(Welcome);
        //string word = "Alik";
        //Console.WriteLine(ReversedWord(word));
        //int a = 24;
        //TheDivisorofNumber(a);
        //int sum = FindPerimetr(3, 4, 10);
        //Console.WriteLine(sum);

        //int sum = FindPerimetr(10);
        //Console.WriteLine(sum);
0
        //string word = "Xos gelmisiz";
        //StringSentence(word);
    }
    public static void MultiplyofTwoNumbers(int num1, int num2)
    {
        Console.WriteLine(num1 * num2);
    }
    public static void TheSquareofTheNumber(int num)
    {
        Console.WriteLine(num * num);
    }
    public static void CheckNumbers(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum = sum + num[i];
        }
        Console.WriteLine(sum);
    }
    public static string PrintWelcomeMessage (string name, string surname)
    {
       return $"Xos gelmisen, {name} {surname}";
    }
    public static string ReversedWord (string word)
    {
        string ReversedWord = string.Empty;
        for (int i=word.Length - 1; i >= 0; i--)
        {
            ReversedWord += word[i];
            
        }
        return ReversedWord;
    }
    public static void TheDivisorofNumber(int num)
    {
        if (num % 7 == 0)
        {
            Console.WriteLine("7-e bolunur");
        }
        else
        {
            num = num / 7;
            num = num* 7;
            Console.WriteLine(num);
        }
    }
    public static int FindPerimetr (int a, int b, int c)
    {
        return a + b + c;
    }

    public static int FindPerimetr (int a)
    {
        return 4 * a;
    }
    public static void StringSentence(string word)
    {
        int k = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ')
            {
                k++;
                Console.WriteLine(k);
            }
        }
    }
}


