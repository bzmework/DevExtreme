using System.IO;
using System.Security;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	public static class FileManagementExceptionExecutor
	{
		public static void ThrowNoAccess()
		{
			SecurityException innerException = new SecurityException("Access denied. The operation cannot be completed.");
			throw new FileManagementException(FileManagementErrorCode.NoAccess, innerException);
		}

		public static void ThrowWrongFileExtension()
		{
			SecurityException innerException = new SecurityException("File extension is not allowed");
			throw new FileManagementException(FileManagementErrorCode.WrongFileExtension, innerException);
		}

		public static void ThrowMaxFileSizeExceeded()
		{
			SecurityException innerException = new SecurityException("File size exceeds the maximum allowed size");
			throw new FileManagementException(FileManagementErrorCode.MaxFileSizeExceeded, innerException);
		}

		public static void ThrowFileNotFound(string fileName)
		{
			FileNotFoundException innerException = new FileNotFoundException($"File '{fileName}' not found");
			throw new FileManagementException(FileManagementErrorCode.FileNotFound, innerException);
		}

		public static void ThrowFileExists(string fileName)
		{
			string message = $"File '{fileName}' already exists.";
			throw new FileManagementException(FileManagementErrorCode.FileExists, message);
		}

		public static void ThrowDirectoryExists(string directoryName)
		{
			string message = $"Directory '{directoryName}' already exists.";
			throw new FileManagementException(FileManagementErrorCode.DirectoryExists, message);
		}

		public static void ThrowInvalidSymbols()
		{
			string message = "This name contains invalid characters";
			throw new FileManagementException(FileManagementErrorCode.InvalidSymbols, message);
		}
	}
}
