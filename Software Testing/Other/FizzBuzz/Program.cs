using System;
using System.Runtime.Intrinsics.Arm;

public class FizzBuzz
{
    static string FizzBuzzNumb(int i)
    {
        if (i % 3 == 0)
        {
            return "Fizz";
        }
        else if (i % 5 == 0)
        {
            return "Buzz";
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            return "FizzBuzz";
        }
        else
        {
            return i.ToString();
        }
    }

    static string FizzBuzzString(int start, int end)
    {
        if (start > end)
        {
            throw new InvalidOperationException();
        }
        else if (start == end)
        {
            return start.ToString();
        }
        else
        {
            string result = "";
            for (int i = start; i <= end; i++)
            {
                result += FizzBuzzNumb(i);
            }
            return result;
        }
    }

    static string FizzBuzzStringSecond(int start, int end)
    {
        if (start > end)
        {
            throw new InvalidOperationException();
        }
        else if (start == end)
        {
            return start.ToString();
        }
        else
        {
            string result = "";
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz";
                }
                else
                {
                    result += "Whiz";
                }
            }
            return result;
        }
    }

    public static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        string FBString = FizzBuzzString(start, end);
        Console.WriteLine(FBString);
        string FBStringSecond = FizzBuzzStringSecond(start, end);
        Console.WriteLine(FBStringSecond);
    }
}