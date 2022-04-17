using System;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

namespace UnityEditor.ShaderGraph
{
    [Serializable]
    abstract class MatrixShaderProperty : AbstractShaderProperty<Matrix4x4>
    {
        internal override bool isExposable => false;
        internal override bool isRenamable => true;

<<<<<<< HEAD
        internal override string GetHLSLVariableName(bool isSubgraphProperty)
=======
        internal override string GetHLSLVariableName(bool isSubgraphProperty, GenerationMode mode)
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        {
            HLSLDeclaration decl = GetDefaultHLSLDeclaration();
            if (decl == HLSLDeclaration.HybridPerInstance)
                return $"UNITY_ACCESS_HYBRID_INSTANCED_PROP({referenceName}, {concretePrecision.ToShaderString()}4x4)";
            else
<<<<<<< HEAD
                return referenceName;
=======
                return base.GetHLSLVariableName(isSubgraphProperty, mode);
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }

        internal override HLSLDeclaration GetDefaultHLSLDeclaration()
        {
            if (overrideHLSLDeclaration)
                return hlslDeclarationOverride;

            // Since Matrices cannot be exposed, the default declaration rules would set them to Global.
            // However, this means new Matrix properties would be different from all other float-based property types
            // (all others use UnityPerMaterial by default, because they are exposed).
            // So instead, we override the default rules so that Matrices always default to UnityPerMaterial
            return HLSLDeclaration.UnityPerMaterial;
        }

        internal override void ForeachHLSLProperty(Action<HLSLProperty> action)
        {
            HLSLDeclaration decl = GetDefaultHLSLDeclaration();

            // HLSL decl is always 4x4 even if matrix smaller
            action(new HLSLProperty(HLSLType._matrix4x4, referenceName, decl, concretePrecision));
        }
    }
}
