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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUaChatServer
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the ChatLog DataType.
        /// </summary>
        public const uint ChatLog = 15078;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ChatLogsType_Post Method.
        /// </summary>
        public const uint ChatLogsType_Post = 15001;

        /// <summary>
        /// The identifier for the ChatLogs_Post Method.
        /// </summary>
        public const uint ChatLogs_Post = 15003;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ChatLogs Object.
        /// </summary>
        public const uint ChatLogs = 15079;

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ChatLog_Encoding_DefaultBinary = 15082;

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ChatLog_Encoding_DefaultXml = 15090;

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultJson Object.
        /// </summary>
        public const uint ChatLog_Encoding_DefaultJson = 15098;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ChatLogsType ObjectType.
        /// </summary>
        public const uint ChatLogsType = 15041;

        /// <summary>
        /// The identifier for the ChatLogEventType ObjectType.
        /// </summary>
        public const uint ChatLogEventType = 15044;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ChatLogsType_Post_InputArguments Variable.
        /// </summary>
        public const uint ChatLogsType_Post_InputArguments = 15002;

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog Variable.
        /// </summary>
        public const uint ChatLogEventType_ChatLog = 15055;

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_At Variable.
        /// </summary>
        public const uint ChatLogEventType_ChatLog_At = 15071;

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_Name Variable.
        /// </summary>
        public const uint ChatLogEventType_ChatLog_Name = 15072;

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_Content Variable.
        /// </summary>
        public const uint ChatLogEventType_ChatLog_Content = 15073;

        /// <summary>
        /// The identifier for the ChatLogType_At Variable.
        /// </summary>
        public const uint ChatLogType_At = 15075;

        /// <summary>
        /// The identifier for the ChatLogType_Name Variable.
        /// </summary>
        public const uint ChatLogType_Name = 15076;

        /// <summary>
        /// The identifier for the ChatLogType_Content Variable.
        /// </summary>
        public const uint ChatLogType_Content = 15077;

        /// <summary>
        /// The identifier for the ChatLogs_Post_InputArguments Variable.
        /// </summary>
        public const uint ChatLogs_Post_InputArguments = 15004;

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaChatServer_BinarySchema = 15083;

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaChatServer_BinarySchema_NamespaceUri = 15085;

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaChatServer_BinarySchema_Deprecated = 15086;

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_ChatLog Variable.
        /// </summary>
        public const uint OpcUaChatServer_BinarySchema_ChatLog = 15087;

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaChatServer_XmlSchema = 15091;

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaChatServer_XmlSchema_NamespaceUri = 15093;

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaChatServer_XmlSchema_Deprecated = 15094;

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_ChatLog Variable.
        /// </summary>
        public const uint OpcUaChatServer_XmlSchema_ChatLog = 15095;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the ChatLogType VariableType.
        /// </summary>
        public const uint ChatLogType = 15074;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the ChatLog DataType.
        /// </summary>
        public static readonly ExpandedNodeId ChatLog = new ExpandedNodeId(OpcUaChatServer.DataTypes.ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ChatLogsType_Post Method.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogsType_Post = new ExpandedNodeId(OpcUaChatServer.Methods.ChatLogsType_Post, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogs_Post Method.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogs_Post = new ExpandedNodeId(OpcUaChatServer.Methods.ChatLogs_Post, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ChatLogs Object.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogs = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLogs, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultBinary = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultBinary, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultXml = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultXml, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLog_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId ChatLog_Encoding_DefaultJson = new ExpandedNodeId(OpcUaChatServer.Objects.ChatLog_Encoding_DefaultJson, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ChatLogsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogsType = new ExpandedNodeId(OpcUaChatServer.ObjectTypes.ChatLogsType, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogEventType = new ExpandedNodeId(OpcUaChatServer.ObjectTypes.ChatLogEventType, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ChatLogsType_Post_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogsType_Post_InputArguments = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogsType_Post_InputArguments, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogEventType_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogEventType_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_At Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogEventType_ChatLog_At = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogEventType_ChatLog_At, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogEventType_ChatLog_Name = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogEventType_ChatLog_Name, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogEventType_ChatLog_Content Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogEventType_ChatLog_Content = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogEventType_ChatLog_Content, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogType_At Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogType_At = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogType_At, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogType_Name = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogType_Name, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogType_Content Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogType_Content = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogType_Content, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the ChatLogs_Post_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogs_Post_InputArguments = new ExpandedNodeId(OpcUaChatServer.Variables.ChatLogs_Post_InputArguments, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_NamespaceUri = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_NamespaceUri, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_Deprecated = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_Deprecated, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_BinarySchema_ChatLog Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_BinarySchema_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_BinarySchema_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_NamespaceUri = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_NamespaceUri, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_Deprecated = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_Deprecated, OpcUaChatServer.Namespaces.OpcUaChatServer);

        /// <summary>
        /// The identifier for the OpcUaChatServer_XmlSchema_ChatLog Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaChatServer_XmlSchema_ChatLog = new ExpandedNodeId(OpcUaChatServer.Variables.OpcUaChatServer_XmlSchema_ChatLog, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the ChatLogType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ChatLogType = new ExpandedNodeId(OpcUaChatServer.VariableTypes.ChatLogType, OpcUaChatServer.Namespaces.OpcUaChatServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the At component.
        /// </summary>
        public const string At = "At";

        /// <summary>
        /// The BrowseName for the ChatLog component.
        /// </summary>
        public const string ChatLog = "ChatLog";

        /// <summary>
        /// The BrowseName for the ChatLogEventType component.
        /// </summary>
        public const string ChatLogEventType = "ChatLogEventType";

        /// <summary>
        /// The BrowseName for the ChatLogs component.
        /// </summary>
        public const string ChatLogs = "ChatLogs";

        /// <summary>
        /// The BrowseName for the ChatLogsType component.
        /// </summary>
        public const string ChatLogsType = "ChatLogsType";

        /// <summary>
        /// The BrowseName for the ChatLogType component.
        /// </summary>
        public const string ChatLogType = "ChatLogType";

        /// <summary>
        /// The BrowseName for the Content component.
        /// </summary>
        public const string Content = "Content";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the OpcUaChatServer_BinarySchema component.
        /// </summary>
        public const string OpcUaChatServer_BinarySchema = "OpcUaChatServer";

        /// <summary>
        /// The BrowseName for the OpcUaChatServer_XmlSchema component.
        /// </summary>
        public const string OpcUaChatServer_XmlSchema = "OpcUaChatServer";

        /// <summary>
        /// The BrowseName for the Post component.
        /// </summary>
        public const string Post = "Post";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
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