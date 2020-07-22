using System;
using CourseHeranca.Entites;

namespace CourseHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAcount account = new BusinessAcount(8010, "Bianca Sales", 200.54, 500);
            Console.WriteLine(account.Balance);
        }
    }
}
