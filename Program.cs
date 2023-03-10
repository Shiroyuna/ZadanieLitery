using System;

class ZadanieLitery
{
    static void Main(string[] args)
    {
        int count = 0;
        for (int i = 1; i <= 1000; i++)
        {
            count += GetCount(i);
        }
        Console.WriteLine("Wszystkie litery znajdujące się w słownym zapisie " +
            "liczb od 1 do 1000 w języku angielskim: " + count);
    }

    static int GetCount(int n)
    {
        string word = "";

        if (n == 1000)
        {
            return "onethousand".Length;
        }

        if (n >= 100)
        {
            word += GetDigitName(n / 100) + "hundred";
            if (n % 100 != 0)
            {
                word += "and";
            }
            n %= 100;
        }

        if (n >= 10 && n < 20)
        {
            word += GetTeenName(n);
        }
        else
        {
            if (n >= 20)
            {
                word += GetTensName(n / 10);
                n %= 10;
            }
            if (n > 0)
            {
                word += GetDigitName(n);
            }
        }
        return word.Length;
    }

    static string GetDigitName(int n)
    {
        switch (n)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

    static string GetTeenName(int n)
    {
        switch (n)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    static string GetTensName(int n)
    {
        switch (n)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}