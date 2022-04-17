using UnityEditor.Experimental.GraphView;

namespace UnityEditor.ShaderGraph.Drawing.Interfaces
{
    interface ISGResizable : IResizable
    {
<<<<<<< HEAD
        // Depending on the return value, the ElementResizer either allows resizing past parent view edge (like in case of StickyNote) or clamps the size at the edges of parent view (like in the Graph Inspector)
=======
        // Depending on the return value, the ElementResizer either allows resizing past parent view edge (like in case of StickyNote) or clamps the size at the edges of parent view (like for GraphSubWindows)
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        bool CanResizePastParentBounds();
    }
}
