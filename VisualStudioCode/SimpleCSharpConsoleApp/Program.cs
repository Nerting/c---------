
using System;
using System.Linq;

class Program
{
    static void Main()
    {
          var numbers = new[] { 5, 1, 9, 3, 7 };
        var sorted = numbers.OrderByDescending(n => n);
        Console.WriteLine("По убыванию: " + string.Join(", ", sorted));
    }
}

/* 13 ЗАДАНИЕ 
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new[] { 10, 30, 20, 50, 40 };
        var min = numbers.Min();
        Console.WriteLine("Минимум: " + min);
    }
}
*/