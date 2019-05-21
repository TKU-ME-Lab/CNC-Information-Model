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
    #region CncPositionDataType Class
    #if (!OPCUA_EXCLUDE_CncPositionDataType)
    /// <summary>
    /// Structure of position elements.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.CNC.Namespaces.OpcUaCNC)]
    public partial class CncPositionDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CncPositionDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_actPos = (double)0;
            m_cmdPos = (double)0;
            m_remDist = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ActPos", IsRequired = false, Order = 1)]
        public double ActPos
        {
            get { return m_actPos;  }
            set { m_actPos = value; }
        }

        /// <remarks />
        [DataMember(Name = "CmdPos", IsRequired = false, Order = 2)]
        public double CmdPos
        {
            get { return m_cmdPos;  }
            set { m_cmdPos = value; }
        }

        /// <remarks />
        [DataMember(Name = "RemDist", IsRequired = false, Order = 3)]
        public double RemDist
        {
            get { return m_remDist;  }
            set { m_remDist = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CncPositionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CncPositionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CncPositionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.CNC.Namespaces.OpcUaCNC);

            encoder.WriteDouble("ActPos", ActPos);
            encoder.WriteDouble("CmdPos", CmdPos);
            encoder.WriteDouble("RemDist", RemDist);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.CNC.Namespaces.OpcUaCNC);

            ActPos = decoder.ReadDouble("ActPos");
            CmdPos = decoder.ReadDouble("CmdPos");
            RemDist = decoder.ReadDouble("RemDist");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CncPositionDataType value = encodeable as CncPositionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_actPos, value.m_actPos)) return false;
            if (!Utils.IsEqual(m_cmdPos, value.m_cmdPos)) return false;
            if (!Utils.IsEqual(m_remDist, value.m_remDist)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CncPositionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CncPositionDataType clone = (CncPositionDataType)base.MemberwiseClone();

            clone.m_actPos = (double)Utils.Clone(this.m_actPos);
            clone.m_cmdPos = (double)Utils.Clone(this.m_cmdPos);
            clone.m_remDist = (double)Utils.Clone(this.m_remDist);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_actPos;
        private double m_cmdPos;
        private double m_remDist;
        #endregion
    }

    #region CncPositionDataTypeCollection Class
    /// <summary>
    /// A collection of CncPositionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCncPositionDataType", Namespace = Opc.Ua.CNC.Namespaces.OpcUaCNC, ItemName = "CncPositionDataType")]
    #if !NET_STANDARD
    public partial class CncPositionDataTypeCollection : List<CncPositionDataType>, ICloneable
    #else
    public partial class CncPositionDataTypeCollection : List<CncPositionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CncPositionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CncPositionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CncPositionDataTypeCollection(IEnumerable<CncPositionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CncPositionDataTypeCollection(CncPositionDataType[] values)
        {
            if (values != null)
            {
                return new CncPositionDataTypeCollection(values);
            }

            return new CncPositionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CncPositionDataType[](CncPositionDataTypeCollection values)
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
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CncPositionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CncPositionDataTypeCollection clone = new CncPositionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CncPositionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
