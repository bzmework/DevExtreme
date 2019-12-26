using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 数据源工厂
	/// </summary>
	public class DataSourceFactory
	{
		private OptionsOwnerContext _context;

		private static bool UseLegacyRouting => Compatibility.DataSource.UseLegacyRouting;

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		public DataSourceFactory(OptionsOwnerContext context)
		{
			_context = context;
		}

		/// <summary>
		///  配置对Web API控制器的访问。 
		/// Configures access to a Web API controller.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ControllerDataSourceOptionsBuilder WebApi()
		{
			ControllerDataSourceOptionsBuilder controllerDataSourceOptionsBuilder = new ControllerDataSourceOptionsBuilder(_context);
			if (UseLegacyRouting)
			{
				controllerDataSourceOptionsBuilder.LoadAction("Get").InsertAction("Post").UpdateAction("Put")
					.DeleteAction("Delete");
			}
			return controllerDataSourceOptionsBuilder;
		}

		/// <summary>
		/// 配置对MVC控制器的访问。 
		/// Configures access to an MVC controller.
		/// </summary>
		public ControllerDataSourceOptionsBuilder Mvc()
		{
			ControllerDataSourceOptionsBuilder controllerDataSourceOptionsBuilder = new ControllerDataSourceOptionsBuilder(_context);
			if (UseLegacyRouting)
			{
				controllerDataSourceOptionsBuilder.RouteName("default");
			}
			return controllerDataSourceOptionsBuilder;
		}

		/// <summary>
		/// 配置对内存中数组的访问。
		/// Configures access to an in-memory array.
		/// </summary>
		public ArrayDataSourceBuilder Array()
		{
			return new ArrayDataSourceBuilder(_context);
		}

		/// <summary>
		///  配置对JSON格式数据的访问。 
		/// Configures access to data in JSON format.
		/// </summary>
		public StaticJsonDataSourceBuilder StaticJson()
		{
			return new StaticJsonDataSourceBuilder(_context);
		}

		/// <summary>
		///  配置对OData服务的访问。 
		/// Configures access to an OData service.
		/// </summary>
		public ODataSourceBuilder OData()
		{
			return new ODataSourceBuilder(_context);
		}

		/// <summary>
		/// 使用URL配置对数据控制器的访问。 
		/// Configures access to a data controller using URLs.
		/// </summary>
		public RemoteControllerDataSourceOptionsBuilder RemoteController()
		{
			return new RemoteControllerDataSourceOptionsBuilder(_context);
		}
	}
}
