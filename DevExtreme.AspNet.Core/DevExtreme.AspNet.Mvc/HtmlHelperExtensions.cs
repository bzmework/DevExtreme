using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevExtreme.AspNet.Mvc
{
	/// <summary>
	/// HtmlHelper扩展
	/// </summary>
	public static class HtmlHelperExtensions
	{
		/// <summary>
		/// 创建WidgetFactory控件工厂实例。在Html中，每个控件都必须通过WidgetFactory创建，例如：Html.DevExtreme().Menu()
		/// </summary>
		/// <param name="html"></param>
		/// <returns></returns>
		public static WidgetFactory<object> DevExtreme(this IHtmlHelper html)
		{
			return new WidgetFactory<object>(null, new HtmlHelperAdapter(html));
		}

		/// <summary>
		/// WidgetFactory控件工厂实例。在Html中，每个控件都必须通过WidgetFactory创建，例如：Html.DevExtreme().Menu()
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <param name="html"></param>
		/// <returns></returns>
		public static WidgetFactory<TModel> DevExtreme<TModel>(this IHtmlHelper<TModel> html)
		{
			return new WidgetFactory<TModel>(null, new HtmlHelperAdapter(html));
		}
	}
}
