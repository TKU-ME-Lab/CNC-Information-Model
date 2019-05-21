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

namespace Opc.Ua.CNC
{
    #region CncComponentState Class
    #if (!OPCUA_EXCLUDE_CncComponentState)
    /// <summary>
    /// Stores an instance of the CncComponentType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncComponentState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncComponentState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncComponentType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////BGCAAgEAAAABABgAAABD" +
           "bmNDb21wb25lbnRUeXBlSW5zdGFuY2UBAekDAQHpA+kDAAD/////AAAAAA==";
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

    #region CncDriveState Class
    #if (!OPCUA_EXCLUDE_CncDriveState)
    /// <summary>
    /// Stores an instance of the CncDriveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncDriveState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncDriveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncDriveType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////BGCAAgEAAAABABQAAABD" +
           "bmNEcml2ZVR5cGVJbnN0YW5jZQEB6wMBAesD6wMAAP////8GAAAAFWCJCgIAAAABAAcAAABBY3RMb2Fk" +
           "AQFiOwAvAQBACWI7AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFmOwAuAERm" +
           "OwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAgAAABBY3RQb3dlcgEBaDsALwEAQAloOwAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBbDsALgBEbDsAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAJAAAAQWN0VG9ycXVlAQFuOwAvAQBACW47AAAAC/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQFyOwAuAERyOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAkA" +
           "AABDbWRUb3JxdWUBAXQ7AC8BAEAJdDsAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAXg7AC4ARHg7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAElzSW5hY3RpdmUBAXo7" +
           "AC8BAD0JejsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEACQAAAElzVmlydHVhbAEBfTsALwEAPQl9" +
           "OwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> ActLoad
        {
            get
            {
                return m_actLoad;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actLoad, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actLoad = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> ActPower
        {
            get
            {
                return m_actPower;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actPower, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actPower = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> ActTorque
        {
            get
            {
                return m_actTorque;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actTorque, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actTorque = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> CmdTorque
        {
            get
            {
                return m_cmdTorque;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cmdTorque, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cmdTorque = value;
            }
        }

        /// <remarks />
        public DataItemState<bool> IsInactive
        {
            get
            {
                return m_isInactive;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isInactive, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isInactive = value;
            }
        }

        /// <remarks />
        public DataItemState<bool> IsVirtual
        {
            get
            {
                return m_isVirtual;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isVirtual, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isVirtual = value;
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
            if (m_actLoad != null)
            {
                children.Add(m_actLoad);
            }

            if (m_actPower != null)
            {
                children.Add(m_actPower);
            }

            if (m_actTorque != null)
            {
                children.Add(m_actTorque);
            }

            if (m_cmdTorque != null)
            {
                children.Add(m_cmdTorque);
            }

            if (m_isInactive != null)
            {
                children.Add(m_isInactive);
            }

            if (m_isVirtual != null)
            {
                children.Add(m_isVirtual);
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
                case Opc.Ua.CNC.BrowseNames.ActLoad:
                {
                    if (createOrReplace)
                    {
                        if (ActLoad == null)
                        {
                            if (replacement == null)
                            {
                                ActLoad = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActLoad = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActLoad;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActPower:
                {
                    if (createOrReplace)
                    {
                        if (ActPower == null)
                        {
                            if (replacement == null)
                            {
                                ActPower = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActPower = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActPower;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActTorque:
                {
                    if (createOrReplace)
                    {
                        if (ActTorque == null)
                        {
                            if (replacement == null)
                            {
                                ActTorque = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActTorque = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActTorque;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.CmdTorque:
                {
                    if (createOrReplace)
                    {
                        if (CmdTorque == null)
                        {
                            if (replacement == null)
                            {
                                CmdTorque = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                CmdTorque = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = CmdTorque;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.IsInactive:
                {
                    if (createOrReplace)
                    {
                        if (IsInactive == null)
                        {
                            if (replacement == null)
                            {
                                IsInactive = new DataItemState<bool>(this);
                            }
                            else
                            {
                                IsInactive = (DataItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsInactive;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.IsVirtual:
                {
                    if (createOrReplace)
                    {
                        if (IsVirtual == null)
                        {
                            if (replacement == null)
                            {
                                IsVirtual = new DataItemState<bool>(this);
                            }
                            else
                            {
                                IsVirtual = (DataItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsVirtual;
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
        private AnalogItemState<double> m_actLoad;
        private AnalogItemState<double> m_actPower;
        private AnalogItemState<double> m_actTorque;
        private AnalogItemState<double> m_cmdTorque;
        private DataItemState<bool> m_isInactive;
        private DataItemState<bool> m_isVirtual;
        #endregion
    }
    #endif
    #endregion

    #region CncAxisListState Class
    #if (!OPCUA_EXCLUDE_CncAxisListState)
    /// <summary>
    /// Stores an instance of the CncAxisListType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncAxisListState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncAxisListState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncAxisListType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////BGCAAgEAAAABABcAAABD" +
           "bmNBeGlzTGlzdFR5cGVJbnN0YW5jZQEB8AMBAfAD8AMAAAIAAAAALQAAOgAjAABVAAAAAA==";
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

    #region CncPositionVariableState Class
    #if (!OPCUA_EXCLUDE_CncPositionVariableState)
    /// <summary>
    /// Stores an instance of the CncPositionVariableType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncPositionVariableState : BaseDataVariableState<CncPositionDataType>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncPositionVariableState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.VariableTypes.CncPositionVariableType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.DataTypes.CncPositionDataType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////FWCJAgIAAAABAB8AAABD" +
           "bmNQb3NpdGlvblZhcmlhYmxlVHlwZUluc3RhbmNlAQHRBwEB0QfRBwAAAQG/C/7///8BAf////8AAAAA";
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

    #region CncChannelState Class
    #if (!OPCUA_EXCLUDE_CncChannelState)
    /// <summary>
    /// Stores an instance of the CncChannelType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncChannelState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncChannelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncChannelType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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

            if (ActMainProgramFileOffset != null)
            {
                ActMainProgramFileOffset.Initialize(context, ActMainProgramFileOffset_InitializationString);
            }

            if (ActMainProgramLine != null)
            {
                ActMainProgramLine.Initialize(context, ActMainProgramLine_InitializationString);
            }

            if (ActProgramFileOffset != null)
            {
                ActProgramFileOffset.Initialize(context, ActProgramFileOffset_InitializationString);
            }

            if (ActProgramLine != null)
            {
                ActProgramLine.Initialize(context, ActProgramLine_InitializationString);
            }
        }

        #region Initialization String
        private const string ActMainProgramFileOffset_InitializationString =
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////FWCJCgIAAAABABgAAABB" +
           "Y3RNYWluUHJvZ3JhbUZpbGVPZmZzZXQBAas6AC8BAD0JqzoAAAAH/////wEB/////wAAAAA=";

        private const string ActMainProgramLine_InitializationString =
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////FWCJCgIAAAABABIAAABB" +
           "Y3RNYWluUHJvZ3JhbUxpbmUBAa46AC8BAD0JrjoAAAAM/////wEB/////wAAAAA=";

        private const string ActProgramFileOffset_InitializationString =
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////FWCJCgIAAAABABQAAABB" +
           "Y3RQcm9ncmFtRmlsZU9mZnNldAEBwzoALwEAPQnDOgAAAA//////AQH/////AAAAAA==";

        private const string ActProgramLine_InitializationString =
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////FWCJCgIAAAABAA4AAABB" +
           "Y3RQcm9ncmFtTGluZQEBxjoALwEAPQnGOgAAAA//////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////BGCAAgEAAAABABYAAABD" +
           "bmNDaGFubmVsVHlwZUluc3RhbmNlAQHqAwEB6gPqAwAA/////xkAAAAVYIkKAgAAAAEACwAAAEFjdEZl" +
           "ZWRyYXRlAQGZOgAvAQBACZk6AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGd" +
           "OgAuAESdOgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABBY3RHRnVuY3Rpb25zAQGfOgAv" +
           "AQA9CZ86AAAAD/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABBY3RKb2dJbmNyZW1lbnQBAaI6AC8B" +
           "AEAJojoAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAaY6AC4ARKY6AAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAEFjdE1haW5Qcm9ncmFtRmlsZQEBqDoALwEAPQmoOgAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAYAAAAQWN0TWFpblByb2dyYW1GaWxlT2Zmc2V0AQGrOgAv" +
           "AQA9Cas6AAAAB/////8BAf////8AAAAAFWCJCgIAAAABABIAAABBY3RNYWluUHJvZ3JhbUxpbmUBAa46" +
           "AC8BAD0JrjoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAEFjdE1haW5Qcm9ncmFtTmFtZQEB" +
           "sToALwEAPQmxOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQANAAAAQWN0TUZ1bmN0aW9ucwEBtDoA" +
           "LwEAPQm0OgAAAA//////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0T3ZlcnJpZGUBAbc6AC8BAEAJ" +
           "tzoAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAbs6AC4ARLs6AAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADwAAAEFjdFByb2dyYW1CbG9jawEBvToALwEAPQm9OgAAAA//////" +
           "AQH/////AAAAABVgiQoCAAAAAQAOAAAAQWN0UHJvZ3JhbUZpbGUBAcA6AC8BAD0JwDoAAAAP/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAFAAAAEFjdFByb2dyYW1GaWxlT2Zmc2V0AQHDOgAvAQA9CcM6AAAAD///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY3RQcm9ncmFtTGluZQEBxjoALwEAPQnGOgAAAA//////" +
           "AQH/////AAAAABVgiQoCAAAAAQAOAAAAQWN0UHJvZ3JhbU5hbWUBAck6AC8BAD0JyToAAAAP/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEAAAAEFjdFByb2dyYW1TdGF0dXMBAcw6AC8BAD0JzDoAAAAP/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEACQAAAEFjdFN0YXR1cwEBzzoALwEAPQnPOgAAAA//////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAJAAAAQmxvY2tNb2RlAQHSOgAvAQA9CdI6AAAAD/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAsAAABDbWRGZWVkcmF0ZQEB1ToALwEAQAnVOgAAAA//////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEB2ToALgBE2ToAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQ21kT3Zl" +
           "cnJpZGUBAds6AC8BAEAJ2zoAAAAP/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAd86" +
           "AC4ARN86AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAERyeVJ1bkZlZWQBAeE6AC8BAEAJ" +
           "4ToAAAAP/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeU6AC4AROU6AAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACAAAAEZlZWRIb2xkAQHnOgAvAQA9Cec6AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAoAAABQb2RUY3BCY3NYAQHqOgAvAQHRB+o6AAABAb8L/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEACgAAAFBvZFRjcEJjc1kBAes6AC8BAdEH6zoAAAEBvwv/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAKAAAAUG9kVGNwV2NzWAEB7DoALwEB0QfsOgAAAQG/C/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAoAAABQb2RUY3BXY3NZAQHtOgAvAQHRB+06AAABAb8L/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> ActFeedrate
        {
            get
            {
                return m_actFeedrate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actFeedrate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actFeedrate = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActGFunctions
        {
            get
            {
                return m_actGFunctions;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actGFunctions, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actGFunctions = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> ActJogIncrement
        {
            get
            {
                return m_actJogIncrement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actJogIncrement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actJogIncrement = value;
            }
        }

        /// <remarks />
        public DataItemState<string> ActMainProgramFile
        {
            get
            {
                return m_actMainProgramFile;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actMainProgramFile, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actMainProgramFile = value;
            }
        }

        /// <remarks />
        public DataItemState<uint> ActMainProgramFileOffset
        {
            get
            {
                return m_actMainProgramFileOffset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actMainProgramFileOffset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actMainProgramFileOffset = value;
            }
        }

        /// <remarks />
        public DataItemState<string> ActMainProgramLine
        {
            get
            {
                return m_actMainProgramLine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actMainProgramLine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actMainProgramLine = value;
            }
        }

        /// <remarks />
        public DataItemState<string> ActMainProgramName
        {
            get
            {
                return m_actMainProgramName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actMainProgramName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actMainProgramName = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActMFunctions
        {
            get
            {
                return m_actMFunctions;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actMFunctions, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actMFunctions = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> ActOverride
        {
            get
            {
                return m_actOverride;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actOverride, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actOverride = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramBlock
        {
            get
            {
                return m_actProgramBlock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramBlock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramBlock = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramFile
        {
            get
            {
                return m_actProgramFile;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramFile, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramFile = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramFileOffset
        {
            get
            {
                return m_actProgramFileOffset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramFileOffset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramFileOffset = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramLine
        {
            get
            {
                return m_actProgramLine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramLine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramLine = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramName
        {
            get
            {
                return m_actProgramName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramName = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActProgramStatus
        {
            get
            {
                return m_actProgramStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actProgramStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actProgramStatus = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> ActStatus
        {
            get
            {
                return m_actStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actStatus = value;
            }
        }

        /// <remarks />
        public DataItemState<byte[]> BlockMode
        {
            get
            {
                return m_blockMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_blockMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_blockMode = value;
            }
        }

        /// <remarks />
        public AnalogItemState<byte[]> CmdFeedrate
        {
            get
            {
                return m_cmdFeedrate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cmdFeedrate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cmdFeedrate = value;
            }
        }

        /// <remarks />
        public AnalogItemState<byte[]> CmdOverride
        {
            get
            {
                return m_cmdOverride;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cmdOverride, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cmdOverride = value;
            }
        }

        /// <remarks />
        public AnalogItemState<byte[]> DryRunFeed
        {
            get
            {
                return m_dryRunFeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dryRunFeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dryRunFeed = value;
            }
        }

        /// <remarks />
        public DataItemState<bool> FeedHold
        {
            get
            {
                return m_feedHold;
            }

            set
            {
                if (!Object.ReferenceEquals(m_feedHold, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_feedHold = value;
            }
        }

        /// <remarks />
        public CncPositionVariableState PodTcpBcsX
        {
            get
            {
                return m_podTcpBcsX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_podTcpBcsX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_podTcpBcsX = value;
            }
        }

        /// <remarks />
        public CncPositionVariableState PodTcpBcsY
        {
            get
            {
                return m_podTcpBcsY;
            }

            set
            {
                if (!Object.ReferenceEquals(m_podTcpBcsY, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_podTcpBcsY = value;
            }
        }

        /// <remarks />
        public CncPositionVariableState PodTcpWcsX
        {
            get
            {
                return m_podTcpWcsX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_podTcpWcsX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_podTcpWcsX = value;
            }
        }

        /// <remarks />
        public CncPositionVariableState PodTcpWcsY
        {
            get
            {
                return m_podTcpWcsY;
            }

            set
            {
                if (!Object.ReferenceEquals(m_podTcpWcsY, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_podTcpWcsY = value;
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
            if (m_actFeedrate != null)
            {
                children.Add(m_actFeedrate);
            }

            if (m_actGFunctions != null)
            {
                children.Add(m_actGFunctions);
            }

            if (m_actJogIncrement != null)
            {
                children.Add(m_actJogIncrement);
            }

            if (m_actMainProgramFile != null)
            {
                children.Add(m_actMainProgramFile);
            }

            if (m_actMainProgramFileOffset != null)
            {
                children.Add(m_actMainProgramFileOffset);
            }

            if (m_actMainProgramLine != null)
            {
                children.Add(m_actMainProgramLine);
            }

            if (m_actMainProgramName != null)
            {
                children.Add(m_actMainProgramName);
            }

            if (m_actMFunctions != null)
            {
                children.Add(m_actMFunctions);
            }

            if (m_actOverride != null)
            {
                children.Add(m_actOverride);
            }

            if (m_actProgramBlock != null)
            {
                children.Add(m_actProgramBlock);
            }

            if (m_actProgramFile != null)
            {
                children.Add(m_actProgramFile);
            }

            if (m_actProgramFileOffset != null)
            {
                children.Add(m_actProgramFileOffset);
            }

            if (m_actProgramLine != null)
            {
                children.Add(m_actProgramLine);
            }

            if (m_actProgramName != null)
            {
                children.Add(m_actProgramName);
            }

            if (m_actProgramStatus != null)
            {
                children.Add(m_actProgramStatus);
            }

            if (m_actStatus != null)
            {
                children.Add(m_actStatus);
            }

            if (m_blockMode != null)
            {
                children.Add(m_blockMode);
            }

            if (m_cmdFeedrate != null)
            {
                children.Add(m_cmdFeedrate);
            }

            if (m_cmdOverride != null)
            {
                children.Add(m_cmdOverride);
            }

            if (m_dryRunFeed != null)
            {
                children.Add(m_dryRunFeed);
            }

            if (m_feedHold != null)
            {
                children.Add(m_feedHold);
            }

            if (m_podTcpBcsX != null)
            {
                children.Add(m_podTcpBcsX);
            }

            if (m_podTcpBcsY != null)
            {
                children.Add(m_podTcpBcsY);
            }

            if (m_podTcpWcsX != null)
            {
                children.Add(m_podTcpWcsX);
            }

            if (m_podTcpWcsY != null)
            {
                children.Add(m_podTcpWcsY);
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
                case Opc.Ua.CNC.BrowseNames.ActFeedrate:
                {
                    if (createOrReplace)
                    {
                        if (ActFeedrate == null)
                        {
                            if (replacement == null)
                            {
                                ActFeedrate = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActFeedrate = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActFeedrate;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActGFunctions:
                {
                    if (createOrReplace)
                    {
                        if (ActGFunctions == null)
                        {
                            if (replacement == null)
                            {
                                ActGFunctions = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActGFunctions = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActGFunctions;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActJogIncrement:
                {
                    if (createOrReplace)
                    {
                        if (ActJogIncrement == null)
                        {
                            if (replacement == null)
                            {
                                ActJogIncrement = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActJogIncrement = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActJogIncrement;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActMainProgramFile:
                {
                    if (createOrReplace)
                    {
                        if (ActMainProgramFile == null)
                        {
                            if (replacement == null)
                            {
                                ActMainProgramFile = new DataItemState<string>(this);
                            }
                            else
                            {
                                ActMainProgramFile = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = ActMainProgramFile;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActMainProgramFileOffset:
                {
                    if (createOrReplace)
                    {
                        if (ActMainProgramFileOffset == null)
                        {
                            if (replacement == null)
                            {
                                ActMainProgramFileOffset = new DataItemState<uint>(this);
                            }
                            else
                            {
                                ActMainProgramFileOffset = (DataItemState<uint>)replacement;
                            }
                        }
                    }

                    instance = ActMainProgramFileOffset;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActMainProgramLine:
                {
                    if (createOrReplace)
                    {
                        if (ActMainProgramLine == null)
                        {
                            if (replacement == null)
                            {
                                ActMainProgramLine = new DataItemState<string>(this);
                            }
                            else
                            {
                                ActMainProgramLine = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = ActMainProgramLine;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActMainProgramName:
                {
                    if (createOrReplace)
                    {
                        if (ActMainProgramName == null)
                        {
                            if (replacement == null)
                            {
                                ActMainProgramName = new DataItemState<string>(this);
                            }
                            else
                            {
                                ActMainProgramName = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = ActMainProgramName;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActMFunctions:
                {
                    if (createOrReplace)
                    {
                        if (ActMFunctions == null)
                        {
                            if (replacement == null)
                            {
                                ActMFunctions = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActMFunctions = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActMFunctions;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActOverride:
                {
                    if (createOrReplace)
                    {
                        if (ActOverride == null)
                        {
                            if (replacement == null)
                            {
                                ActOverride = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ActOverride = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ActOverride;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramBlock:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramBlock == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramBlock = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramBlock = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramBlock;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramFile:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramFile == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramFile = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramFile = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramFile;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramFileOffset:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramFileOffset == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramFileOffset = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramFileOffset = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramFileOffset;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramLine:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramLine == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramLine = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramLine = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramLine;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramName:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramName == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramName = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramName = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramName;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActProgramStatus:
                {
                    if (createOrReplace)
                    {
                        if (ActProgramStatus == null)
                        {
                            if (replacement == null)
                            {
                                ActProgramStatus = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActProgramStatus = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActProgramStatus;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.ActStatus:
                {
                    if (createOrReplace)
                    {
                        if (ActStatus == null)
                        {
                            if (replacement == null)
                            {
                                ActStatus = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                ActStatus = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = ActStatus;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.BlockMode:
                {
                    if (createOrReplace)
                    {
                        if (BlockMode == null)
                        {
                            if (replacement == null)
                            {
                                BlockMode = new DataItemState<byte[]>(this);
                            }
                            else
                            {
                                BlockMode = (DataItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = BlockMode;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.CmdFeedrate:
                {
                    if (createOrReplace)
                    {
                        if (CmdFeedrate == null)
                        {
                            if (replacement == null)
                            {
                                CmdFeedrate = new AnalogItemState<byte[]>(this);
                            }
                            else
                            {
                                CmdFeedrate = (AnalogItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = CmdFeedrate;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.CmdOverride:
                {
                    if (createOrReplace)
                    {
                        if (CmdOverride == null)
                        {
                            if (replacement == null)
                            {
                                CmdOverride = new AnalogItemState<byte[]>(this);
                            }
                            else
                            {
                                CmdOverride = (AnalogItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = CmdOverride;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.DryRunFeed:
                {
                    if (createOrReplace)
                    {
                        if (DryRunFeed == null)
                        {
                            if (replacement == null)
                            {
                                DryRunFeed = new AnalogItemState<byte[]>(this);
                            }
                            else
                            {
                                DryRunFeed = (AnalogItemState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = DryRunFeed;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.FeedHold:
                {
                    if (createOrReplace)
                    {
                        if (FeedHold == null)
                        {
                            if (replacement == null)
                            {
                                FeedHold = new DataItemState<bool>(this);
                            }
                            else
                            {
                                FeedHold = (DataItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = FeedHold;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.PodTcpBcsX:
                {
                    if (createOrReplace)
                    {
                        if (PodTcpBcsX == null)
                        {
                            if (replacement == null)
                            {
                                PodTcpBcsX = new CncPositionVariableState(this);
                            }
                            else
                            {
                                PodTcpBcsX = (CncPositionVariableState)replacement;
                            }
                        }
                    }

                    instance = PodTcpBcsX;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.PodTcpBcsY:
                {
                    if (createOrReplace)
                    {
                        if (PodTcpBcsY == null)
                        {
                            if (replacement == null)
                            {
                                PodTcpBcsY = new CncPositionVariableState(this);
                            }
                            else
                            {
                                PodTcpBcsY = (CncPositionVariableState)replacement;
                            }
                        }
                    }

                    instance = PodTcpBcsY;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.PodTcpWcsX:
                {
                    if (createOrReplace)
                    {
                        if (PodTcpWcsX == null)
                        {
                            if (replacement == null)
                            {
                                PodTcpWcsX = new CncPositionVariableState(this);
                            }
                            else
                            {
                                PodTcpWcsX = (CncPositionVariableState)replacement;
                            }
                        }
                    }

                    instance = PodTcpWcsX;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.PodTcpWcsY:
                {
                    if (createOrReplace)
                    {
                        if (PodTcpWcsY == null)
                        {
                            if (replacement == null)
                            {
                                PodTcpWcsY = new CncPositionVariableState(this);
                            }
                            else
                            {
                                PodTcpWcsY = (CncPositionVariableState)replacement;
                            }
                        }
                    }

                    instance = PodTcpWcsY;
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
        private AnalogItemState<double> m_actFeedrate;
        private DataItemState<byte[]> m_actGFunctions;
        private AnalogItemState<double> m_actJogIncrement;
        private DataItemState<string> m_actMainProgramFile;
        private DataItemState<uint> m_actMainProgramFileOffset;
        private DataItemState<string> m_actMainProgramLine;
        private DataItemState<string> m_actMainProgramName;
        private DataItemState<byte[]> m_actMFunctions;
        private AnalogItemState<double> m_actOverride;
        private DataItemState<byte[]> m_actProgramBlock;
        private DataItemState<byte[]> m_actProgramFile;
        private DataItemState<byte[]> m_actProgramFileOffset;
        private DataItemState<byte[]> m_actProgramLine;
        private DataItemState<byte[]> m_actProgramName;
        private DataItemState<byte[]> m_actProgramStatus;
        private DataItemState<byte[]> m_actStatus;
        private DataItemState<byte[]> m_blockMode;
        private AnalogItemState<byte[]> m_cmdFeedrate;
        private AnalogItemState<byte[]> m_cmdOverride;
        private AnalogItemState<byte[]> m_dryRunFeed;
        private DataItemState<bool> m_feedHold;
        private CncPositionVariableState m_podTcpBcsX;
        private CncPositionVariableState m_podTcpBcsY;
        private CncPositionVariableState m_podTcpWcsX;
        private CncPositionVariableState m_podTcpWcsY;
        #endregion
    }
    #endif
    #endregion

    #region CncChannelListState Class
    #if (!OPCUA_EXCLUDE_CncChannelListState)
    /// <summary>
    /// Stores an instance of the CncChannelListType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncChannelListState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncChannelListState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncChannelListType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////BGCAAgEAAAABABoAAABD" +
           "bmNDaGFubmVsTGlzdFR5cGVJbnN0YW5jZQEB8gMBAfID8gMAAP////8AAAAA";
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

    #region CncInterfaceState Class
    #if (!OPCUA_EXCLUDE_CncInterfaceState)
    /// <summary>
    /// Stores an instance of the CncInterfaceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CncInterfaceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CncInterfaceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.CNC.ObjectTypes.CncInterfaceType, Opc.Ua.CNC.Namespaces.OpcUaCNC, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL0NOQy//////hGCAAgEAAAABABgAAABD" +
           "bmNJbnRlcmZhY2VUeXBlSW5zdGFuY2UBAe8DAQHvA+8DAAABAQAAAAAtAAA6BwAAAARggAoBAAAAAQAL" +
           "AAAAQ25jQXhpc0xpc3QBAUQ7AC8BAfADRDsAAAIAAAAALQAAOgAjAABVAAAAAARggAoBAAAAAQAOAAAA" +
           "Q25jQ2hhbm5lbExpc3QBAYA7AC8BAfIDgDsAAP////8AAAAAFWCJCgIAAAABAAsAAABDbmNUeXBlTmFt" +
           "ZQEBRTsALwA/RTsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAAwAAAEZpeAEBRjsALwA/RjsAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAFZlbmRvck5hbWUBAUc7AC8AP0c7AAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAA4AAABWZW5kb3JSZXZpc2lvbgEBSDsALwA/SDsAAAAM/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAFZlcnNpb24BAUk7AC8AP0k7AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CncAxisListState CncAxisList
        {
            get
            {
                return m_cncAxisList;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cncAxisList, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cncAxisList = value;
            }
        }

        /// <remarks />
        public CncChannelListState CncChannelList
        {
            get
            {
                return m_cncChannelList;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cncChannelList, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cncChannelList = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> CncTypeName
        {
            get
            {
                return m_cncTypeName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cncTypeName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cncTypeName = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Fix
        {
            get
            {
                return m_fix;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fix, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fix = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> VendorName
        {
            get
            {
                return m_vendorName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vendorName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vendorName = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> VendorRevision
        {
            get
            {
                return m_vendorRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vendorRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vendorRevision = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Version
        {
            get
            {
                return m_version;
            }

            set
            {
                if (!Object.ReferenceEquals(m_version, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_version = value;
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
            if (m_cncAxisList != null)
            {
                children.Add(m_cncAxisList);
            }

            if (m_cncChannelList != null)
            {
                children.Add(m_cncChannelList);
            }

            if (m_cncTypeName != null)
            {
                children.Add(m_cncTypeName);
            }

            if (m_fix != null)
            {
                children.Add(m_fix);
            }

            if (m_vendorName != null)
            {
                children.Add(m_vendorName);
            }

            if (m_vendorRevision != null)
            {
                children.Add(m_vendorRevision);
            }

            if (m_version != null)
            {
                children.Add(m_version);
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
                case Opc.Ua.CNC.BrowseNames.CncAxisList:
                {
                    if (createOrReplace)
                    {
                        if (CncAxisList == null)
                        {
                            if (replacement == null)
                            {
                                CncAxisList = new CncAxisListState(this);
                            }
                            else
                            {
                                CncAxisList = (CncAxisListState)replacement;
                            }
                        }
                    }

                    instance = CncAxisList;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.CncChannelList:
                {
                    if (createOrReplace)
                    {
                        if (CncChannelList == null)
                        {
                            if (replacement == null)
                            {
                                CncChannelList = new CncChannelListState(this);
                            }
                            else
                            {
                                CncChannelList = (CncChannelListState)replacement;
                            }
                        }
                    }

                    instance = CncChannelList;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.CncTypeName:
                {
                    if (createOrReplace)
                    {
                        if (CncTypeName == null)
                        {
                            if (replacement == null)
                            {
                                CncTypeName = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                CncTypeName = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = CncTypeName;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.Fix:
                {
                    if (createOrReplace)
                    {
                        if (Fix == null)
                        {
                            if (replacement == null)
                            {
                                Fix = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Fix = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Fix;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.VendorName:
                {
                    if (createOrReplace)
                    {
                        if (VendorName == null)
                        {
                            if (replacement == null)
                            {
                                VendorName = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                VendorName = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = VendorName;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.VendorRevision:
                {
                    if (createOrReplace)
                    {
                        if (VendorRevision == null)
                        {
                            if (replacement == null)
                            {
                                VendorRevision = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                VendorRevision = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = VendorRevision;
                    break;
                }

                case Opc.Ua.CNC.BrowseNames.Version:
                {
                    if (createOrReplace)
                    {
                        if (Version == null)
                        {
                            if (replacement == null)
                            {
                                Version = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Version = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Version;
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
        private CncAxisListState m_cncAxisList;
        private CncChannelListState m_cncChannelList;
        private BaseDataVariableState<string> m_cncTypeName;
        private BaseDataVariableState<string> m_fix;
        private BaseDataVariableState<string> m_vendorName;
        private BaseDataVariableState<string> m_vendorRevision;
        private BaseDataVariableState<string> m_version;
        #endregion
    }
    #endif
    #endregion
}
