namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies an auto-layout algorithm that the widget uses to build a diagram.</summary>
	public class DiagramNodesAutoLayoutBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramNodesAutoLayoutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramNodesAutoLayoutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the diagram layout orientation.</summary>
		[Generated]
		public DiagramNodesAutoLayoutBuilder Orientation(DiagramDataLayoutOrientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Specifies the diagram layout type.</summary>
		[Generated]
		public DiagramNodesAutoLayoutBuilder Type(DiagramDataLayoutType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
