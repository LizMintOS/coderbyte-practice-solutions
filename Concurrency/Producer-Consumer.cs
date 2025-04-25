using System.Collections.Generic;
using System.Linq;
using System.Threading;

var buffer = new Queue<int>();  // Shared buffer
var maxBufferSize = 5;         // Max size of the buffer
var lockObj = new object();

// For cancellation
var cts = new CancellationTokenSource();
Console.CancelKeyPress += (s, e) =>
{
    e.Cancel = true;
    cts.Cancel();
    Console.WriteLine("\nCancellation requested. Shutting down...");
};

//Producer
async Task Producer(CancellationToken token)
{
    Random rand = new();

    try
    {
        while (!token.IsCancellationRequested)
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

            await Task.Delay(1000, token);
        }
    } 
    catch (TaskCanceledException)
    {
        Console.WriteLine("Producer terminated");
        Thread.Sleep(1000);
    }
}

//Consumer
async Task Consumer(CancellationToken token)
{
    try
    {
        while (!token.IsCancellationRequested)
        {
            int item = -1;
            lock (lockObj)
            {
                while (buffer.Count == 0)
                {
                    Console.WriteLine("Buffer is empty. Consumer is waiting...");
                    Monitor.Wait(lockObj);
                }

                item = buffer.Dequeue();
                Console.WriteLine($"Consumed: {item}");

                Monitor.PulseAll(lockObj);
            }
            await Task.Delay(1500, token);
        }
    }
    catch (TaskCanceledException)
    {
        Console.WriteLine("Consumer terminated");
        Thread.Sleep(1000);
    }
}

Console.WriteLine("Starting Producer-Consumer. Press Ctrl+C to stop...");

Task producerTask = Producer(cts.Token);
Task consumerTask = Consumer(cts.Token);

await Task.WhenAll(producerTask, consumerTask);