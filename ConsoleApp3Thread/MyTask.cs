using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Thread
{
    public class Counter
    {
        public static int Count;
    }
    public class Myclass 
    {
        public static void UpdateCount()
        {

        }
    }
    internal class MyTask
    {
        public static void TaskOne(object? p)
        {
            int num = (int)(p ?? 0);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}TaskOne.{Thread.CurrentThread.ManagedThreadId}");
            }         
        }
       
    }
}
