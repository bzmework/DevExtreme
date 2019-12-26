using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 控件工厂
	/// </summary>
	public abstract class AbstractWidgetFactory
	{
		/// <summary>
		/// 拥有者，谁拥有控件。保留未用。
		/// </summary>
		protected OptionsOwnerBuilder Owner
		{
			get;
			private set;
		}

		/// <summary>
		/// Html适配器，控件在哪个页面创建。
		/// </summary>
		protected IHtmlHelperAdapter Html
		{
			get;
			private set;
		}

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="html"></param>
		protected AbstractWidgetFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
		{
			Owner = owner;
			Html = html;
		}
	}
}
