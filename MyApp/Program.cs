// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        DateTime begin = new DateTime(2019, 1, 1);
        DateTime end = new DateTime(2019, 1, 31);
        int daysBetween = CalculateDaysBetweenDates(begin, end);
        Console.WriteLine("天数: " + daysBetween);
    }

    static int CalculateDaysBetweenDates(DateTime begin, DateTime end)
    {
        return (end - begin).Days;
    }
}