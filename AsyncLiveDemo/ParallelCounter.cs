using System.Threading;

namespace AsyncLiveDemo;

public class ParallelCounter
{
    public void Start()
    {
        var main = Thread.CurrentThread;
        main.Name = "main";

        var up = new Thread(CountUp);
        var down = new Thread(CountDown);

        up.Name = "up";
        down.Name = "down";

        Console.WriteLine("starting count up");
        up.Start();
        Console.WriteLine("starting count down");
        down.Start();
        Console.WriteLine("done");
    }
    public void CountUp()
    {
        var thread = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(200);
            Console.WriteLine($"Thread: {thread.Name} CountUp: {i}");
            
        }
    }

    public void CountDown()
    {
        var thread = Thread.CurrentThread;

        for (int i = 9; i >= 0; i--)
        {
            Thread.Sleep(200);
            Console.WriteLine($"Thread: {thread.Name} CountDown: {i}");

        }
    }
}