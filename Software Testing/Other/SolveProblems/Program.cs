using System;
class Program
{
    //Operations:
    static double addition (double a, double b)
    {
        return a + b;
    }
    static double substraction (double a, double b)
    {
        return a - b;
    }
    static double multiplication (double a, double b)
    {
        return a * b;
    }
    static double division (double a, double b)
    {
        if (a == 0 && b == 0)
        {
            throw new ArithmeticException();
        }
        if (b == 0)
        {
            throw new ArithmeticException();
        }
        return a / b;
    }

    //Finding num and solving
    static public Tuple<string, string, string> GetNumAndOper(string a)
    {
        string curNum1 = "";
        string oper = "";
        string curNum2 = "";
        int i = 0;

        // Proverki:
        if (!Char.IsDigit(a[0]))
            {
                throw new ArgumentOutOfRangeException();
            }
        for (; i < a.Length; i++)
        {
             if (Char.IsLetter(a[i]))
              {
                  throw new ArgumentOutOfRangeException();
              }
        }

        //Namirane na chislata i oper;
        i = 0;
        while (Char.IsDigit(a[i]))
            {
                curNum1 += a[i];
                a = a.Remove(i, 1);
            }

            if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/')
            {
                oper = a[i].ToString();
                a = a.Remove(i, 1);
            a += " ";
            }

            while (Char.IsDigit(a[i]))
            {
                curNum2 += a[i];
                a = a.Remove(i, 1);
            }

        return Tuple.Create(curNum1, oper, curNum2);
    }
    static double solve (Tuple<string, string, string> tuple)
    {
        double n1 = Double.Parse(tuple.Item1);
        string op = tuple.Item2;
        double n3 = Double.Parse(tuple.Item3);
        double res;

        if (op == "+")
        {
            res = addition(n1, n3);
        }
        else if (op == "-")
        {
            res = substraction(n1, n3);
        }
        else if (op == "*")
        {
            res = multiplication(n1, n3);
        }
        else
        {
            res = substraction(n1, n3);
        }

        return res;
    }

    static void Main(string[] arg)
    {
        string s = Console.ReadLine();
        double res = solve(GetNumAndOper(s));
        Console.WriteLine(res);
    }
}