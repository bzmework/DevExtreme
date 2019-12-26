using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the pager.</summary>
	public class TreeListPagerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListPagerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListPagerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the available page sizes in the page size selector.</summary>
		[Generated]
		public TreeListPagerBuilder AllowedPageSizes(IEnumerable<int> value)
		{
			base.Options["allowedPageSizes"] = value;
			return this;
		}

		/// <summary>Specifies the available page sizes in the page size selector.</summary>
		[Generated]
		public TreeListPagerBuilder AllowedPageSizes(JS value)
		{
			base.Options["allowedPageSizes"] = value;
			return this;
		}

		/// <summary>Specifies the page information text.</summary>
		[Generated]
		public TreeListPagerBuilder InfoText(string value)
		{
			base.Options["infoText"] = value;
			return this;
		}

		/// <summary>Specifies the page information text.</summary>
		[Generated]
		public TreeListPagerBuilder InfoText(JS value)
		{
			base.Options["infoText"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page information.</summary>
		[Generated]
		public TreeListPagerBuilder ShowInfo(bool value)
		{
			base.Options["showInfo"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page information.</summary>
		[Generated]
		public TreeListPagerBuilder ShowInfo(JS value)
		{
			base.Options["showInfo"] = value;
			return this;
		}

		/// <summary>Specifies whether to show navigation buttons.</summary>
		[Generated]
		public TreeListPagerBuilder ShowNavigationButtons(bool value)
		{
			base.Options["showNavigationButtons"] = value;
			return this;
		}

		/// <summary>Specifies whether to show navigation buttons.</summary>
		[Generated]
		public TreeListPagerBuilder ShowNavigationButtons(JS value)
		{
			base.Options["showNavigationButtons"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page size selector.</summary>
		[Generated]
		public TreeListPagerBuilder ShowPageSizeSelector(bool value)
		{
			base.Options["showPageSizeSelector"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page size selector.</summary>
		[Generated]
		public TreeListPagerBuilder ShowPageSizeSelector(JS value)
		{
			base.Options["showPageSizeSelector"] = value;
			return this;
		}

		/// <summary>Specifies whether the pager is visible.</summary>
		[Generated]
		public TreeListPagerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the pager is visible.</summary>
		[Generated]
		public TreeListPagerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
