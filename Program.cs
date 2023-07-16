using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Linq
{
    static void Main(string[] args)
    {
        string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Console.Write("\nDays of a week : \n");

        var days = from WeekDay in dayWeek
                   select WeekDay;

        foreach (var WeekDay in days)
        {
            Console.WriteLine(WeekDay);
        }
        Console.WriteLine();
    }
}
