using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public decimal Sum { get; set; }
        public void IncreaseBalance(object income)
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine(currentThread.Name + " начал свою работу");
            Sum += decimal.Parse(income.ToString());
            Thread.Sleep(5 * new Random().Next(100));
            Console.WriteLine(Sum);
        }
        public void DecreaseBalance(object expenditure)
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine(currentThread.Name + " начал свою работу");
            Sum -= decimal.Parse(expenditure.ToString());
            Thread.Sleep(5 * new Random().Next(100));
            Console.WriteLine(Sum);
        }
    }
}
