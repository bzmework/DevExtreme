using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal class ClientFileSystemItem : IClientFileSystemItem
	{
		public object Key
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public DateTime DateModified
		{
			get;
			set;
		}

		public bool IsDirectory
		{
			get;
			set;
		}

		public long Size
		{
			get;
			set;
		}

		public bool HasSubDirectories
		{
			get;
			set;
		}

		public IDictionary<string, object> CustomFields
		{
			get;
		}

		public ClientFileSystemItem()
		{
			CustomFields = new Dictionary<string, object>();
		}
	}
}
