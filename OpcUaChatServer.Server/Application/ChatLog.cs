using System;

namespace OpcUaChatServer.Server.Application
{
    public class ChatLog
    {
        public ChatLog(string name, string content)
        {
            At = DateTime.Now;
            Name = name;
            Content = content;
        }

        public DateTime At { get; }
        public string Name { get; }
        public string Content { get; }
    }
}
