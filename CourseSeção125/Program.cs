using CourseSeção125.Entities;
using System;

namespace CourseSeção125
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "rawann", 100.0, 500.0);
            Console.WriteLine(account.Balance);

        }
    }
}
