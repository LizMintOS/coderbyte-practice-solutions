using System.Collections.Generic;
using System.Linq;
using System.Threading;

var buffer = new Queue<int>();  // Shared buffer
var maxBufferSize = 5;         // Max size of the buffer
var lockObj = new object();

//Producer
await Task.Run(() =>
{
    Random rand = new();
    while (true)
    {
        lock (lockObj)
        {
            while (buffer.Count == maxBufferSize)
            {
                Console.WriteLine("Buffer is full. Producer is waiting...");
                Monitor.Wait(lockObj);
            }

            int item = rand.Next(1, 100);
            buffer.Enqueue(item);
            Console.WriteLine($"Produced: {item}");

            Monitor.PulseAll(lockObj);
        }
        Thread.Sleep(1000);
    }
});

//Consumer
await Task.Run(() =>
{
    while (true)
    {
        lock (lockObj)
        {
            while (buffer.Count == 0)
            {
                Console.WriteLine("Buffer is empty. Consumer is waiting...");
                Monitor.Wait(lockObj);
            }

            int item = buffer.Dequeue();
            Console.WriteLine($"Consumed: {item}");

            Monitor.PulseAll(lockObj);
        }
        Thread.Sleep(1500);
    }
});

Console.ReadLine();