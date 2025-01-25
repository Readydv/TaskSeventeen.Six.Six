using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSeventeen.Six.Six
{
    public static class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            if (account is Account acc)
            {
                acc.Interest = acc.CalculateInterest();
            }
        }
    }
}
