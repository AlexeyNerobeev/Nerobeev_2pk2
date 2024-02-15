using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class bankAccount
    {
        public enum AccountType
        {
            Credit,
            Debit
        }

        public class BankAccount
        {
            private static int debitAccountsCount;
            private static int creditAccountsCount;

            private decimal balance;
            private string accountNumber;
            private AccountType accountType;

            public decimal Balance
            {
                get { return balance; }
            }

            public string AccountNumber
            {
                get { return accountNumber; }
                set
                {
                    if (value.Length != 6)
                    {
                        Console.WriteLine("Некорректное значение номера счета. Введите 6-значное число.");
                        return;
                    }

                    accountNumber = value;
                }
            }

            public AccountType AccountType
            {
                get { return accountType; }
                set { accountType = value; }
            }

            public static int DebitAccountsCount
            {
                get { return debitAccountsCount; }
            }

            public static int CreditAccountsCount
            {
                get { return creditAccountsCount; }
            }

            public BankAccount()
            {
                accountType = AccountType.Debit;
                debitAccountsCount++;
            }

            public BankAccount(AccountType type)
            {
                accountType = type;

                if (type == AccountType.Credit)
                    creditAccountsCount++;
                else
                    debitAccountsCount++;
            }

            public void Deposit(decimal amount)
            {
                if (amount < 1000)
                {
                    Console.WriteLine("Сумма пополнения должна быть не менее 1000 рублей.");
                    return;
                }

                balance += amount;
                Console.WriteLine("Счет {0} пополнен на сумму {1}. Баланс: {2}", accountNumber, amount, balance);
            }

            public void Withdraw(decimal amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine("Недостаточно средств на счете.");
                }
                else if (accountType == AccountType.Credit)
                {
                    balance -= amount;
                    Console.WriteLine("Счет {0} снята сумма {1}. Баланс: {2}", accountNumber, amount, balance);
                }
                else if (accountType == AccountType.Debit && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Счет {0} снята сумма {1}. Баланс: {2}", accountNumber, amount, balance);
                }
            }

            public static void ShowAccountCounts()
            {
                Console.WriteLine("Количество дебетовых счетов: {0}, количество кредитных счетов: {1}",
                    debitAccountsCount, creditAccountsCount);
            }
        }
    }
}