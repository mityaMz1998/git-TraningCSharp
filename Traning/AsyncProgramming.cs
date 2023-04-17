using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    class AsyncProgramming
    {
        public void StringOutput()
        {
            Console.WriteLine("Здравствуйте всем!");
        }
        public async Task StringOutputAsync()
        {
            await Task.Run(StringOutput);
            Console.WriteLine("Привет всем!");
        }
        public async Task<int> IntOutputAsync(int x, int y)
        {
            await Task.Delay(100);
            int sum = x + y;
            return sum;
        }
        public async Task SumOutputAsync(int x)
        {
            await Task.Delay(1000);
            Console.WriteLine(x);
        }
        public async void SumOutputAsync1(int x)
        {
            await Task.Delay(1000);
            Console.WriteLine(x);
        }
        public void PrintName(string name)
        {
            Thread.Sleep(3000);
            Console.WriteLine(name);
        }
        public async Task PrintNameAsync(string name)
        {
            await Task.Delay(3000);
            Console.WriteLine(name);
        }
        public async IAsyncEnumerable<string> GetStringsAsync()
        {
            List<string> strings = new List<string>() {"aaa","bbb","ccc","ddd","eee"};
            foreach (string s in strings) 
            {
                await Task.Delay(0);
                yield return s;
            }
        }
    }
}
