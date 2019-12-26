using System.IO;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal class FileContentResult
	{
		public string FileName
		{
			get;
			set;
		}

		public Stream FileStream
		{
			get;
			set;
		}

		public FileContentResult()
		{
		}

		public FileContentResult(Stream fileStream, string fileName)
		{
			FileStream = fileStream;
			FileName = fileName;
		}
	}
}
