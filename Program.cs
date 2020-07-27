using System;
using CourseHeranca.Entites;
using System.Collections.Generic;

namespace CourseHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(10, "Bianca", 451.21, 0.01));
            list.Add(new BusinessAcount(11, "Beatriz", 500, 1000));

            double sum = 0.00;

            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("O total de todas as contas eh" + sum);

        }
    }
}
