using System.Collections.Generic;
using System.IO;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public interface IFileProvider
	{
		IList<IClientFileSystemItem> GetDirectoryContents(FileItemPathInfo pathInfo);

		void CreateDirectory(FileItemPathInfo pathInfo, string name);

		void Rename(FileItemPathInfo pathInfo, string newName);

		void Move(FileItemPathInfo pathInfo, FileItemPathInfo destinationPathInfo);

		void Copy(FileItemPathInfo sourcePathInfo, FileItemPathInfo destinationPathInfo);

		void Remove(FileItemPathInfo pathInfo);

		void MoveUploadedFile(FileInfo file, string destinationKey);

		void RemoveUploadedFile(FileInfo file);

		Stream GetFileContent(FileItemPathInfo pathInfo);
	}
}
