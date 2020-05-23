using System;
using System.Threading;
using System.Threading.Tasks;

namespace OpcUaChatServer.Server
{
    public class ChatServer
    {
        public void Run(CancellationToken token)
        {
            token.WaitHandle.WaitOne();
        }
    }
}
