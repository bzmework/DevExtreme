using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// �ؼ�����
	/// </summary>
	public abstract class AbstractWidgetFactory
	{
		/// <summary>
		/// ӵ���ߣ�˭ӵ�пؼ�������δ�á�
		/// </summary>
		protected OptionsOwnerBuilder Owner
		{
			get;
			private set;
		}

		/// <summary>
		/// Html���������ؼ����ĸ�ҳ�洴����
		/// </summary>
		protected IHtmlHelperAdapter Html
		{
			get;
			private set;
		}

		/// <summary>
		/// ��ʼ��
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
