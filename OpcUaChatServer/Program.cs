using OpcUaChatServer.Server;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OpcUaChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat server is starting. Press 'Esc' to exit.");

            using var cts = new CancellationTokenSource();
            var server = new ChatServer();
            var serverTask = Task.Run(() => server.Run(cts.Token));

            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            cts.Cancel();
            serverTask.Wait();
        }
    }
}
