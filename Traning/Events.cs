using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public class Events
    {
    }
    //public class NumOperations
    //{
    //    public delegate int AccHadler(int x, int y);
    //    public event AccHadler? Notification;

    //    public int sum;
    //    public int sub;

    //    public int Sum(int x, int y)
    //    {
    //        sum = x + y;
    //        Notification?.Invoke($"Произошло сложение чисел: ");
    //        return sum;
    //    }
    //    public int Sub(int x, int y)
    //    {
    //        sub = x - y;
    //        Console.WriteLine($"Произошло вычитание чисел:");
    //        return sum;
    //    }
    //}
    public class AccountEv
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;              // 1.Определение события
        public AccountEv(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 3.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }

        public void DisplayMessage(string message) => Console.WriteLine(message);
    }
}
