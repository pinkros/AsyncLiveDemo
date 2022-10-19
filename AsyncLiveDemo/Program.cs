// See https://aka.ms/new-console-template for more information

using AsyncLiveDemo;

var counter = new ParallelCounter();

counter.Start();
Console.WriteLine(Thread.CurrentThread.Name);
Console.ReadLine();
