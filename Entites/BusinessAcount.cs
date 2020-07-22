using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHeranca.Entites
{
    class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {

        }

        public BusinessAcount(int number, string holder, double balance,double loanLimit) : base(number,holder,balance)
            
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
