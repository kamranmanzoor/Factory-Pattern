using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loans
{
    public class CalculateTotal : ICalculateTotal
    {
        private Loans _loans;

        public CalculateTotal(Loans loans)
        {
            _loans = loans;
        }

        public int GetTotalLent()
        {
            return _loans.loans.Sum(x => Convert.ToInt32(x.Amount));
        }

        public decimal GetTotalReturn()
        {
            decimal totalReturn = 0;

            foreach (var loan in _loans.loans)
            {
                var percentIncrease = (Convert.ToInt32(loan.InterestRate) * Convert.ToInt32(loan.Amount))/100;

                totalReturn = totalReturn + Convert.ToDecimal(loan.Amount) + Convert.ToDecimal(percentIncrease);
            }

            return totalReturn;
        }
    }
}
