using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// TextEditorButton控件工厂
	/// </summary>
	public class TextEditorButtonWidgetFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="owner">拥有者，谁拥有控件。保留未用。</param>
		/// <param name="html">Html适配器，控件在哪个页面创建。</param>
		[Generated]
		public TextEditorButtonWidgetFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
			//
		}

		/// <summary>
		/// Button控件是一个简单的按钮，当用户单击它时，它执行指定的命令。 
		/// The Button widget is a simple button that performs specified commands when a user clicks it.
		/// </summary>
		[Generated]
		public ButtonBuilder Button()
		{
			return new ButtonBuilder(new OptionsOwnerContext("dxButton", base.Owner, base.Html));
		}
	}
}
