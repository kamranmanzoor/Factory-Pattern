using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loans
{
    public class Print : IPrint
    {
        private Loans _loans;

        public Print(Loans loans) 
        {
            _loans = loans;
        }

        public void PrintHeader()
        {
            Console.WriteLine("{0}{1,10}{2,20}","CustomerId","Amount","IntrestRate");
            Console.WriteLine("\n");
        }

        public void PrintBody()
        {
            foreach (var loan in _loans.loans)
            {
                Console.WriteLine("{0}{1,15}{2,20}",loan.CustomerId, loan.Amount, loan.InterestRate);
                Console.WriteLine("\n");
            }            
        }

        public void PrintTotal(int totalLent, decimal totalReturn)
        {
            Console.WriteLine("Total Lent :   " + totalLent);
            Console.WriteLine("\n");
            Console.WriteLine("Total Return :   " + totalReturn);

        }
    }
}
