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
        public event Action<uint> PostCountChanged;

        public void Post(string name, string content)
        {
            m_logger.Info($"name: {name}, content: {content}");
            Posted?.Invoke(new ChatLog(name, content));
            PostCount++;
        }

        public uint PostCount
        {
            get => m_postCount;
            set
            {
                m_postCount = value;
                PostCountChanged?.Invoke(m_postCount);
            }
        }
        private uint m_postCount;
    }
}
