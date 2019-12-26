using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// PivotGrid�洢����
	/// </summary>
	public class PivotGridStoreFactory : DataSourceFactory
	{
		private OptionsOwnerContext _context;

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		public PivotGridStoreFactory(OptionsOwnerContext context)
			: base(context)
		{
			_context = context;
		}

		/// <summary>
		/// ����һ��XML����Դ
		/// </summary>
		/// <returns></returns>
		public XmlaDataSourceBuilder Xmla()
		{
			return new XmlaDataSourceBuilder(_context);
		}
	}
}
