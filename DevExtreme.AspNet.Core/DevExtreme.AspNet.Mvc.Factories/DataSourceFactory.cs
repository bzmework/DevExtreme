using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Builders.DataSources;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ����Դ����
	/// </summary>
	public class DataSourceFactory
	{
		private OptionsOwnerContext _context;

		private static bool UseLegacyRouting => Compatibility.DataSource.UseLegacyRouting;

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		public DataSourceFactory(OptionsOwnerContext context)
		{
			_context = context;
		}

		/// <summary>
		///  ���ö�Web API�������ķ��ʡ� 
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
		/// ���ö�MVC�������ķ��ʡ� 
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
		/// ���ö��ڴ�������ķ��ʡ�
		/// Configures access to an in-memory array.
		/// </summary>
		public ArrayDataSourceBuilder Array()
		{
			return new ArrayDataSourceBuilder(_context);
		}

		/// <summary>
		///  ���ö�JSON��ʽ���ݵķ��ʡ� 
		/// Configures access to data in JSON format.
		/// </summary>
		public StaticJsonDataSourceBuilder StaticJson()
		{
			return new StaticJsonDataSourceBuilder(_context);
		}

		/// <summary>
		///  ���ö�OData����ķ��ʡ� 
		/// Configures access to an OData service.
		/// </summary>
		public ODataSourceBuilder OData()
		{
			return new ODataSourceBuilder(_context);
		}

		/// <summary>
		/// ʹ��URL���ö����ݿ������ķ��ʡ� 
		/// Configures access to a data controller using URLs.
		/// </summary>
		public RemoteControllerDataSourceOptionsBuilder RemoteController()
		{
			return new RemoteControllerDataSourceOptionsBuilder(_context);
		}
	}
}
