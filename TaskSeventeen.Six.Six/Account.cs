using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSeventeen.Six.Six
{
    public class Account : IAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public double CalculateInterest()
        {
            switch (Type)
            {
                case "Обычный":
                    return CalculateOrdinaryInterest();
                case "Зарплатный":
                    return CalculateSalaryInterest();
                    default:
                    throw new NotSupportedException($"Тип аккаунта {Type} не поддерживается.");
            }
        }
        private double CalculateOrdinaryInterest()
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;

            if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }

        private double CalculateSalaryInterest()
        {
            return Balance * 0.5;
        }
    }
}
