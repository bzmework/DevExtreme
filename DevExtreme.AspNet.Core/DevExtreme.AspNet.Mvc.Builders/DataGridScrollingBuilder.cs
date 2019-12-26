using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures scrolling.</summary>
	public class DataGridScrollingBuilder : OptionsOwnerBuilder
	{
		/// <summary>Specifies whether the widget should use native or simulated scrolling.</summary>
		[Obsolete("Use UseNative(bool value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataGridScrollingBuilder UseNative(string value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		[Generated]
		public DataGridScrollingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridScrollingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the rendering mode for columns. Applies when columns are left outside the viewport. Requires the columnWidth, columnAutoWidth, or width (for all columns) option specified.</summary>
		[Generated]
		public DataGridScrollingBuilder ColumnRenderingMode(GridColumnRenderingMode value)
		{
			base.Options["columnRenderingMode"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling mode.</summary>
		[Generated]
		public DataGridScrollingBuilder Mode(GridScrollingMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should load adjacent pages. Applies only if scrolling.mode is "virtual" or "infinite".</summary>
		[Generated]
		public DataGridScrollingBuilder PreloadEnabled(bool value)
		{
			base.Options["preloadEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should load adjacent pages. Applies only if scrolling.mode is "virtual" or "infinite".</summary>
		[Generated]
		public DataGridScrollingBuilder PreloadEnabled(JS value)
		{
			base.Options["preloadEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the rendering mode for loaded rows.</summary>
		[Generated]
		public DataGridScrollingBuilder RowRenderingMode(GridRowRenderingMode value)
		{
			base.Options["rowRenderingMode"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can scroll the content with a swipe gesture. Applies only if useNative is false.</summary>
		[Generated]
		public DataGridScrollingBuilder ScrollByContent(bool value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can scroll the content with a swipe gesture. Applies only if useNative is false.</summary>
		[Generated]
		public DataGridScrollingBuilder ScrollByContent(JS value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can scroll the content with the scrollbar. Applies only if useNative is false.</summary>
		[Generated]
		public DataGridScrollingBuilder ScrollByThumb(bool value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can scroll the content with the scrollbar. Applies only if useNative is false.</summary>
		[Generated]
		public DataGridScrollingBuilder ScrollByThumb(JS value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>Specifies when to show scrollbars. Applies only if useNative is false.</summary>
		[Generated]
		public DataGridScrollingBuilder ShowScrollbar(ShowScrollbarMode value)
		{
			base.Options["showScrollbar"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should use native or simulated scrolling.</summary>
		[Generated]
		public DataGridScrollingBuilder UseNative(bool value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should use native or simulated scrolling.</summary>
		[Generated]
		public DataGridScrollingBuilder UseNative(JS value)
		{
			base.Options["useNative"] = value;
			return this;
		}
	}
}
