using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace OpcUaChatServer.Server.Application
{
    [Export]
    public class ChatService
    {
        [Import]
        private Logger m_logger = null;

        public event Action<ChatLog> Posted;

        public void Post(string name, string content)
        {
            m_logger.Info($"name: {name}, content: {content}");
            Posted?.Invoke(new ChatLog(name, content));
        }
    }
}
