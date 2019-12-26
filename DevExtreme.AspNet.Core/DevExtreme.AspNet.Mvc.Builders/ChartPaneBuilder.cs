using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Declares a collection of panes.</summary>
	public class ChartPaneBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartPaneBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartPaneBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane's background.</summary>
		[Generated]
		public ChartPaneBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane's background.</summary>
		[Generated]
		public ChartPaneBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the pane border.</summary>
		[Generated]
		public ChartPaneBuilder Border(Action<ChartPanesBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the pane's height (or width when the chart is rotated) in a multi-pane chart.</summary>
		[Generated]
		public ChartPaneBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the pane's height (or width when the chart is rotated) in a multi-pane chart.</summary>
		[Generated]
		public ChartPaneBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the pane's height (or width when the chart is rotated) in a multi-pane chart.</summary>
		[Generated]
		public ChartPaneBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the name of the pane.</summary>
		[Generated]
		public ChartPaneBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the name of the pane.</summary>
		[Generated]
		public ChartPaneBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
