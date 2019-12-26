using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// TextEditorButton�ؼ�����
	/// </summary>
	public class TextEditorButtonWidgetFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="owner">ӵ���ߣ�˭ӵ�пؼ�������δ�á�</param>
		/// <param name="html">Html���������ؼ����ĸ�ҳ�洴����</param>
		[Generated]
		public TextEditorButtonWidgetFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
			//
		}

		/// <summary>
		/// Button�ؼ���һ���򵥵İ�ť�����û�������ʱ����ִ��ָ������� 
		/// The Button widget is a simple button that performs specified commands when a user clicks it.
		/// </summary>
		[Generated]
		public ButtonBuilder Button()
		{
			return new ButtonBuilder(new OptionsOwnerContext("dxButton", base.Owner, base.Html));
		}
	}
}
