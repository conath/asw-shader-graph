<<<<<<< HEAD
using UnityEngine;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor.Graphing;
using UnityEditor.ShaderGraph.Drawing.Colors;
using UnityEditor.ShaderGraph.Internal;
using UnityEditor.ShaderGraph.Drawing;
using UnityEditor.ShaderGraph.Serialization;
using UnityEngine.Assertions;
using UnityEngine.Pool;
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76

namespace UnityEditor.ShaderGraph
{
    interface IRectInterface
    {
        Rect rect
        {
            get;
            internal set;
        }
    }
}
