using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть два числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int t;

        if (a > b)
        {
            t = a;
            a = b;
            b = t;
        }

        Console.WriteLine(a + " " + b);
    }
}
