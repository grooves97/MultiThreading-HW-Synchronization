using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankUser = new BankAccount()
            {
                Sum = 10000
            };

            var threads = new Thread[40];


            for (int i = 0, j = 39; i < 20; i++, j--)
            {
                var threadIncome = new Thread(bankUser.IncreaseBalance);
                var threadSpend = new Thread(bankUser.DecreaseBalance);
                threadIncome.Name = $"Номер потока - {threadIncome.ManagedThreadId}";
                threadSpend.Name = $"Номер потока - {threadSpend.ManagedThreadId}";
                threads[i] = threadIncome;
                threads[j] = threadSpend;
            }

            foreach (var thread in threads)
            {
                thread.Start(new Random().Next(1000));
            }
            Console.ReadLine();
        }
    }
}
