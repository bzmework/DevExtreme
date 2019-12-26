namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal class FileChunkMetadata
	{
		public string UploadId
		{
			get;
			set;
		}

		public string FileName
		{
			get;
			set;
		}

		public long Index
		{
			get;
			set;
		}

		public long TotalCount
		{
			get;
			set;
		}

		public long FileSize
		{
			get;
			set;
		}
	}
}
