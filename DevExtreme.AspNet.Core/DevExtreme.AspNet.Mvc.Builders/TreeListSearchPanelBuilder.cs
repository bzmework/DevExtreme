namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the search panel.</summary>
	public class TreeListSearchPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListSearchPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Notifies the widget whether search is case-sensitive to ensure that search results are highlighted correctly. Applies only if highlightSearchText is true.</summary>
		[Generated]
		public TreeListSearchPanelBuilder HighlightCaseSensitive(bool value)
		{
			base.Options["highlightCaseSensitive"] = value;
			return this;
		}

		/// <summary>Notifies the widget whether search is case-sensitive to ensure that search results are highlighted correctly. Applies only if highlightSearchText is true.</summary>
		[Generated]
		public TreeListSearchPanelBuilder HighlightCaseSensitive(JS value)
		{
			base.Options["highlightCaseSensitive"] = value;
			return this;
		}

		/// <summary>Specifies whether found substrings should be highlighted.</summary>
		[Generated]
		public TreeListSearchPanelBuilder HighlightSearchText(bool value)
		{
			base.Options["highlightSearchText"] = value;
			return this;
		}

		/// <summary>Specifies whether found substrings should be highlighted.</summary>
		[Generated]
		public TreeListSearchPanelBuilder HighlightSearchText(JS value)
		{
			base.Options["highlightSearchText"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the search panel.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the search panel.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should search against all columns or only visible ones.</summary>
		[Generated]
		public TreeListSearchPanelBuilder SearchVisibleColumnsOnly(bool value)
		{
			base.Options["searchVisibleColumnsOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should search against all columns or only visible ones.</summary>
		[Generated]
		public TreeListSearchPanelBuilder SearchVisibleColumnsOnly(JS value)
		{
			base.Options["searchVisibleColumnsOnly"] = value;
			return this;
		}

		/// <summary>Sets a search string for the search panel.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Sets a search string for the search panel.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether the search panel is visible or not.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the search panel is visible or not.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the search panel in pixels.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the search panel in pixels.</summary>
		[Generated]
		public TreeListSearchPanelBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
