using Microsoft.AspNetCore.Http;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public class FileSystemConfiguration
	{
		private const string DefaultUploadTempPath = "Tmp";

		public HttpRequest Request
		{
			get;
			set;
		}

		public IFileProvider FileSystemProvider
		{
			get;
			set;
		}

		public bool AllowCreate
		{
			get;
			set;
		}

		public bool AllowCopy
		{
			get;
			set;
		}

		public bool AllowMove
		{
			get;
			set;
		}

		public bool AllowRemove
		{
			get;
			set;
		}

		public bool AllowRename
		{
			get;
			set;
		}

		public bool AllowUpload
		{
			get;
			set;
		}

		public bool AllowDownload
		{
			get;
			set;
		}

		public string[] AllowedFileExtensions
		{
			get;
			set;
		}

		public long MaxUploadFileSize
		{
			get;
			set;
		}

		public string UploadTempPath
		{
			get;
			set;
		}

		public FileSystemConfiguration()
		{
			UploadTempPath = "Tmp";
			AllowedFileExtensions = new string[25]
			{
				".txt",
				".rtf",
				".doc",
				".docx",
				".odt",
				".xls",
				".xlsx",
				".ods",
				".ppt",
				".pptx",
				".odp",
				".pdf",
				".xml",
				".png",
				".svg",
				".gif",
				".jpg",
				".jpeg",
				".ico",
				".bmp",
				".avi",
				".mpeg",
				".mkv",
				".zip",
				""
			};
		}
	}
}
