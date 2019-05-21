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

namespace Opc.Ua.CNC
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
        /// The identifier for the CncPositionDataType DataType.
        /// </summary>
        public const uint CncPositionDataType = 3007;
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
        /// The identifier for the CncChannelListType_CncChannel Object.
        /// </summary>
        public const uint CncChannelListType_CncChannel = 15086;

        /// <summary>
        /// The identifier for the CncInterfaceType_CncAxisList Object.
        /// </summary>
        public const uint CncInterfaceType_CncAxisList = 15172;

        /// <summary>
        /// The identifier for the CncInterfaceType_CncChannelList Object.
        /// </summary>
        public const uint CncInterfaceType_CncChannelList = 15232;

        /// <summary>
        /// The identifier for the CncInterface Object.
        /// </summary>
        public const uint CncInterface = 15178;

        /// <summary>
        /// The identifier for the CncInterface_CncAxisList Object.
        /// </summary>
        public const uint CncInterface_CncAxisList = 15179;

        /// <summary>
        /// The identifier for the CncInterface_CncChannelList Object.
        /// </summary>
        public const uint CncInterface_CncChannelList = 15233;

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint CncPositionDataType_Encoding_DefaultBinary = 15185;

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint CncPositionDataType_Encoding_DefaultXml = 15193;

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint CncPositionDataType_Encoding_DefaultJson = 15201;
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
        /// The identifier for the CncComponentType ObjectType.
        /// </summary>
        public const uint CncComponentType = 1001;

        /// <summary>
        /// The identifier for the CncDriveType ObjectType.
        /// </summary>
        public const uint CncDriveType = 1003;

        /// <summary>
        /// The identifier for the CncAxisListType ObjectType.
        /// </summary>
        public const uint CncAxisListType = 1008;

        /// <summary>
        /// The identifier for the CncChannelType ObjectType.
        /// </summary>
        public const uint CncChannelType = 1002;

        /// <summary>
        /// The identifier for the CncChannelListType ObjectType.
        /// </summary>
        public const uint CncChannelListType = 1010;

        /// <summary>
        /// The identifier for the CncInterfaceType ObjectType.
        /// </summary>
        public const uint CncInterfaceType = 1007;
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
        /// The identifier for the CncDriveType_ActLoad Variable.
        /// </summary>
        public const uint CncDriveType_ActLoad = 15202;

        /// <summary>
        /// The identifier for the CncDriveType_ActLoad_EURange Variable.
        /// </summary>
        public const uint CncDriveType_ActLoad_EURange = 15206;

        /// <summary>
        /// The identifier for the CncDriveType_ActPower Variable.
        /// </summary>
        public const uint CncDriveType_ActPower = 15208;

        /// <summary>
        /// The identifier for the CncDriveType_ActPower_EURange Variable.
        /// </summary>
        public const uint CncDriveType_ActPower_EURange = 15212;

        /// <summary>
        /// The identifier for the CncDriveType_ActTorque Variable.
        /// </summary>
        public const uint CncDriveType_ActTorque = 15214;

        /// <summary>
        /// The identifier for the CncDriveType_ActTorque_EURange Variable.
        /// </summary>
        public const uint CncDriveType_ActTorque_EURange = 15218;

        /// <summary>
        /// The identifier for the CncDriveType_CmdTorque Variable.
        /// </summary>
        public const uint CncDriveType_CmdTorque = 15220;

        /// <summary>
        /// The identifier for the CncDriveType_CmdTorque_EURange Variable.
        /// </summary>
        public const uint CncDriveType_CmdTorque_EURange = 15224;

        /// <summary>
        /// The identifier for the CncDriveType_IsInactive Variable.
        /// </summary>
        public const uint CncDriveType_IsInactive = 15226;

        /// <summary>
        /// The identifier for the CncDriveType_IsVirtual Variable.
        /// </summary>
        public const uint CncDriveType_IsVirtual = 15229;

        /// <summary>
        /// The identifier for the CncChannelType_ActFeedrate Variable.
        /// </summary>
        public const uint CncChannelType_ActFeedrate = 15001;

        /// <summary>
        /// The identifier for the CncChannelType_ActFeedrate_EURange Variable.
        /// </summary>
        public const uint CncChannelType_ActFeedrate_EURange = 15005;

        /// <summary>
        /// The identifier for the CncChannelType_ActGFunctions Variable.
        /// </summary>
        public const uint CncChannelType_ActGFunctions = 15007;

        /// <summary>
        /// The identifier for the CncChannelType_ActJogIncrement Variable.
        /// </summary>
        public const uint CncChannelType_ActJogIncrement = 15010;

        /// <summary>
        /// The identifier for the CncChannelType_ActJogIncrement_EURange Variable.
        /// </summary>
        public const uint CncChannelType_ActJogIncrement_EURange = 15014;

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramFile Variable.
        /// </summary>
        public const uint CncChannelType_ActMainProgramFile = 15016;

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramFileOffset Variable.
        /// </summary>
        public const uint CncChannelType_ActMainProgramFileOffset = 15019;

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramLine Variable.
        /// </summary>
        public const uint CncChannelType_ActMainProgramLine = 15022;

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramName Variable.
        /// </summary>
        public const uint CncChannelType_ActMainProgramName = 15025;

        /// <summary>
        /// The identifier for the CncChannelType_ActMFunctions Variable.
        /// </summary>
        public const uint CncChannelType_ActMFunctions = 15028;

        /// <summary>
        /// The identifier for the CncChannelType_ActOverride Variable.
        /// </summary>
        public const uint CncChannelType_ActOverride = 15031;

        /// <summary>
        /// The identifier for the CncChannelType_ActOverride_EURange Variable.
        /// </summary>
        public const uint CncChannelType_ActOverride_EURange = 15035;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramBlock Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramBlock = 15037;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramFile Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramFile = 15040;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramFileOffset Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramFileOffset = 15043;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramLine Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramLine = 15046;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramName Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramName = 15049;

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramStatus Variable.
        /// </summary>
        public const uint CncChannelType_ActProgramStatus = 15052;

        /// <summary>
        /// The identifier for the CncChannelType_ActStatus Variable.
        /// </summary>
        public const uint CncChannelType_ActStatus = 15055;

        /// <summary>
        /// The identifier for the CncChannelType_BlockMode Variable.
        /// </summary>
        public const uint CncChannelType_BlockMode = 15058;

        /// <summary>
        /// The identifier for the CncChannelType_CmdFeedrate Variable.
        /// </summary>
        public const uint CncChannelType_CmdFeedrate = 15061;

        /// <summary>
        /// The identifier for the CncChannelType_CmdFeedrate_EURange Variable.
        /// </summary>
        public const uint CncChannelType_CmdFeedrate_EURange = 15065;

        /// <summary>
        /// The identifier for the CncChannelType_CmdOverride Variable.
        /// </summary>
        public const uint CncChannelType_CmdOverride = 15067;

        /// <summary>
        /// The identifier for the CncChannelType_CmdOverride_EURange Variable.
        /// </summary>
        public const uint CncChannelType_CmdOverride_EURange = 15071;

        /// <summary>
        /// The identifier for the CncChannelType_DryRunFeed Variable.
        /// </summary>
        public const uint CncChannelType_DryRunFeed = 15073;

        /// <summary>
        /// The identifier for the CncChannelType_DryRunFeed_EURange Variable.
        /// </summary>
        public const uint CncChannelType_DryRunFeed_EURange = 15077;

        /// <summary>
        /// The identifier for the CncChannelType_FeedHold Variable.
        /// </summary>
        public const uint CncChannelType_FeedHold = 15079;

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpBcsX Variable.
        /// </summary>
        public const uint CncChannelType_PodTcpBcsX = 15082;

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpBcsY Variable.
        /// </summary>
        public const uint CncChannelType_PodTcpBcsY = 15083;

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpWcsX Variable.
        /// </summary>
        public const uint CncChannelType_PodTcpWcsX = 15084;

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpWcsY Variable.
        /// </summary>
        public const uint CncChannelType_PodTcpWcsY = 15085;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActFeedrate Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActFeedrate = 15087;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActFeedrate_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActFeedrate_EURange = 15091;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActGFunctions Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActGFunctions = 15093;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActJogIncrement Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActJogIncrement = 15096;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActJogIncrement_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActJogIncrement_EURange = 15100;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMainProgramFile Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActMainProgramFile = 15102;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMainProgramName Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActMainProgramName = 15111;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMFunctions Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActMFunctions = 15114;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActOverride Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActOverride = 15117;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActOverride_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActOverride_EURange = 15121;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramBlock Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActProgramBlock = 15123;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramFile Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActProgramFile = 15126;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramName Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActProgramName = 15135;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramStatus Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActProgramStatus = 15138;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActStatus Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_ActStatus = 15141;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_BlockMode Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_BlockMode = 15144;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdFeedrate Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_CmdFeedrate = 15147;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdFeedrate_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_CmdFeedrate_EURange = 15151;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdOverride Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_CmdOverride = 15153;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdOverride_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_CmdOverride_EURange = 15157;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_DryRunFeed Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_DryRunFeed = 15159;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_DryRunFeed_EURange Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_DryRunFeed_EURange = 15163;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_FeedHold Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_FeedHold = 15165;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpBcsX Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_PodTcpBcsX = 15168;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpBcsY Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_PodTcpBcsY = 15169;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpWcsX Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_PodTcpWcsX = 15170;

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpWcsY Variable.
        /// </summary>
        public const uint CncChannelListType_CncChannel_PodTcpWcsY = 15171;

        /// <summary>
        /// The identifier for the CncInterfaceType_CncTypeName Variable.
        /// </summary>
        public const uint CncInterfaceType_CncTypeName = 15173;

        /// <summary>
        /// The identifier for the CncInterfaceType_Fix Variable.
        /// </summary>
        public const uint CncInterfaceType_Fix = 15174;

        /// <summary>
        /// The identifier for the CncInterfaceType_VendorName Variable.
        /// </summary>
        public const uint CncInterfaceType_VendorName = 15175;

        /// <summary>
        /// The identifier for the CncInterfaceType_VendorRevision Variable.
        /// </summary>
        public const uint CncInterfaceType_VendorRevision = 15176;

        /// <summary>
        /// The identifier for the CncInterfaceType_Version Variable.
        /// </summary>
        public const uint CncInterfaceType_Version = 15177;

        /// <summary>
        /// The identifier for the CncInterface_CncTypeName Variable.
        /// </summary>
        public const uint CncInterface_CncTypeName = 15180;

        /// <summary>
        /// The identifier for the CncInterface_Fix Variable.
        /// </summary>
        public const uint CncInterface_Fix = 15181;

        /// <summary>
        /// The identifier for the CncInterface_VendorName Variable.
        /// </summary>
        public const uint CncInterface_VendorName = 15182;

        /// <summary>
        /// The identifier for the CncInterface_VendorRevision Variable.
        /// </summary>
        public const uint CncInterface_VendorRevision = 15183;

        /// <summary>
        /// The identifier for the CncInterface_Version Variable.
        /// </summary>
        public const uint CncInterface_Version = 15184;

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaCNC_BinarySchema = 15186;

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaCNC_BinarySchema_NamespaceUri = 15188;

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaCNC_BinarySchema_Deprecated = 15189;

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_CncPositionDataType Variable.
        /// </summary>
        public const uint OpcUaCNC_BinarySchema_CncPositionDataType = 15190;

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaCNC_XmlSchema = 15194;

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaCNC_XmlSchema_NamespaceUri = 15196;

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaCNC_XmlSchema_Deprecated = 15197;

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_CncPositionDataType Variable.
        /// </summary>
        public const uint OpcUaCNC_XmlSchema_CncPositionDataType = 15198;
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
        /// The identifier for the CncPositionVariableType VariableType.
        /// </summary>
        public const uint CncPositionVariableType = 2001;
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
        /// The identifier for the CncPositionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CncPositionDataType = new ExpandedNodeId(Opc.Ua.CNC.DataTypes.CncPositionDataType, Opc.Ua.CNC.Namespaces.OpcUaCNC);
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
        /// The identifier for the CncChannelListType_CncChannel Object.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncChannelListType_CncChannel, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_CncAxisList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_CncAxisList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterfaceType_CncAxisList, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_CncChannelList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_CncChannelList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterfaceType_CncChannelList, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterface, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_CncAxisList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_CncAxisList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterface_CncAxisList, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_CncChannelList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_CncChannelList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterface_CncChannelList, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId CncPositionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncPositionDataType_Encoding_DefaultBinary, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId CncPositionDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncPositionDataType_Encoding_DefaultXml, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncPositionDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId CncPositionDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncPositionDataType_Encoding_DefaultJson, Opc.Ua.CNC.Namespaces.OpcUaCNC);
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
        /// The identifier for the CncComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncComponentType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncComponentType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncDriveType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncAxisListType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncAxisListType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncAxisListType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncChannelType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncChannelListType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncInterfaceType, Opc.Ua.CNC.Namespaces.OpcUaCNC);
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
        /// The identifier for the CncDriveType_ActLoad Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActLoad = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActLoad, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_ActLoad_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActLoad_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActLoad_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_ActPower Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActPower = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActPower, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_ActPower_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActPower_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActPower_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_ActTorque Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActTorque = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActTorque, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_ActTorque_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_ActTorque_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_ActTorque_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_CmdTorque Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_CmdTorque = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_CmdTorque, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_CmdTorque_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_CmdTorque_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_CmdTorque_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_IsInactive Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_IsInactive = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_IsInactive, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType_IsVirtual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType_IsVirtual = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncDriveType_IsVirtual, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActFeedrate Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActFeedrate = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActFeedrate, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActFeedrate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActFeedrate_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActFeedrate_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActGFunctions Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActGFunctions = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActGFunctions, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActJogIncrement Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActJogIncrement = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActJogIncrement, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActJogIncrement_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActJogIncrement_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActJogIncrement_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramFile Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActMainProgramFile = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActMainProgramFile, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramFileOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActMainProgramFileOffset = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActMainProgramFileOffset, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramLine Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActMainProgramLine = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActMainProgramLine, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActMainProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActMainProgramName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActMainProgramName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActMFunctions Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActMFunctions = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActMFunctions, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActOverride = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActOverride, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActOverride_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActOverride_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActOverride_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramBlock Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramBlock = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramBlock, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramFile Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramFile = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramFile, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramFileOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramFileOffset = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramFileOffset, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramLine Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramLine = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramLine, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActProgramStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActProgramStatus = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActProgramStatus, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_ActStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_ActStatus = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_ActStatus, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_BlockMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_BlockMode = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_BlockMode, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_CmdFeedrate Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_CmdFeedrate = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_CmdFeedrate, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_CmdFeedrate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_CmdFeedrate_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_CmdFeedrate_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_CmdOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_CmdOverride = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_CmdOverride, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_CmdOverride_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_CmdOverride_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_CmdOverride_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_DryRunFeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_DryRunFeed = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_DryRunFeed, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_DryRunFeed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_DryRunFeed_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_DryRunFeed_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_FeedHold Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_FeedHold = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_FeedHold, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpBcsX Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_PodTcpBcsX = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_PodTcpBcsX, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpBcsY Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_PodTcpBcsY = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_PodTcpBcsY, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpWcsX Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_PodTcpWcsX = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_PodTcpWcsX, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelType_PodTcpWcsY Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelType_PodTcpWcsY = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelType_PodTcpWcsY, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActFeedrate Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActFeedrate = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActFeedrate, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActFeedrate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActFeedrate_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActFeedrate_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActGFunctions Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActGFunctions = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActGFunctions, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActJogIncrement Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActJogIncrement = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActJogIncrement, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActJogIncrement_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActJogIncrement_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActJogIncrement_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMainProgramFile Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActMainProgramFile = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActMainProgramFile, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMainProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActMainProgramName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActMainProgramName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActMFunctions Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActMFunctions = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActMFunctions, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActOverride = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActOverride, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActOverride_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActOverride_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActOverride_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramBlock Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActProgramBlock = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActProgramBlock, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramFile Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActProgramFile = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActProgramFile, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActProgramName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActProgramName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActProgramStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActProgramStatus = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActProgramStatus, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_ActStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_ActStatus = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_ActStatus, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_BlockMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_BlockMode = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_BlockMode, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdFeedrate Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_CmdFeedrate = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_CmdFeedrate, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdFeedrate_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_CmdFeedrate_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_CmdFeedrate_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_CmdOverride = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_CmdOverride, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_CmdOverride_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_CmdOverride_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_CmdOverride_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_DryRunFeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_DryRunFeed = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_DryRunFeed, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_DryRunFeed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_DryRunFeed_EURange = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_DryRunFeed_EURange, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_FeedHold Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_FeedHold = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_FeedHold, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpBcsX Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_PodTcpBcsX = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_PodTcpBcsX, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpBcsY Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_PodTcpBcsY = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_PodTcpBcsY, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpWcsX Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_PodTcpWcsX = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_PodTcpWcsX, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncChannelListType_CncChannel_PodTcpWcsY Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncChannelListType_CncChannel_PodTcpWcsY = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncChannelListType_CncChannel_PodTcpWcsY, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_CncTypeName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_CncTypeName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterfaceType_CncTypeName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_Fix Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_Fix = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterfaceType_Fix, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_VendorName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_VendorName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterfaceType_VendorName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_VendorRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_VendorRevision = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterfaceType_VendorRevision, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType_Version Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_Version = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterfaceType_Version, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_CncTypeName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_CncTypeName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterface_CncTypeName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_Fix Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_Fix = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterface_Fix, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_VendorName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_VendorName = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterface_VendorName, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_VendorRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_VendorRevision = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterface_VendorRevision, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_Version Variable.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_Version = new ExpandedNodeId(Opc.Ua.CNC.Variables.CncInterface_Version, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_BinarySchema = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_BinarySchema, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_BinarySchema_NamespaceUri, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_BinarySchema_Deprecated = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_BinarySchema_Deprecated, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_BinarySchema_CncPositionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_BinarySchema_CncPositionDataType = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_BinarySchema_CncPositionDataType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_XmlSchema = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_XmlSchema, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_XmlSchema_NamespaceUri, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_XmlSchema_Deprecated = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_XmlSchema_Deprecated, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the OpcUaCNC_XmlSchema_CncPositionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaCNC_XmlSchema_CncPositionDataType = new ExpandedNodeId(Opc.Ua.CNC.Variables.OpcUaCNC_XmlSchema_CncPositionDataType, Opc.Ua.CNC.Namespaces.OpcUaCNC);
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
        /// The identifier for the CncPositionVariableType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId CncPositionVariableType = new ExpandedNodeId(Opc.Ua.CNC.VariableTypes.CncPositionVariableType, Opc.Ua.CNC.Namespaces.OpcUaCNC);
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
        /// The BrowseName for the ActFeedrate component.
        /// </summary>
        public const string ActFeedrate = "ActFeedrate";

        /// <summary>
        /// The BrowseName for the ActGFunctions component.
        /// </summary>
        public const string ActGFunctions = "ActGFunctions";

        /// <summary>
        /// The BrowseName for the ActJogIncrement component.
        /// </summary>
        public const string ActJogIncrement = "ActJogIncrement";

        /// <summary>
        /// The BrowseName for the ActLoad component.
        /// </summary>
        public const string ActLoad = "ActLoad";

        /// <summary>
        /// The BrowseName for the ActMainProgramFile component.
        /// </summary>
        public const string ActMainProgramFile = "ActMainProgramFile";

        /// <summary>
        /// The BrowseName for the ActMainProgramFileOffset component.
        /// </summary>
        public const string ActMainProgramFileOffset = "ActMainProgramFileOffset";

        /// <summary>
        /// The BrowseName for the ActMainProgramLine component.
        /// </summary>
        public const string ActMainProgramLine = "ActMainProgramLine";

        /// <summary>
        /// The BrowseName for the ActMainProgramName component.
        /// </summary>
        public const string ActMainProgramName = "ActMainProgramName";

        /// <summary>
        /// The BrowseName for the ActMFunctions component.
        /// </summary>
        public const string ActMFunctions = "ActMFunctions";

        /// <summary>
        /// The BrowseName for the ActOverride component.
        /// </summary>
        public const string ActOverride = "ActOverride";

        /// <summary>
        /// The BrowseName for the ActPower component.
        /// </summary>
        public const string ActPower = "ActPower";

        /// <summary>
        /// The BrowseName for the ActProgramBlock component.
        /// </summary>
        public const string ActProgramBlock = "ActProgramBlock";

        /// <summary>
        /// The BrowseName for the ActProgramFile component.
        /// </summary>
        public const string ActProgramFile = "ActProgramFile";

        /// <summary>
        /// The BrowseName for the ActProgramFileOffset component.
        /// </summary>
        public const string ActProgramFileOffset = "ActProgramFileOffset";

        /// <summary>
        /// The BrowseName for the ActProgramLine component.
        /// </summary>
        public const string ActProgramLine = "ActProgramLine";

        /// <summary>
        /// The BrowseName for the ActProgramName component.
        /// </summary>
        public const string ActProgramName = "ActProgramName";

        /// <summary>
        /// The BrowseName for the ActProgramStatus component.
        /// </summary>
        public const string ActProgramStatus = "ActProgramStatus";

        /// <summary>
        /// The BrowseName for the ActStatus component.
        /// </summary>
        public const string ActStatus = "ActStatus";

        /// <summary>
        /// The BrowseName for the ActTorque component.
        /// </summary>
        public const string ActTorque = "ActTorque";

        /// <summary>
        /// The BrowseName for the BlockMode component.
        /// </summary>
        public const string BlockMode = "BlockMode";

        /// <summary>
        /// The BrowseName for the CmdFeedrate component.
        /// </summary>
        public const string CmdFeedrate = "CmdFeedrate";

        /// <summary>
        /// The BrowseName for the CmdOverride component.
        /// </summary>
        public const string CmdOverride = "CmdOverride";

        /// <summary>
        /// The BrowseName for the CmdTorque component.
        /// </summary>
        public const string CmdTorque = "CmdTorque";

        /// <summary>
        /// The BrowseName for the CncAxisList component.
        /// </summary>
        public const string CncAxisList = "CncAxisList";

        /// <summary>
        /// The BrowseName for the CncAxisListType component.
        /// </summary>
        public const string CncAxisListType = "CncAxisListType";

        /// <summary>
        /// The BrowseName for the CncChannel component.
        /// </summary>
        public const string CncChannel = "CncChannel";

        /// <summary>
        /// The BrowseName for the CncChannelList component.
        /// </summary>
        public const string CncChannelList = "CncChannelList";

        /// <summary>
        /// The BrowseName for the CncChannelListType component.
        /// </summary>
        public const string CncChannelListType = "CncChannelListType";

        /// <summary>
        /// The BrowseName for the CncChannelType component.
        /// </summary>
        public const string CncChannelType = "CncChannelType";

        /// <summary>
        /// The BrowseName for the CncComponentType component.
        /// </summary>
        public const string CncComponentType = "CncComponentType";

        /// <summary>
        /// The BrowseName for the CncDriveType component.
        /// </summary>
        public const string CncDriveType = "CncDriveType";

        /// <summary>
        /// The BrowseName for the CncInterface component.
        /// </summary>
        public const string CncInterface = "CncInterface";

        /// <summary>
        /// The BrowseName for the CncInterfaceType component.
        /// </summary>
        public const string CncInterfaceType = "CncInterfaceType";

        /// <summary>
        /// The BrowseName for the CncPositionDataType component.
        /// </summary>
        public const string CncPositionDataType = "CncPositionDataType";

        /// <summary>
        /// The BrowseName for the CncPositionVariableType component.
        /// </summary>
        public const string CncPositionVariableType = "CncPositionVariableType";

        /// <summary>
        /// The BrowseName for the CncTypeName component.
        /// </summary>
        public const string CncTypeName = "CncTypeName";

        /// <summary>
        /// The BrowseName for the DryRunFeed component.
        /// </summary>
        public const string DryRunFeed = "DryRunFeed";

        /// <summary>
        /// The BrowseName for the FeedHold component.
        /// </summary>
        public const string FeedHold = "FeedHold";

        /// <summary>
        /// The BrowseName for the Fix component.
        /// </summary>
        public const string Fix = "Fix";

        /// <summary>
        /// The BrowseName for the IsInactive component.
        /// </summary>
        public const string IsInactive = "IsInactive";

        /// <summary>
        /// The BrowseName for the IsVirtual component.
        /// </summary>
        public const string IsVirtual = "IsVirtual";

        /// <summary>
        /// The BrowseName for the OpcUaCNC_BinarySchema component.
        /// </summary>
        public const string OpcUaCNC_BinarySchema = "Opc.Ua.CNC";

        /// <summary>
        /// The BrowseName for the OpcUaCNC_XmlSchema component.
        /// </summary>
        public const string OpcUaCNC_XmlSchema = "Opc.Ua.CNC";

        /// <summary>
        /// The BrowseName for the PodTcpBcsX component.
        /// </summary>
        public const string PodTcpBcsX = "PodTcpBcsX";

        /// <summary>
        /// The BrowseName for the PodTcpBcsY component.
        /// </summary>
        public const string PodTcpBcsY = "PodTcpBcsY";

        /// <summary>
        /// The BrowseName for the PodTcpWcsX component.
        /// </summary>
        public const string PodTcpWcsX = "PodTcpWcsX";

        /// <summary>
        /// The BrowseName for the PodTcpWcsY component.
        /// </summary>
        public const string PodTcpWcsY = "PodTcpWcsY";

        /// <summary>
        /// The BrowseName for the VendorName component.
        /// </summary>
        public const string VendorName = "VendorName";

        /// <summary>
        /// The BrowseName for the VendorRevision component.
        /// </summary>
        public const string VendorRevision = "VendorRevision";

        /// <summary>
        /// The BrowseName for the Version component.
        /// </summary>
        public const string Version = "Version";
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
        /// The URI for the OpcUaCNC namespace (.NET code namespace is 'Opc.Ua.CNC').
        /// </summary>
        public const string OpcUaCNC = "http://www.opcfoundation.org/CNC/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}
