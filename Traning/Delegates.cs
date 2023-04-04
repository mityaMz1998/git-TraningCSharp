using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    public delegate int Operation(int x, int y);
    delegate double OperationDivision(double x, int y);
    delegate void Message();
    delegate void OperationVoid(int x, int y);
    public class Delegates
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;

        public double Division (double x, int y) => x / y;

        public void Hello() => Console.WriteLine("Hello");
        public void HowAreYou() => Console.WriteLine("How are you?");

        public void AddVoid(int x, int y) => Console.WriteLine(x + y);
        public void SubstractVoid(int x, int y) => Console.WriteLine(x - y);
        public void MultiplyVoid(int x, int y) => Console.WriteLine(x * y);

        public void DoOperation(int x, int y, Operation o) => Console.WriteLine(o(x, y));
    }

    public delegate void AccountHandler(string message);
    public class Account
    {
        int sum;
        // Создаем переменную делегата
        AccountHandler? taken;
        public Account(int sum) => this.sum = sum;
        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken = del;
        }
        //public void Add(int sum) => this.sum += sum;
        public void Put(int sum)
        {
            this.sum += sum;
            taken?.Invoke($"На счет добавлено {sum} y.e");
        }
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                // вызываем делегат, передавая ему сообщение
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
            }
        }
        public void PrintSimpleMessage(string message) => Console.WriteLine(message);
    }
}
