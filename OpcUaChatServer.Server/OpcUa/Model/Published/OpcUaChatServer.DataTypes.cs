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
    #region ChatLog Class
    #if (!OPCUA_EXCLUDE_ChatLog)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = OpcUaChatServer.Namespaces.OpcUaChatServer)]
    public partial class ChatLog : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ChatLog()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_at = DateTime.MinValue;
            m_name = null;
            m_content = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "At", IsRequired = false, Order = 1)]
        public DateTime At
        {
            get { return m_at;  }
            set { m_at = value; }
        }

        /// <remarks />
        [DataMember(Name = "Name", IsRequired = false, Order = 2)]
        public string Name
        {
            get { return m_name;  }
            set { m_name = value; }
        }

        /// <remarks />
        [DataMember(Name = "Content", IsRequired = false, Order = 3)]
        public string Content
        {
            get { return m_content;  }
            set { m_content = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ChatLog; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ChatLog_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ChatLog_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ChatLog_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(OpcUaChatServer.Namespaces.OpcUaChatServer);

            encoder.WriteDateTime("At", At);
            encoder.WriteString("Name", Name);
            encoder.WriteString("Content", Content);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(OpcUaChatServer.Namespaces.OpcUaChatServer);

            At = decoder.ReadDateTime("At");
            Name = decoder.ReadString("Name");
            Content = decoder.ReadString("Content");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ChatLog value = encodeable as ChatLog;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_at, value.m_at)) return false;
            if (!Utils.IsEqual(m_name, value.m_name)) return false;
            if (!Utils.IsEqual(m_content, value.m_content)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ChatLog)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ChatLog clone = (ChatLog)base.MemberwiseClone();

            clone.m_at = (DateTime)Utils.Clone(this.m_at);
            clone.m_name = (string)Utils.Clone(this.m_name);
            clone.m_content = (string)Utils.Clone(this.m_content);

            return clone;
        }
        #endregion

        #region Private Fields
        private DateTime m_at;
        private string m_name;
        private string m_content;
        #endregion
    }

    #region ChatLogCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfChatLog", Namespace = OpcUaChatServer.Namespaces.OpcUaChatServer, ItemName = "ChatLog")]
    #if !NET_STANDARD
    public partial class ChatLogCollection : List<ChatLog>, ICloneable
    #else
    public partial class ChatLogCollection : List<ChatLog>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ChatLogCollection() {}

        /// <remarks />
        public ChatLogCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ChatLogCollection(IEnumerable<ChatLog> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ChatLogCollection(ChatLog[] values)
        {
            if (values != null)
            {
                return new ChatLogCollection(values);
            }

            return new ChatLogCollection();
        }

        /// <remarks />
        public static explicit operator ChatLog[](ChatLogCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ChatLogCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ChatLogCollection clone = new ChatLogCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ChatLog)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}