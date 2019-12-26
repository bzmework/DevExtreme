using DevExtreme.AspNet.Mvc.Builders;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// �ļ��ṩ������
	/// </summary>
	public class FileProviderFactory
	{
		private OptionsOwnerContext _context;

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		public FileProviderFactory(OptionsOwnerContext context)
		{
			_context = context;
		}

		/// <summary>
		/// ԭ���ļ��ṩ��
		/// </summary>
		/// <returns></returns>
		public RemoteFileProviderBuilder Remote()
		{
			return new RemoteFileProviderBuilder(_context);
		}

		/// <summary>
		/// �Զ����ļ��ṩ��
		/// </summary>
		/// <returns></returns>
		public CustomFileProviderBuilder Custom()
		{
			return new CustomFileProviderBuilder(_context);
		}
	}
}
