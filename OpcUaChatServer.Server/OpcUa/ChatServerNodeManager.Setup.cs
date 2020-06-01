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

        private ChatLogsState m_chatLogsState;

        private void SetupNodes()
        {
            m_chatLogsState = FindPredefinedNode<ChatLogsState>(Objects.ChatLogs);

            m_chatLogsState.Post.OnCall = ChatLogsState_Post;
            m_chatService.Posted += ChatService_Posted;
            m_chatService.PostCountChanged += ChatService_PostCountChanged;
        }

        private TNodeState FindPredefinedNode<TNodeState>(uint id)
            where TNodeState : NodeState
        {
            return (TNodeState)base.FindPredefinedNode(new NodeId(id, m_typeNamespaceIndex), typeof(TNodeState));
        }

        private ServiceResult ChatLogsState_Post(ISystemContext context, MethodState method, NodeId objectId, string name, string content)
        {
            m_chatService.Post(name, content);

            return ServiceResult.Good;
        }

        private void ChatService_Posted(Application.ChatLog obj)
        {
            m_chatLogsState.ClearChangeMasks(SystemContext, true);

            if (!m_chatLogsState.AreEventsMonitored) { return; }

            // compose an event data
            var e = new ChatLogEventState(null);
            var message = new TranslationInfo(
                "ChatLogEventType",
                "en-US",
                "New chat log has been posted for '{0}'.",
                m_chatLogsState.DisplayName);
            e.Initialize(
                SystemContext,
                m_chatLogsState,
                EventSeverity.MediumLow,
                new LocalizedText(message));
            e.ChatLog = new ChatLogState(e);
            e.ChatLog.At = new BaseDataVariableState<DateTime>(e.ChatLog);
            e.ChatLog.At.Value = obj.At;
            e.ChatLog.Name = new BaseDataVariableState<string>(e.ChatLog);
            e.ChatLog.Name.Value = obj.Name;
            e.ChatLog.Content = new BaseDataVariableState<string>(e.ChatLog);
            e.ChatLog.Content.Value = obj.Content;

            m_chatLogsState.ReportEvent(SystemContext, e);
        }

        private void ChatService_PostCountChanged(uint obj)
        {
            m_chatLogsState.PostCount.Value = obj;
        }
    }
}
