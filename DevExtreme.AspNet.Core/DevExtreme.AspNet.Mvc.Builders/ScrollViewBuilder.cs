using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The ScrollView is a widget that enables a user to scroll its content.</summary>
	public class ScrollViewBuilder : WidgetBuilder
	{
		[Generated]
		public ScrollViewBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ScrollViewBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ScrollViewBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ScrollViewBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public ScrollViewBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public ScrollViewBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable the bounce-back effect.</summary>
		[Generated]
		public ScrollViewBuilder BounceEnabled(bool value)
		{
			base.Options["bounceEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable the bounce-back effect.</summary>
		[Generated]
		public ScrollViewBuilder BounceEnabled(JS value)
		{
			base.Options["bounceEnabled"] = value;
			return this;
		}

		/// <summary>A string value specifying the available scrolling directions.</summary>
		[Generated]
		public ScrollViewBuilder Direction(ScrollDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget can respond to user interaction.</summary>
		[Generated]
		public ScrollViewBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget can respond to user interaction.</summary>
		[Generated]
		public ScrollViewBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ScrollViewBuilder ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ScrollViewBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ScrollViewBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ScrollViewBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ScrollViewBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ScrollViewBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ScrollViewBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ScrollViewBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ScrollViewBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ScrollViewBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ScrollViewBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ScrollViewBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ScrollViewBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed. Supported in mobile themes only.</summary>
		[Generated]
		public ScrollViewBuilder OnPullDown(string jsFunc)
		{
			AssignJS("onPullDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed. Supported in mobile themes only.</summary>
		[Generated]
		public ScrollViewBuilder OnPullDown(RazorBlock jsFunc)
		{
			return OnPullDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the content is scrolled down to the bottom.</summary>
		[Generated]
		public ScrollViewBuilder OnReachBottom(string jsFunc)
		{
			AssignJS("onReachBottom", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the content is scrolled down to the bottom.</summary>
		[Generated]
		public ScrollViewBuilder OnReachBottom(RazorBlock jsFunc)
		{
			return OnReachBottom(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed on each scroll gesture.</summary>
		[Generated]
		public ScrollViewBuilder OnScroll(string jsFunc)
		{
			AssignJS("onScroll", jsFunc);
			return this;
		}

		/// <summary>A function that is executed on each scroll gesture.</summary>
		[Generated]
		public ScrollViewBuilder OnScroll(RazorBlock jsFunc)
		{
			return OnScroll(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget is updated.</summary>
		[Generated]
		public ScrollViewBuilder OnUpdated(string jsFunc)
		{
			AssignJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget is updated.</summary>
		[Generated]
		public ScrollViewBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the text shown in the pullDown panel when pulling the content down lowers the refresh threshold.</summary>
		[Generated]
		public ScrollViewBuilder PulledDownText(string value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel when pulling the content down lowers the refresh threshold.</summary>
		[Generated]
		public ScrollViewBuilder PulledDownText(JS value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while pulling the content down to the refresh threshold.</summary>
		[Generated]
		public ScrollViewBuilder PullingDownText(string value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while pulling the content down to the refresh threshold.</summary>
		[Generated]
		public ScrollViewBuilder PullingDownText(JS value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel displayed when content is scrolled to the bottom.</summary>
		[Generated]
		public ScrollViewBuilder ReachBottomText(string value)
		{
			base.Options["reachBottomText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel displayed when content is scrolled to the bottom.</summary>
		[Generated]
		public ScrollViewBuilder ReachBottomText(JS value)
		{
			base.Options["reachBottomText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel displayed when the content is being refreshed.</summary>
		[Generated]
		public ScrollViewBuilder RefreshingText(string value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel displayed when the content is being refreshed.</summary>
		[Generated]
		public ScrollViewBuilder RefreshingText(JS value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ScrollViewBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ScrollViewBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not an end-user can scroll the widget content swiping it up or down. Applies only if useNative is false</summary>
		[Generated]
		public ScrollViewBuilder ScrollByContent(bool value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not an end-user can scroll the widget content swiping it up or down. Applies only if useNative is false</summary>
		[Generated]
		public ScrollViewBuilder ScrollByContent(JS value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not an end-user can scroll the widget content using the scrollbar.</summary>
		[Generated]
		public ScrollViewBuilder ScrollByThumb(bool value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not an end-user can scroll the widget content using the scrollbar.</summary>
		[Generated]
		public ScrollViewBuilder ScrollByThumb(JS value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>Specifies when the widget shows the scrollbar.</summary>
		[Generated]
		public ScrollViewBuilder ShowScrollbar(ShowScrollbarMode value)
		{
			base.Options["showScrollbar"] = value;
			return this;
		}

		/// <summary>Indicates whether to use native or simulated scrolling.</summary>
		[Generated]
		public ScrollViewBuilder UseNative(bool value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		/// <summary>Indicates whether to use native or simulated scrolling.</summary>
		[Generated]
		public ScrollViewBuilder UseNative(JS value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ScrollViewBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ScrollViewBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ScrollViewBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
