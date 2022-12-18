/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUaChatServer
{
    #region ChatLogsState Class
    #if (!OPCUA_EXCLUDE_ChatLogsState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogsState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ChatLogsState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.ObjectTypes.ChatLogsType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////hGCA" +
           "AgEAAAABABQAAABDaGF0TG9nc1R5cGVJbnN0YW5jZQEBAQABAQEAAQAAAAH/////AgAAAARhggoEAAAA" +
           "AQAEAAAAUG9zdAEBAgAALwEBAgACAAAAAQEBAAAAAQD5CwABAQcAAQAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAQMAAC4ARAMAAACWAgAAAAEAKgEBEwAAAAQAAABOYW1lAAz/////AAAAAAABACoB" +
           "ARYAAAAHAAAAQ29udGVudAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEACQAAAFBvc3RDb3VudAEBBAAALwA/BAAAAAAH/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PostMethodState Post
        {
            get
            {
                return m_postMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_postMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_postMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> PostCount
        {
            get
            {
                return m_postCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_postCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_postCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_postMethod != null)
            {
                children.Add(m_postMethod);
            }

            if (m_postCount != null)
            {
                children.Add(m_postCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OpcUaChatServer.BrowseNames.Post:
                {
                    if (createOrReplace)
                    {
                        if (Post == null)
                        {
                            if (replacement == null)
                            {
                                Post = new PostMethodState(this);
                            }
                            else
                            {
                                Post = (PostMethodState)replacement;
                            }
                        }
                    }

                    instance = Post;
                    break;
                }

                case OpcUaChatServer.BrowseNames.PostCount:
                {
                    if (createOrReplace)
                    {
                        if (PostCount == null)
                        {
                            if (replacement == null)
                            {
                                PostCount = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                PostCount = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = PostCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PostMethodState m_postMethod;
        private BaseDataVariableState<uint> m_postCount;
        #endregion
    }
    #endif
    #endregion

    #region PostMethodState Class
    #if (!OPCUA_EXCLUDE_PostMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PostMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public PostMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new PostMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////BGGC" +
           "CgQAAAABAA4AAABQb3N0TWV0aG9kVHlwZQEBBQAALwEBBQAFAAAAAQEBAAAAAQD5CwABAQcAAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQYAAC4ARAYAAACWAgAAAAEAKgEBEwAAAAQAAABOYW1l" +
           "AAz/////AAAAAAABACoBARYAAAAHAAAAQ29udGVudAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public PostMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string name = (string)_inputArguments[0];
            string content = (string)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    name,
                    content);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult PostMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string name,
        string content);
    #endif
    #endregion

    #region ChatLogEventState Class
    #if (!OPCUA_EXCLUDE_ChatLogEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogEventState : BaseEventState
    {
        #region Constructors
        /// <remarks />
        public ChatLogEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.ObjectTypes.ChatLogEventType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////BGCA" +
           "AgEAAAABABgAAABDaGF0TG9nRXZlbnRUeXBlSW5zdGFuY2UBAQcAAQEHAAcAAAD/////CQAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBCAAALgBECAAAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBCQAALgBECQAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AQoAAC4ARAoAAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQELAAAuAEQL" +
           "AAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBDAAALgBEDAAAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQ0AAC4ARA0AAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAQ8AAC4ARA8AAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBEAAALgBEEAAAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAENoYXRM" +
           "b2cBAREAAC4BARIAEQAAAAEBEwD/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ChatLogState ChatLog
        {
            get
            {
                return m_chatLog;
            }

            set
            {
                if (!Object.ReferenceEquals(m_chatLog, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_chatLog = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_chatLog != null)
            {
                children.Add(m_chatLog);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OpcUaChatServer.BrowseNames.ChatLog:
                {
                    if (createOrReplace)
                    {
                        if (ChatLog == null)
                        {
                            if (replacement == null)
                            {
                                ChatLog = new ChatLogState(this);
                            }
                            else
                            {
                                ChatLog = (ChatLogState)replacement;
                            }
                        }
                    }

                    instance = ChatLog;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ChatLogState m_chatLog;
        #endregion
    }
    #endif
    #endregion

    #region ChatLogState Class
    #if (!OPCUA_EXCLUDE_ChatLogState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogState : BaseDataVariableState<ChatLog>
    {
        #region Constructors
        /// <remarks />
        public ChatLogState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.VariableTypes.ChatLogType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.DataTypes.ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////FWCJ" +
           "AgIAAAABABMAAABDaGF0TG9nVHlwZUluc3RhbmNlAQESAAEBEgASAAAAAQETAP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}