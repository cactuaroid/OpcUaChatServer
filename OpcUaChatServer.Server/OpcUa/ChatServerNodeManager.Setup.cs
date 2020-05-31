using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using Opc.Ua;
using OpcUaChatServer.Server.Application;

namespace OpcUaChatServer.Server
{
    public partial class ChatServerNodeManager
    {
        [Import]
        private ChatService m_chatService = null;

        private void SetupNodes()
        {
            var chatLogsState = FindPredefinedNode<ChatLogsState>(Objects.ChatLogs);
            chatLogsState.Post.OnCall = Post;
        }

        private TNodeState FindPredefinedNode<TNodeState>(uint id)
            where TNodeState : NodeState
        {
            return (TNodeState)base.FindPredefinedNode(new NodeId(id, m_typeNamespaceIndex), typeof(TNodeState));
        }

        private ServiceResult Post(ISystemContext context, MethodState method, NodeId objectId, string name, string content)
        {
            m_chatService.Post(name, content);

            return ServiceResult.Good;
        }
    }
}
