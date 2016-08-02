using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loans
{
    public interface IPrint
    {
        void PrintHeader();
        void PrintBody();
        void PrintTotal(int totalLent, decimal totalReturn);
    }
}
