using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 控件可选项上下文
	/// </summary>
	public struct OptionsOwnerContext
	{
		/// <summary>
		/// 对应的Js控件名称
		/// </summary>
		public readonly string JsName;

		/// <summary>
		/// 拥有者，谁拥有控件。保留未用。
		/// </summary>
		public readonly OptionsOwnerBuilder Owner;

		/// <summary>
		/// Html适配器，控件在哪个页面创建。
		/// </summary>
		public readonly IHtmlHelperAdapter Html;

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="jsName">对应的Js控件名称</param>
		/// <param name="owner">拥有者，谁拥有控件。保留未用。</param>
		/// <param name="html">Html适配器，控件在哪个页面创建。</param>
		public OptionsOwnerContext(string jsName, OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
		{
			JsName = jsName;
			Owner = owner;
			Html = html;
		}
	}
}
