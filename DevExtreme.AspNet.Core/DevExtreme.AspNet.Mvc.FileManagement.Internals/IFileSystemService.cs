using System.IO;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	public interface IFileSystemService
	{
		bool FileExists(string path);

		bool DirectoryExists(string path);

		string[] GetDirectories(string dirPath);

		string[] GetFiles(string dirPath);

		void CreateDirectory(string path);

		void MoveFile(string sourceFileName, string destFileName);

		void MoveDirectory(string sourceDirName, string destDirName);

		void CopyFile(string sourceFilePath, string destinationFilePath);

		void CopyDirectory(string sourcePath, string destinationPath);

		void RemoveFile(string path);

		void RemoveDirectory(string path);

		Stream GetFileContent(string path);
	}
}
