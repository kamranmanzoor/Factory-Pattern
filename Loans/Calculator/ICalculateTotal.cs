using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loans
{
    public interface ICalculateTotal
    {
        int GetTotalLent();
        decimal GetTotalReturn();        
    }
}
