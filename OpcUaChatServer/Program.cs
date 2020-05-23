using System;

namespace OpcUaChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat server is starting. Press 'Esc' to exit.");

            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
