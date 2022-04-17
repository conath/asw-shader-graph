using System;
using UnityEditor.Graphing;
using UnityEngine;

namespace UnityEditor.ShaderGraph
{
    [Serializable]
    class Texture2DMaterialSlot : MaterialSlot
    {
        public Texture2DMaterialSlot()
        { }

        public Texture2DMaterialSlot(
            int slotId,
            string displayName,
            string shaderOutputName,
            SlotType slotType,
            ShaderStageCapability stageCapability = ShaderStageCapability.All,
            bool hidden = false)
            : base(slotId, displayName, shaderOutputName, slotType, stageCapability, hidden)
        { }

        [SerializeField]
        bool m_BareResource = false;
        internal override bool bareResource
        {
            get { return m_BareResource; }
            set { m_BareResource = value; }
        }

        public override void AppendHLSLParameterDeclaration(ShaderStringBuilder sb, string paramName)
        {
            if (m_BareResource)
            {
                sb.Append("TEXTURE2D(");
                sb.Append(paramName);
                sb.Append(")");
            }
            else
                base.AppendHLSLParameterDeclaration(sb, paramName);
        }

        [SerializeField]
        bool m_BareResource = false;
        internal override bool bareResource
        {
            get { return m_BareResource; }
            set { m_BareResource = value; }
        }

        public override void AppendHLSLParameterDeclaration(ShaderStringBuilder sb, string paramName)
        {
            if (m_BareResource)
            {
                sb.Append("TEXTURE2D(");
                sb.Append(paramName);
                sb.Append(")");
            }
            else
                base.AppendHLSLParameterDeclaration(sb, paramName);
        }

        public override SlotValueType valueType { get { return SlotValueType.Texture2D; } }
        public override ConcreteSlotValueType concreteValueType { get { return ConcreteSlotValueType.Texture2D; } }
        public override bool isDefaultValue => true;

        public override void AddDefaultProperty(PropertyCollector properties, GenerationMode generationMode)
        { }

        public override void CopyValuesFrom(MaterialSlot foundSlot)
        {
            var slot = foundSlot as Texture2DMaterialSlot;
            if (slot != null)
            {
                m_BareResource = slot.m_BareResource;
            }
        }
    }
}
