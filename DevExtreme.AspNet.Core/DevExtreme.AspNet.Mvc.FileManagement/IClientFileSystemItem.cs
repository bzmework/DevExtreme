using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public interface IClientFileSystemItem
	{
		object Key
		{
			get;
			set;
		}

		string Name
		{
			get;
			set;
		}

		DateTime DateModified
		{
			get;
			set;
		}

		bool IsDirectory
		{
			get;
			set;
		}

		long Size
		{
			get;
			set;
		}

		bool HasSubDirectories
		{
			get;
			set;
		}

		IDictionary<string, object> CustomFields
		{
			get;
		}
	}
}
