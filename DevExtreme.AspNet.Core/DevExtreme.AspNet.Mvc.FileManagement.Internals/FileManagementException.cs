using System;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal class FileManagementException : Exception
	{
		public FileManagementErrorCode ErrorCode
		{
			get;
		}

		public FileManagementException(FileManagementErrorCode errorCode, string message)
			: this(errorCode, new Exception(message))
		{
		}

		public FileManagementException(FileManagementErrorCode errorCode, Exception innerException)
			: base(innerException.Message, innerException)
		{
			ErrorCode = errorCode;
		}
	}
}
