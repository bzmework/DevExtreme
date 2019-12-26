namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of the shape's connection points.</summary>
	public class DiagramCustomShapesConnectionPointBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DiagramCustomShapesConnectionPointBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramCustomShapesConnectionPointBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset.</summary>
		[Generated]
		public DiagramCustomShapesConnectionPointBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset.</summary>
		[Generated]
		public DiagramCustomShapesConnectionPointBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset.</summary>
		[Generated]
		public DiagramCustomShapesConnectionPointBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset.</summary>
		[Generated]
		public DiagramCustomShapesConnectionPointBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
