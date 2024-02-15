using static PZ_18.bankAccount; //Костылев, Неробеев 2пк2

namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(AccountType.Debit);
            account1.AccountNumber = "123456";
            account1.Deposit(5000);
            account1.Withdraw(2000);
            Console.WriteLine("");

            BankAccount account2 = new BankAccount(AccountType.Credit);
            account2.AccountNumber = "654321";
            account2.Deposit(3000);
            account2.Withdraw(5000);
            Console.WriteLine("");

            BankAccount account3 = new BankAccount();
            account3.AccountNumber = "123";
            account3.Deposit(50655);
            account3.Withdraw(3547);
            Console.WriteLine("");

            BankAccount account4 = new BankAccount(AccountType.Credit);
            account4.AccountNumber = "12345765";
            account4.Deposit(3567);
            account4.Withdraw(2334);
            Console.WriteLine("");

            BankAccount account5 = new BankAccount();
            account5.AccountNumber = "";
            account5.Deposit(3457568);
            account5.Withdraw(27654);
            Console.WriteLine("");

            BankAccount account6 = new BankAccount(AccountType.Debit);
            account6.AccountNumber = "564324";
            account6.Deposit(900);
            account6.Withdraw(100);
            Console.WriteLine("");

            BankAccount account7 = new BankAccount(AccountType.Credit);
            account7.AccountNumber = "098476";
            account7.Deposit(5000);
            account7.Withdraw(6000);
            Console.WriteLine("");

            BankAccount account8 = new BankAccount();
            account8.AccountNumber = "12";
            account8.Deposit(750);
            account8.Withdraw(150);
            Console.WriteLine("");

            BankAccount account9 = new BankAccount();
            account9.AccountNumber = "12345365";
            account9.Deposit(399);
            account9.Withdraw(2000);
            Console.WriteLine("");

            BankAccount account10 = new BankAccount(AccountType.Credit);
            account10.AccountNumber = "1234523463";
            account10.Deposit(5000);
            account10.Withdraw(3246523);
            Console.WriteLine("");

            BankAccount.ShowAccountCounts();
        }
    }
}
