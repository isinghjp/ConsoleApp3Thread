// See https://aka.ms/new-console-template for more information
using ConsoleApp3Thread;

Thread[] threads = new Thread[10];
for (int a = 0; a < 10; a++)
{
    threads[a] = new Thread(new ThreadStart(Myclass.UpdateCount));
    threads[a].Start();
}

for (int a = 0; a < 10; a++)
{
       threads[a].Join();
}

Console.WriteLine($"Thread name: {Thread.CurrentThread.ManagedThreadId}");
Console.ReadLine();

