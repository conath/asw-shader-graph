using System;
using System.Text;
using UnityEditor.Graphing;
using UnityEngine;

namespace UnityEditor.ShaderGraph.Internal
{
    [Serializable]
    public abstract class VectorShaderProperty : AbstractShaderProperty<Vector4>
    {
        internal override bool isExposable => true;
        internal override bool isRenamable => true;
        internal virtual int vectorDimension => 4;

<<<<<<< HEAD
        internal override string GetHLSLVariableName(bool isSubgraphProperty)
=======
        internal override string GetHLSLVariableName(bool isSubgraphProperty, GenerationMode mode)
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        {
            HLSLDeclaration decl = GetDefaultHLSLDeclaration();
            if (decl == HLSLDeclaration.HybridPerInstance)
                return $"UNITY_ACCESS_HYBRID_INSTANCED_PROP({referenceName}, {concretePrecision.ToShaderString()}{vectorDimension})";
            else
<<<<<<< HEAD
                return referenceName;
=======
                return base.GetHLSLVariableName(isSubgraphProperty, mode);
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }

        internal override string GetPropertyBlockString()
        {
            return $"{hideTagString}{referenceName}(\"{displayName}\", Vector) = ({NodeUtils.FloatToShaderValueShaderLabSafe(value.x)}, {NodeUtils.FloatToShaderValueShaderLabSafe(value.y)}, {NodeUtils.FloatToShaderValueShaderLabSafe(value.z)}, {NodeUtils.FloatToShaderValueShaderLabSafe(value.w)})";
        }

<<<<<<< HEAD
        internal override string GetPropertyAsArgumentString()
        {
            return $"{concreteShaderValueType.ToShaderString(concretePrecision.ToShaderString())} {referenceName}";
=======
        internal override string GetPropertyAsArgumentString(string precisionString)
        {
            return $"{concreteShaderValueType.ToShaderString(precisionString)} {referenceName}";
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }
    }
}
