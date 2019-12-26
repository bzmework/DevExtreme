namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public enum FileSystemCommand
	{
		GetDirContents,
		CreateDir,
		Rename,
		Move,
		Copy,
		Remove,
		UploadChunk,
		AbortUpload,
		Download
	}
}
