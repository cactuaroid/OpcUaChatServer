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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUaChatServer
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint ChatLog = 19;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint ChatLogsType_Post = 2;

        /// <remarks />
        public const uint ChatLogs_Post = 21;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint ChatLogs = 20;

        /// <remarks />
        public const uint ChatLog_Encoding_DefaultBinary = 24;

        /// <remarks />
        public const uint ChatLog_Encoding_DefaultXml = 32;

        /// <remarks />
        public const uint ChatLog_Encoding_DefaultJson = 40;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint ChatLogsType = 1;

        /// <remarks />
        public const uint ChatLogEventType = 7;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint ChatLogsType_Post_InputArguments = 3;

        /// <remarks />
        public const uint ChatLogsType_PostCount = 4;

        /// <remarks />
        public const uint ChatLogEventType_ChatLog = 17;

        /// <remarks />
        public const uint ChatLogs_Post_InputArguments = 22;

        /// <remarks />
        public const uint ChatLogs_PostCount = 23;

        /// <remarks />
        public const uint OpcUaChatServer_BinarySchema = 25;

        /// <remarks />
        public const uint OpcUaChatServer_BinarySchema_NamespaceUri = 27;

        /// <remarks />
        public const uint OpcUaChatServer_BinarySchema_Deprecated = 28;

        /// <remarks />
        public const uint OpcUaChatServer_BinarySchema_ChatLog = 29;

        /// <remarks />
        public const uint OpcUaChatServer_XmlSchema = 33;

        /// <remarks />
        public const uint OpcUaChatServer_XmlSchema_NamespaceUri = 35;

        /// <remarks />
        public const uint OpcUaChatServer_XmlSchema_Deprecated = 36;

        /// <remarks />
        public const uint OpcUaChatServer_XmlSchema_ChatLog = 37;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint ChatLogType = 18;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLog = new ExpandedNodeId(OpcUaChatServer.DataTypes.ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLogsType_Post = new ExpandedNodeId(OpcUaChatServer.Methods.ChatLogsType_Post, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogs_Post = new ExpandedNodeId(OpcUaChatServer.Methods.ChatLogs_Post, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLogs = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLogs, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultBinary = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultBinary, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultXml = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultXml, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultJson = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultJson, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLogsType = new ExpandedNodeId(OpcUaChatServer.ObjectTypes.ChatLogsType, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogEventType = new ExpandedNodeId(OpcUaChatServer.ObjectTypes.ChatLogEventType, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLogsType_Post_InputArguments = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogsType_Post_InputArguments, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogsType_PostCount = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogsType_PostCount, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogEventType_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogEventType_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogs_Post_InputArguments = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogs_Post_InputArguments, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChatLogs_PostCount = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogs_PostCount, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_NamespaceUri = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_NamespaceUri, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_Deprecated = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_Deprecated, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_NamespaceUri = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_NamespaceUri, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_Deprecated = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_Deprecated, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ChatLogType = new ExpandedNodeId(OpcUaChatServer.VariableTypes.ChatLogType, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string ChatLog = "ChatLog";

        /// <remarks />
        public const string ChatLogEventType = "ChatLogEventType";

        /// <remarks />
        public const string ChatLogs = "ChatLogs";

        /// <remarks />
        public const string ChatLogsType = "ChatLogsType";

        /// <remarks />
        public const string ChatLogType = "ChatLogType";

        /// <remarks />
        public const string OpcUaChatServer_BinarySchema = "OpcUaChatServer";

        /// <remarks />
        public const string OpcUaChatServer_XmlSchema = "OpcUaChatServer";

        /// <remarks />
        public const string Post = "Post";

        /// <remarks />
        public const string PostCount = "PostCount";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaChatServer namespace (.NET code namespace is 'OpcUaChatServer').
        /// </summary>
        public const string OpcUaChatServer = "https://github.com/cactuaroid/OpcUaChatServer";
    }
    #endregion
}