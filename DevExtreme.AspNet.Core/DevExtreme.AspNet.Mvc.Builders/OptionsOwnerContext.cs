using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// �ؼ���ѡ��������
	/// </summary>
	public struct OptionsOwnerContext
	{
		/// <summary>
		/// ��Ӧ��Js�ؼ�����
		/// </summary>
		public readonly string JsName;

		/// <summary>
		/// ӵ���ߣ�˭ӵ�пؼ�������δ�á�
		/// </summary>
		public readonly OptionsOwnerBuilder Owner;

		/// <summary>
		/// Html���������ؼ����ĸ�ҳ�洴����
		/// </summary>
		public readonly IHtmlHelperAdapter Html;

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="jsName">��Ӧ��Js�ؼ�����</param>
		/// <param name="owner">ӵ���ߣ�˭ӵ�пؼ�������δ�á�</param>
		/// <param name="html">Html���������ؼ����ĸ�ҳ�洴����</param>
		public OptionsOwnerContext(string jsName, OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
		{
			JsName = jsName;
			Owner = owner;
			Html = html;
		}
	}
}
