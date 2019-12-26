using DevExtreme.AspNet.Mvc.Builders;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 文件提供器工厂
	/// </summary>
	public class FileProviderFactory
	{
		private OptionsOwnerContext _context;

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		public FileProviderFactory(OptionsOwnerContext context)
		{
			_context = context;
		}

		/// <summary>
		/// 原创文件提供器
		/// </summary>
		/// <returns></returns>
		public RemoteFileProviderBuilder Remote()
		{
			return new RemoteFileProviderBuilder(_context);
		}

		/// <summary>
		/// 自定义文件提供器
		/// </summary>
		/// <returns></returns>
		public CustomFileProviderBuilder Custom()
		{
			return new CustomFileProviderBuilder(_context);
		}
	}
}
