using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevExtreme.AspNet.Mvc
{
	/// <summary>
	/// HtmlHelper��չ
	/// </summary>
	public static class HtmlHelperExtensions
	{
		/// <summary>
		/// ����WidgetFactory�ؼ�����ʵ������Html�У�ÿ���ؼ�������ͨ��WidgetFactory���������磺Html.DevExtreme().Menu()
		/// </summary>
		/// <param name="html"></param>
		/// <returns></returns>
		public static WidgetFactory<object> DevExtreme(this IHtmlHelper html)
		{
			return new WidgetFactory<object>(null, new HtmlHelperAdapter(html));
		}

		/// <summary>
		/// WidgetFactory�ؼ�����ʵ������Html�У�ÿ���ؼ�������ͨ��WidgetFactory���������磺Html.DevExtreme().Menu()
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
