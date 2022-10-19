using System.Threading;

namespace AsyncLiveDemo;

public class AsyncCounter
{
    public async Task Start()
    {
        Console.WriteLine("starting count up");
        CountUp();
        Console.WriteLine("starting count down");
        CountDown();
        Console.WriteLine("done");
    }

    public async Task CountUp()
    {
        var thread = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(200);
            Console.WriteLine($"Thread: {thread.ManagedThreadId} CountUp: {i}");
        }
    }

    public async Task CountDown()
    {
        var thread = Thread.CurrentThread;
        for (int i = 9; i >= 0; i--)
        {
            await Task.Delay(200);
            Console.WriteLine($"Thread: {thread.ManagedThreadId} CountDown: {i}");
        }
    }
}