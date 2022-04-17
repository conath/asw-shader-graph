using System.Collections.Generic;
using UnityEditor.ShaderGraph.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing
{
    class ResizableElementFactory : UxmlFactory<ResizableElement>
<<<<<<< HEAD
    {}
=======
    { }
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76

    class ResizableElement : VisualElement
    {
        Dictionary<Resizer, VisualElement> m_Resizers = new Dictionary<Resizer, VisualElement>();

        List<Manipulator> m_Manipulators = new List<Manipulator>();
<<<<<<< HEAD

=======
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        public ResizableElement() : this("uxml/Resizable")
        {
            pickingMode = PickingMode.Ignore;
        }

        public ResizableElement(string uiFile)
        {
            var tpl = Resources.Load<VisualTreeAsset>(uiFile);
            var sheet = Resources.Load<StyleSheet>("Resizable");
            styleSheets.Add(sheet);

            tpl.CloneTree(this);

<<<<<<< HEAD
            foreach (Resizer direction in new[] {Resizer.Top, Resizer.Bottom, Resizer.Left, Resizer.Right})
=======
            foreach (Resizer direction in new[] { Resizer.Top, Resizer.Bottom, Resizer.Left, Resizer.Right })
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
            {
                VisualElement resizer = this.Q(direction.ToString().ToLower() + "-resize");
                if (resizer != null)
                {
                    var manipulator = new ElementResizer(this, direction);
                    resizer.AddManipulator(manipulator);
                    m_Manipulators.Add(manipulator);
                }
                m_Resizers[direction] = resizer;
            }

<<<<<<< HEAD
            foreach (Resizer vertical in new[] {Resizer.Top, Resizer.Bottom})
            foreach (Resizer horizontal in new[] {Resizer.Left, Resizer.Right})
            {
                VisualElement resizer = this.Q(vertical.ToString().ToLower() + "-" + horizontal.ToString().ToLower() + "-resize");
                if (resizer != null)
                {
                    var manipulator = new ElementResizer(this, vertical | horizontal);
                    resizer.AddManipulator(manipulator);
                    m_Manipulators.Add(manipulator);
                }
                m_Resizers[vertical | horizontal] = resizer;
            }
=======
            foreach (Resizer vertical in new[] { Resizer.Top, Resizer.Bottom })
                foreach (Resizer horizontal in new[] { Resizer.Left, Resizer.Right })
                {
                    VisualElement resizer = this.Q(vertical.ToString().ToLower() + "-" + horizontal.ToString().ToLower() + "-resize");
                    if (resizer != null)
                    {
                        var manipulator = new ElementResizer(this, vertical | horizontal);
                        resizer.AddManipulator(manipulator);
                        m_Manipulators.Add(manipulator);
                    }
                    m_Resizers[vertical | horizontal] = resizer;
                }
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }

        public void SetResizeRules(Resizer allowedResizeDirections)
        {
            foreach (var manipulator in m_Manipulators)
            {
                if (manipulator == null)
                    return;
                var resizeElement = manipulator as ElementResizer;
                // If resizer direction is not in list of allowed directions, disable the callbacks on it
                if ((resizeElement.direction & allowedResizeDirections) == 0)
                {
                    resizeElement.isEnabled = false;
                }
                else if ((resizeElement.direction & allowedResizeDirections) != 0)
                {
                    resizeElement.isEnabled = true;
                }
            }
        }

        public enum Resizer
        {
<<<<<<< HEAD
            None =          0,
            Top =           1 << 0,
            Bottom =        1 << 1,
            Left =          1 << 2,
            Right =         1 << 3,
=======
            None = 0,
            Top = 1 << 0,
            Bottom = 1 << 1,
            Left = 1 << 2,
            Right = 1 << 3,
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }

        // Lets visual element owners bind a callback to when any resize operation is completed
        public void BindOnResizeCallback(EventCallback<MouseUpEvent> mouseUpEvent)
        {
            foreach (var manipulator in m_Manipulators)
            {
                if (manipulator == null)
                    return;
                manipulator.target.RegisterCallback(mouseUpEvent);
            }
        }
    }
}
