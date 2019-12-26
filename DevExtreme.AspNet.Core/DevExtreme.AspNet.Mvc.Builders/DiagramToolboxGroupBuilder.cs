using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Lists toolbox groups.</summary>
	public class DiagramToolboxGroupBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DiagramToolboxGroupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the category of shapes that are displayed in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Category(DiagramShapeCategory value)
		{
			base.Options["category"] = value;
			return this;
		}

		/// <summary>Specifies the category of shapes that are displayed in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Category(string value)
		{
			base.Options["category"] = value;
			return this;
		}

		/// <summary>Specifies the category of shapes that are displayed in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Category(JS value)
		{
			base.Options["category"] = value;
			return this;
		}

		/// <summary>Specifies how shapes are displayed in the toolbox.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder DisplayMode(DiagramToolboxDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies whether the group is expanded.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Expanded(bool value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Specifies whether the group is expanded.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Expanded(JS value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Lists the shapes in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Shapes(IEnumerable<DiagramShapeType> value)
		{
			base.Options["shapes"] = value;
			return this;
		}

		/// <summary>Lists the shapes in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Shapes(IEnumerable<string> value)
		{
			base.Options["shapes"] = value;
			return this;
		}

		/// <summary>Lists the shapes in the group.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Shapes(JS value)
		{
			base.Options["shapes"] = value;
			return this;
		}

		/// <summary>Specifies the group title in the toolbox.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the group title in the toolbox.</summary>
		[Generated]
		public DiagramToolboxGroupBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}
	}
}
