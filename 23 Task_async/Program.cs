using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Task_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Sum(n);
           Console.ReadKey();
        }

        static void Sum(int n)
        {
            int s = 1;
            for (int i = 0; i < n; i++)
            {
                s *= i;
                Thread.Sleep(10);  
            }
            Console.WriteLine(s);
            
        }

        static async void SumAsync(int n)
        {
            await Task.Run(()=>Sum(n));
        }

        //Console.ReadKey();
    }
}
