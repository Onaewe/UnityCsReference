// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Linq;
using UnityEngine.UIElements;

namespace Unity.GraphToolsFoundation.Editor
{
    /// <summary>
    /// A part to build the UI for the horizontal ports of a node, with the input ports on the left and the output ports on the right.
    /// </summary>
    class InOutPortContainerPart : BasePortContainerPart
    {
        public static readonly string ussClassName = "ge-in-out-port-container-part";
        public static readonly string inputPortsUssName = "inputs";
        public static readonly string outputPortsUssName = "outputs";

        /// <summary>
        /// Initializes a new instance of the <see cref="InOutPortContainerPart"/> class.
        /// </summary>
        /// <param name="name">The name of the part.</param>
        /// <param name="model">The model displayed in this part.</param>
        /// <param name="ownerElement">The owner of the part.</param>
        /// <param name="maxInputLabelWidth">Maximum input ports label width.</param>
        /// <param name="parentClassName">The class name of the parent.</param>
        /// <param name="portFilter">A filter used to select the ports to display in the container.</param>
        /// <returns>A new instance of <see cref="InOutPortContainerPart"/>.</returns>
        public static InOutPortContainerPart Create(string name, Model model, ModelView ownerElement,
            float maxInputLabelWidth, string parentClassName, Func<PortModel, bool> portFilter = null)
        {
            return model is PortNodeModel
                ? new InOutPortContainerPart(name, model, ownerElement, maxInputLabelWidth, parentClassName, portFilter)
                : null;
        }

        protected PortContainer InputPortContainer
        {
            get => PortContainer;
            set => PortContainer = value;
        }

        protected PortContainer OutputPortContainer { get; set; }

        readonly float m_MaxInputLabelWidth;

        /// <summary>
        /// Initializes a new instance of the <see cref="InOutPortContainerPart"/> class.
        /// </summary>
        /// <param name="name">The name of the part.</param>
        /// <param name="model">The model displayed in this part.</param>
        /// <param name="ownerElement">The owner of the part.</param>
        /// <param name="maxInputLabelWidth">Maximum width in pixels for the port label.</param>
        /// <param name="parentClassName">The class name of the parent.</param>
        /// <param name="portFilter">A filter used to select the ports to display in the container.</param>
        protected InOutPortContainerPart(string name, Model model, ModelView ownerElement, float maxInputLabelWidth, string parentClassName, Func<PortModel, bool> portFilter)
            : base(name, model, ownerElement, parentClassName, null, null,
                portFilter == null ? horizontalPortFilter : p => horizontalPortFilter(p) && portFilter(p))
        {
            m_MaxInputLabelWidth = maxInputLabelWidth;
        }

        /// <inheritdoc />
        protected override void BuildPartUI(VisualElement container)
        {
            if (m_Model is PortNodeModel)
            {
                m_Root = new VisualElement { name = PartName };
                m_Root.AddToClassList(ussClassName);
                m_Root.AddToClassList(m_ParentClassName.WithUssElement(PartName));

                InputPortContainer = new PortContainer(true, m_MaxInputLabelWidth) { name = inputPortsUssName };
                InputPortContainer.AddToClassList(m_ParentClassName.WithUssElement(inputPortsUssName));
                m_Root.Add(InputPortContainer);

                OutputPortContainer = new PortContainer { name = outputPortsUssName };
                OutputPortContainer.AddToClassList(m_ParentClassName.WithUssElement(outputPortsUssName));
                m_Root.Add(OutputPortContainer);

                container.Add(m_Root);
            }
        }

        /// <inheritdoc />
        protected override void UpdatePartFromModel()
        {
            switch (m_Model)
            {
                // TODO: Reinstate.
                // case ISingleInputPortNode inputPortHolder:
                //     m_InputPortContainer?.UpdatePorts(new[] { inputPortHolder.InputPort }, m_OwnerElement.GraphView, m_OwnerElement.CommandDispatcher);
                //     break;
                // case ISingleOutputPortNode outputPortHolder:
                //     m_OutputPortContainer?.UpdatePorts(new[] { outputPortHolder.OutputPort }, m_OwnerElement.GraphView, m_OwnerElement.CommandDispatcher);
                //     break;
                case InputOutputPortsNodeModel portHolder:
                    InputPortContainer?.UpdatePorts(portHolder.GetInputPorts().Where(PortFilter), m_OwnerElement.RootView);
                    OutputPortContainer?.UpdatePorts(portHolder.GetOutputPorts().Where(PortFilter), m_OwnerElement.RootView);
                    break;
            }
        }
    }
}