using OpcUaChatServer.Server;
using System;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;

namespace OpcUaChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat server is starting. Press any key to exit.");

            MefManager.Initialize();
            MefManager.Container.GetExportedValue<Logger>().Logged += (x) => Console.WriteLine(x);

            var server = new ChatServer();
            var serverTask = Task.Run(() => server.Run());

            Console.ReadKey();
        }
    }
}
