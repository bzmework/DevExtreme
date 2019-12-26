using DevExtreme.AspNet.Mvc.FileManagement.Internals;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public class FileSystemCommandResult
	{
		private bool _success;

		public bool Success
		{
			get
			{
				if (_success)
				{
					return Exception == null;
				}
				return false;
			}
			set
			{
				_success = value;
			}
		}

		public Exception Exception
		{
			get;
			set;
		}

		public object Result
		{
			get;
			set;
		}

		private bool IsFileContentResult => Result is FileContentResult;

		public FileSystemCommandResult()
		{
			Success = true;
		}

		public object GetClientCommandResult()
		{
			object errorId = null;
			FileManagementException ex = Exception as FileManagementException;
			if (ex != null)
			{
				errorId = ex.ErrorCode;
			}
			if (IsFileContentResult && Success)
			{
				FileContentResult fileContentResult = (FileContentResult)Result;
				return Portability.CreateFileContentResult(fileContentResult.FileStream, fileContentResult.FileName);
			}
			return new
			{
				success = Success,
				errorId = errorId,
				result = GetClientResult()
			};
		}

		private object GetClientResult()
		{
			IList<IClientFileSystemItem> list = Result as IList<IClientFileSystemItem>;
			if (list == null)
			{
				return Result;
			}
			if (IsFileContentResult)
			{
				return null;
			}
			List<Dictionary<string, object>> list2 = new List<Dictionary<string, object>>();
			foreach (IClientFileSystemItem item2 in list)
			{
				Dictionary<string, object> item = new Dictionary<string, object>(item2.CustomFields)
				{
					["key"] = item2.Key,
					["name"] = item2.Name,
					["dateModified"] = item2.DateModified,
					["isDirectory"] = item2.IsDirectory,
					["size"] = item2.Size,
					["hasSubDirectories"] = item2.HasSubDirectories
				};
				list2.Add(item);
			}
			return list2;
		}
	}
}
