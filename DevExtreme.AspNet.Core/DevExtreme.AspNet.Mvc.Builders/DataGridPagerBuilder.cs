using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the pager.</summary>
	public class DataGridPagerBuilder : OptionsOwnerBuilder
	{
		/// <summary>Specifies whether the pager is visible.</summary>
		[Obsolete("Use Visible(bool value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataGridPagerBuilder Visible(string value)
		{
			base.Options["visible"] = value;
			return this;
		}

		[Generated]
		public DataGridPagerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridPagerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the available page sizes in the page size selector.</summary>
		[Generated]
		public DataGridPagerBuilder AllowedPageSizes(IEnumerable<int> value)
		{
			base.Options["allowedPageSizes"] = value;
			return this;
		}

		/// <summary>Specifies the available page sizes in the page size selector.</summary>
		[Generated]
		public DataGridPagerBuilder AllowedPageSizes(JS value)
		{
			base.Options["allowedPageSizes"] = value;
			return this;
		}

		/// <summary>Specifies the page information text.</summary>
		[Generated]
		public DataGridPagerBuilder InfoText(string value)
		{
			base.Options["infoText"] = value;
			return this;
		}

		/// <summary>Specifies the page information text.</summary>
		[Generated]
		public DataGridPagerBuilder InfoText(JS value)
		{
			base.Options["infoText"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page information.</summary>
		[Generated]
		public DataGridPagerBuilder ShowInfo(bool value)
		{
			base.Options["showInfo"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page information.</summary>
		[Generated]
		public DataGridPagerBuilder ShowInfo(JS value)
		{
			base.Options["showInfo"] = value;
			return this;
		}

		/// <summary>Specifies whether to show navigation buttons.</summary>
		[Generated]
		public DataGridPagerBuilder ShowNavigationButtons(bool value)
		{
			base.Options["showNavigationButtons"] = value;
			return this;
		}

		/// <summary>Specifies whether to show navigation buttons.</summary>
		[Generated]
		public DataGridPagerBuilder ShowNavigationButtons(JS value)
		{
			base.Options["showNavigationButtons"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page size selector.</summary>
		[Generated]
		public DataGridPagerBuilder ShowPageSizeSelector(bool value)
		{
			base.Options["showPageSizeSelector"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the page size selector.</summary>
		[Generated]
		public DataGridPagerBuilder ShowPageSizeSelector(JS value)
		{
			base.Options["showPageSizeSelector"] = value;
			return this;
		}

		/// <summary>Specifies whether the pager is visible.</summary>
		[Generated]
		public DataGridPagerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the pager is visible.</summary>
		[Generated]
		public DataGridPagerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
