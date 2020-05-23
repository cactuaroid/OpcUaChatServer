using System;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;

namespace OpcUaChatServer.Server
{
    public class ChatServer
    {
        [Import]
        private Logger m_logger = null;

        public ChatServer()
        {
            MefManager.Container.ComposeParts(this);
        }

        public async Task Run()
        {
            m_logger.Info("ChatServer starts.");

            await Task.Delay(Timeout.InfiniteTimeSpan); // place holder
        }
    }
}
