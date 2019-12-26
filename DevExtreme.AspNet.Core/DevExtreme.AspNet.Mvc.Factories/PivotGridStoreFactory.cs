using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// PivotGrid存储工厂
	/// </summary>
	public class PivotGridStoreFactory : DataSourceFactory
	{
		private OptionsOwnerContext _context;

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		public PivotGridStoreFactory(OptionsOwnerContext context)
			: base(context)
		{
			_context = context;
		}

		/// <summary>
		/// 返回一个XML数据源
		/// </summary>
		/// <returns></returns>
		public XmlaDataSourceBuilder Xmla()
		{
			return new XmlaDataSourceBuilder(_context);
		}
	}
}
