using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _Rybushkin_4232
{
    internal class Program
    {
        class Range
        {
            private int first;
            private int second;
            public bool rangecheck(int value, int value2)
            {
                return value >= first && value <= second;
            }
            static void Main(string[] args)
            {

            }
        }
    }
}

static class Rational
{
    static private int numerator;
    static private int denominator;

    static void Read()
    {
        Console.Write("Введите числитель a (numerator): ");
        numerator = int.Parse(Console.ReadLine());

        Console.Write("Введите знаменатель b (denominator): ");
        denominator = int.Parse(Console.ReadLine());
    }

    static int Addition(int x, int y)
    {
        return numerator / denominator + x;
    }

    static int Subtraction(int x, int y)
    {
        return numerator / denominator - x;
    }

    static int Multiplication(int x, int y)
    {
        return numerator / denominator * x;
    }

    static int Divide(int x, int y)
    {
        return numerator / denominator / x;
    }

    static void Main(string[] args)
    {
        Read();
        int result1 = Addition(5, 7);
        int result2 = Subtraction(5, 7);
        int result3 = Divide(5, 7);
        int result4 = Multiplication(5, 7);

        Console.WriteLine($"Сложение: {result1}");
        Console.WriteLine($"Вычитание: {result2}");
        Console.WriteLine($"Деление: {result3}");
        Console.WriteLine($"Умножение: {result4}");
    }


}

