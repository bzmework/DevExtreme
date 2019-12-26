using System.IO;

namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal class DefaultFileSystemService : IFileSystemService
	{
		public bool FileExists(string path)
		{
			return File.Exists(path);
		}

		public bool DirectoryExists(string path)
		{
			return Directory.Exists(path);
		}

		public string[] GetDirectories(string dirPath)
		{
			return Directory.GetDirectories(dirPath);
		}

		public string[] GetFiles(string dirPath)
		{
			return Directory.GetFiles(dirPath);
		}

		public void CreateDirectory(string path)
		{
			Directory.CreateDirectory(path);
		}

		public void MoveFile(string sourceFileName, string destFileName)
		{
			File.Move(sourceFileName, destFileName);
		}

		public void MoveDirectory(string sourceDirName, string destDirName)
		{
			Directory.Move(sourceDirName, destDirName);
		}

		public void CopyFile(string sourceFilePath, string destinationFilePath)
		{
			new FileInfo(sourceFilePath).CopyTo(destinationFilePath);
		}

		public void CopyDirectory(string sourcePath, string destinationPath)
		{
			DirectoryInfo sourceDir = new DirectoryInfo(sourcePath);
			if (!DirectoryExists(destinationPath))
			{
				CreateDirectory(destinationPath);
			}
			CopyDirectoryContentRecursive(sourceDir, new DirectoryInfo(destinationPath));
		}

		public void RemoveFile(string path)
		{
			File.Delete(path);
		}

		public void RemoveDirectory(string path)
		{
			Directory.Delete(path, recursive: true);
		}

		public Stream GetFileContent(string path)
		{
			return File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		}

		private static void CopyDirectoryContentRecursive(DirectoryInfo sourceDir, DirectoryInfo destinationDir)
		{
			DirectoryInfo[] directories = sourceDir.GetDirectories();
			foreach (DirectoryInfo directoryInfo in directories)
			{
				DirectoryInfo destinationDir2 = destinationDir.CreateSubdirectory(directoryInfo.Name);
				CopyDirectoryContentRecursive(directoryInfo, destinationDir2);
			}
			FileInfo[] files = sourceDir.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				files[i].CopyTo(destinationDir.FullName);
			}
		}
	}
}
