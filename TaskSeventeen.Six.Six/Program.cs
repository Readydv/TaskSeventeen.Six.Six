using System;

namespace TaskSeventeen.Six.Six
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем обычный аккаунт
            Account ordinaryAccount = new Account
            {
                Type = "Обычный",
                Balance = 800 // Пример баланса
            };

            // Создаем зарплатный аккаунт
            Account salaryAccount = new Account
            {
                Type = "Зарплатный",
                Balance = 1500 // Пример баланса
            };

            // Рассчитываем процентные ставки
            Calculator.CalculateInterest(ordinaryAccount);
            Calculator.CalculateInterest(salaryAccount);

            // Выводим результаты
            Console.WriteLine($"Обычный аккаунт: Баланс = {ordinaryAccount.Balance}, Процентная ставка = {ordinaryAccount.Interest}");
            Console.WriteLine($"Зарплатный аккаунт: Баланс = {salaryAccount.Balance}, Процентная ставка = {salaryAccount.Interest}");
        }
    }
}