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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUaChatServer
{
    #region ChatLogsState Class
    #if (!OPCUA_EXCLUDE_ChatLogsState)
    /// <summary>
    /// Stores an instance of the ChatLogsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogsState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChatLogsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.ObjectTypes.ChatLogsType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////hGCA" +
           "AgEAAAABABQAAABDaGF0TG9nc1R5cGVJbnN0YW5jZQEBwToBAcE6wToAAAH/////AgAAAARhggoEAAAA" +
           "AQAEAAAAUG9zdAEBmToALwEBmTqZOgAAAQEBAAAAAQD5CwABAcQ6AQAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAZo6AC4ARJo6AACWAgAAAAEAKgEBEwAAAAQAAABOYW1lAAz/////AAAAAAABACoB" +
           "ARYAAAAHAAAAQ29udGVudAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEACQAAAFBvc3RDb3VudAEBoToALwA/oToAAAAH/////wEB/////wAAAAA=";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the PostMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PostMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PostMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new PostMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////BGGC" +
           "CgQAAAABAA4AAABQb3N0TWV0aG9kVHlwZQEBnToALwEBnTqdOgAAAQEBAAAAAQD5CwABAcQ6AQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZ46AC4ARJ46AACWAgAAAAEAKgEBEwAAAAQAAABOYW1l" +
           "AAz/////AAAAAAABACoBARYAAAAHAAAAQ29udGVudAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public PostMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
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

            ServiceResult result = null;

            string name = (string)_inputArguments[0];
            string content = (string)_inputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    name,
                    content);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult PostMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string name,
        string content);
    #endif
    #endregion

    #region ChatLogEventState Class
    #if (!OPCUA_EXCLUDE_ChatLogEventState)
    /// <summary>
    /// Stores an instance of the ChatLogEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogEventState : BaseEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChatLogEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.ObjectTypes.ChatLogEventType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////BGCA" +
           "AgEAAAABABgAAABDaGF0TG9nRXZlbnRUeXBlSW5zdGFuY2UBAcQ6AQHEOsQ6AAD/////CQAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBxToALgBExToAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBxjoALgBExjoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "Acc6AC4ARMc6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHJOgAuAETJ" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEByjoALgBEyjoAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAcs6AC4ARMs6AAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAc06AC4ARM06AAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBzjoALgBEzjoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAENoYXRM" +
           "b2cBAc86AC4BAeI6zzoAAAEB5jr/////AQH/////AAAAAA==";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the ChatLogType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChatLogState : BaseDataVariableState<ChatLog>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChatLogState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.VariableTypes.ChatLogType, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUaChatServer.DataTypes.ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwczovL2dpdGh1Yi5jb20vY2FjdHVhcm9pZC9PcGNVYUNoYXRTZXJ2ZXL/////FWCJ" +
           "AgIAAAABABMAAABDaGF0TG9nVHlwZUluc3RhbmNlAQHiOgEB4jriOgAAAQHmOv////8BAf////8AAAAA";
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