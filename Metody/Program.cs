using System;

namespace Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.FirstName = "Bill";


            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            //Console.WriteLine($"{bill.FirstName} {bill.GetDateOfBirth()}");

            bill.SayHi();

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");

            john.SayHi();
        }
    }
}
