// this file is based on
// https://github.com/OPCFoundation/UA-.NETStandard/blob/be65403945d4f0bf366f3299222fcb6cb08d6cb5/SampleApplications/Samples/Opc.Ua.Sample/Boiler/BoilerNodeManager.cs

/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Threading;
using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;
using OpcUaChatServer.Server.Application;

namespace OpcUaChatServer.Server
{
    /// <summary>
    /// A node manager for a variety of test data.
    /// </summary>
    public class ChatServerNodeManager : CustomNodeManager2
    {
        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public ChatServerNodeManager(IServerInternal server, ApplicationConfiguration configuration, ChatService chatService)
            : base(server, configuration)
        {
            // update the namespaces.
            List<string> namespaceUris = new List<string>();
            namespaceUris.Add(Namespaces.OpcUaChatServer);
            namespaceUris.Add(Namespaces.OpcUaChatServer + "/Instance");
            NamespaceUris = namespaceUris;

            m_typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

            m_lastUsedId = 0;

            // create the object used to access the system.
            m_chatService = chatService;

            // update the default context.
            SystemContext.SystemHandle = m_chatService;
        }
        #endregion

        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="node">The node.</param>
        /// <returns>The new NodeId.</returns>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            uint id = Utils.IncrementIdentifier(ref m_lastUsedId);
            return new NodeId(id, m_namespaceIndex);
        }
        #endregion

        #region INodeManager Members
        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                base.CreateAddressSpace(externalReferences);
            }
        }

        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context, "OpcUaChatServer.Server." + "OpcUa.Model.Published." + "OpcUaChatServer.PredefinedNodes.uanodes", this.GetType().GetTypeInfo().Assembly, true);
            return predefinedNodes;
        }

        /// <summary>
        /// Replaces the generic node with a node specific to the model.
        /// </summary>
        protected override NodeState AddBehaviourToPredefinedNode(ISystemContext context, NodeState predefinedNode)
        {
            BaseObjectState passiveNode = predefinedNode as BaseObjectState;

            if (passiveNode == null)
            {
                return predefinedNode;
            }

            NodeId typeId = passiveNode.TypeDefinitionId;

            if (!IsNodeIdInNamespace(typeId) || typeId.IdType != IdType.Numeric)
            {
                return predefinedNode;
            }

            switch ((uint)typeId.Identifier)
            {
                case ObjectTypes.ChatLogsType:
                    {
                        if (passiveNode is ChatLogsState)
                        {
                            break;
                        }

                        ChatLogsState activeNode = new ChatLogsState(passiveNode.Parent);
                        activeNode.Create(context, passiveNode);

                        if (passiveNode.Parent != null)
                        {
                            passiveNode.Parent.ReplaceChild(context, activeNode);
                        }

                        return activeNode;
                    }

                case ObjectTypes.ChatLogEventType:
                    {
                        if (passiveNode is ChatLogEventState)
                        {
                            break;
                        }

                        ChatLogEventState activeNode = new ChatLogEventState(passiveNode.Parent);
                        activeNode.Create(context, passiveNode);

                        if (passiveNode.Parent != null)
                        {
                            passiveNode.Parent.ReplaceChild(context, activeNode);
                        }

                        return activeNode;
                    }
            }

            return predefinedNode;
        }

        #endregion

        #region Private Fields
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;
        private long m_lastUsedId;
        private ChatService m_chatService;
        #endregion
    }
}
