using DevExtreme.AspNet.Mvc.FileManagement.Internals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public class DefaultFileProvider : IFileProvider
	{
		private const string ParentDirectorySymbol = "..";

		private static readonly char[] PossibleDirectorySeparators = new char[2]
		{
			'\\',
			'/'
		};

		private DirectoryInfo rootDirectoryInfo;

		public string RootDirectoryPath
		{
			get;
		}

		protected virtual string CopiedPrefix => "copy";

		private DirectoryInfo RootDirectoryInfo => rootDirectoryInfo ?? (rootDirectoryInfo = new DirectoryInfo(RootDirectoryPath));

		private IFileSystemService FileSystemService
		{
			get;
		}

		private Action<FileSystemInfo, IClientFileSystemItem> PrepareFileSystemItemCallback
		{
			get;
		}

		public DefaultFileProvider(string rootDirectoryPath)
			: this(rootDirectoryPath, null)
		{
		}

		public DefaultFileProvider(string rootDirectoryPath, Action<FileSystemInfo, IClientFileSystemItem> prepareFileSystemItemCallback)
			: this(rootDirectoryPath, prepareFileSystemItemCallback, new DefaultFileSystemService())
		{
		}

		internal DefaultFileProvider(string rootDirectoryPath, Action<FileSystemInfo, IClientFileSystemItem> prepareFileSystemItemCallback, IFileSystemService fileSystemService)
		{
			if (fileSystemService == null)
			{
				throw new ArgumentNullException("fileSystemService");
			}
			FileSystemService = fileSystemService;
			if (!FileSystemService.DirectoryExists(rootDirectoryPath))
			{
				throw new DriveNotFoundException();
			}
			RootDirectoryPath = rootDirectoryPath;
			PrepareFileSystemItemCallback = prepareFileSystemItemCallback;
		}

		public IList<IClientFileSystemItem> GetDirectoryContents(FileItemPathInfo pathInfo)
		{
			return GetDirectoryContents(pathInfo?.GetPath());
		}

		public IList<IClientFileSystemItem> GetDirectoryContents(string path)
		{
			string fullDirPathWithCheckOnExistence = GetFullDirPathWithCheckOnExistence(path);
			List<IClientFileSystemItem> list = new List<IClientFileSystemItem>();
			string[] directories = FileSystemService.GetDirectories(fullDirPathWithCheckOnExistence);
			foreach (string text in directories)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				ClientFileSystemItem clientFileSystemItem = CreateClientFileItem(directoryInfo, text);
				PrepareFileSystemItemCallback?.Invoke(directoryInfo, clientFileSystemItem);
				list.Add(clientFileSystemItem);
			}
			directories = FileSystemService.GetFiles(fullDirPathWithCheckOnExistence);
			foreach (string text2 in directories)
			{
				FileInfo fileInfo = new FileInfo(text2);
				ClientFileSystemItem clientFileSystemItem2 = CreateClientFileItem(fileInfo, text2);
				PrepareFileSystemItemCallback?.Invoke(fileInfo, clientFileSystemItem2);
				list.Add(clientFileSystemItem2);
			}
			return list;
		}

		public void CreateDirectory(FileItemPathInfo pathInfo, string name)
		{
			CreateDirectory(pathInfo?.GetPath(), name);
		}

		public void CreateDirectory(string rootKey, string name)
		{
			CheckThatDirOrFileNameIsNotEmpty(name, "name");
			ValidateFileItemNameSymbols(name);
			string path = Path.Combine(GetFullDirPathWithCheckOnExistence(rootKey), name);
			if (FileSystemService.DirectoryExists(path))
			{
				FileManagementExceptionExecutor.ThrowDirectoryExists(Path.Combine(PreparePath(rootKey), name));
			}
			FileSystemService.CreateDirectory(path);
		}

		public void Rename(FileItemPathInfo pathInfo, string newName)
		{
			Rename(pathInfo?.GetPath(), newName);
		}

		public void Rename(string key, string newName)
		{
			CheckThatDirOrFileNameIsNotEmpty(key, "key");
			CheckThatDirOrFileNameIsNotEmpty(newName, "newName");
			ValidateFileItemNameSymbols(newName);
			string text = Path.Combine(RootDirectoryPath, PreparePath(key));
			string path = Path.GetDirectoryName(text) ?? string.Empty;
			if (FileSystemService.DirectoryExists(text))
			{
				if (string.Equals(Path.GetFullPath(RootDirectoryPath), Path.GetFullPath(text), StringComparison.OrdinalIgnoreCase))
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				string destDirName = Path.Combine(path, newName);
				FileSystemService.MoveDirectory(text, destDirName);
			}
			else if (FileSystemService.FileExists(text))
			{
				string extension = Path.GetExtension(text);
				if (!newName.Contains("."))
				{
					newName += extension;
				}
				string destFileName = Path.Combine(path, newName);
				FileSystemService.MoveFile(text, destFileName);
			}
			else
			{
				FileManagementExceptionExecutor.ThrowFileNotFound(text);
			}
		}

		public void Move(FileItemPathInfo sourcePathInfo, FileItemPathInfo destinationPathInfo)
		{
			Move(sourcePathInfo?.GetPath(), destinationPathInfo?.GetPath());
		}

		public void Move(string sourcePath, string destinationPath)
		{
			string text = Path.Combine(RootDirectoryPath, PreparePath(sourcePath));
			string text2 = Path.Combine(RootDirectoryPath, PreparePath(destinationPath), Path.GetFileName(text));
			if (text == text2)
			{
				throw new Exception("Source and destination paths should be different.");
			}
			if (text2.StartsWith(text))
			{
				throw new Exception("Incorrect destination path for the move operation.");
			}
			if (FileSystemService.DirectoryExists(text))
			{
				FileSystemService.MoveDirectory(text, text2);
			}
			else if (FileSystemService.FileExists(text))
			{
				FileSystemService.MoveFile(text, text2);
			}
			else
			{
				FileManagementExceptionExecutor.ThrowFileNotFound(text);
			}
		}

		public void MoveUploadedFile(FileInfo file, string destinationKey)
		{
			string destFileName = Path.Combine(RootDirectoryPath, PreparePath(destinationKey));
			FileSystemService.MoveFile(file.FullName, destFileName);
		}

		public void RemoveUploadedFile(FileInfo file)
		{
			FileSystemService.RemoveFile(file.FullName);
		}

		public void Copy(FileItemPathInfo sourcePathInfo, FileItemPathInfo destinationPathInfo)
		{
			Copy(sourcePathInfo?.GetPath(), destinationPathInfo?.GetPath());
		}

		public void Copy(string sourcePath, string destinationPath)
		{
			string text = Path.Combine(RootDirectoryPath, PreparePath(sourcePath));
			string path = Path.Combine(RootDirectoryPath, PreparePath(destinationPath));
			if (FileSystemService.DirectoryExists(text))
			{
				string destinationPath2 = GenerateCopiedFileItemPath(path, Path.GetFileName(text), isDirectory: true);
				FileSystemService.CopyDirectory(text, destinationPath2);
			}
			else if (FileSystemService.FileExists(text))
			{
				string destinationFilePath = GenerateCopiedFileItemPath(path, Path.GetFileName(text), isDirectory: false);
				FileSystemService.CopyFile(text, destinationFilePath);
			}
			else
			{
				FileManagementExceptionExecutor.ThrowFileNotFound(destinationPath);
			}
		}

		protected virtual string GenerateCopiedFileItemPath(string path, string copiedFileItemName, bool isDirectory)
		{
			int num = 0;
			string text;
			do
			{
				string str = (num < 1) ? string.Empty : $" {num}";
				text = Path.Combine(path, copiedFileItemName + " " + CopiedPrefix + str);
				num++;
			}
			while (isDirectory ? FileSystemService.DirectoryExists(text) : FileSystemService.FileExists(text));
			return text;
		}

		public void Remove(FileItemPathInfo pathInfo)
		{
			Remove(pathInfo?.GetPath());
		}

		public void Remove(string path)
		{
			CheckThatDirOrFileNameIsNotEmpty(path, "path");
			string text = Path.Combine(RootDirectoryPath, PreparePath(path));
			if (FileSystemService.DirectoryExists(text))
			{
				FileSystemService.RemoveDirectory(text);
				return;
			}
			if (FileSystemService.FileExists(text))
			{
				FileSystemService.RemoveFile(text);
				return;
			}
			throw new FileNotFoundException(null, text);
		}

		public Stream GetFileContent(FileItemPathInfo pathInfo)
		{
			string path = pathInfo?.GetPath();
			string text = Path.Combine(RootDirectoryPath, PreparePath(path));
			if (Path.GetDirectoryName(text) == null)
			{
				_ = string.Empty;
			}
			if (FileSystemService.FileExists(text))
			{
				return FileSystemService.GetFileContent(text);
			}
			FileManagementExceptionExecutor.ThrowFileNotFound(text);
			return null;
		}

		private ClientFileSystemItem CreateClientFileItem(FileSystemInfo info, string originalPath)
		{
			FileInfo fileInfo = info as FileInfo;
			long size = (fileInfo != null && fileInfo.Exists) ? fileInfo.Length : 0;
			bool hasSubDirectories = info is DirectoryInfo && FileSystemService.GetDirectories(originalPath).Any();
			return new ClientFileSystemItem
			{
				Key = GetFileItemClientId(info),
				Name = info.Name,
				DateModified = info.LastWriteTimeUtc,
				IsDirectory = (fileInfo == null),
				Size = size,
				HasSubDirectories = hasSubDirectories
			};
		}

		private string GetFileItemClientId(FileSystemInfo itemInfo)
		{
			string text = RootDirectoryInfo.Exists ? RootDirectoryInfo.FullName : RootDirectoryInfo.ToString();
			string text2 = itemInfo.Exists ? itemInfo.FullName : itemInfo.ToString();
			if (text2.IndexOf(text, StringComparison.Ordinal) == 0)
			{
				text2 = text2.Remove(0, text.Length);
			}
			if (text2.IndexOf(Path.DirectorySeparatorChar) == 0)
			{
				text2 = text2.Remove(0, 1);
			}
			return text2;
		}

		private string GetFullDirPathWithCheckOnExistence(string rootKey)
		{
			string text = Path.Combine(RootDirectoryPath, PreparePath(rootKey));
			if (!FileSystemService.DirectoryExists(text))
			{
				throw new DirectoryNotFoundException(text);
			}
			return text;
		}

		private static string PreparePath(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return string.Empty;
			}
			List<string> list = path.Split(PossibleDirectorySeparators, StringSplitOptions.RemoveEmptyEntries).ToList();
			int num = 0;
			while (num < list.Count)
			{
				if (list[num] == ".." && num > 0)
				{
					list.RemoveAt(num);
					list.RemoveAt(num - 1);
					num--;
				}
				else
				{
					num++;
				}
			}
			if (list.Any() && list[0] == "..")
			{
				FileManagementExceptionExecutor.ThrowNoAccess();
			}
			return Path.Combine(list.ToArray());
		}

		private static void CheckThatDirOrFileNameIsNotEmpty(string dirOrFileName, string parameterName)
		{
			if (string.IsNullOrEmpty(dirOrFileName?.Trim()))
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		private void ValidateFileItemNameSymbols(string fileItemName)
		{
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			if (fileItemName.IndexOfAny(invalidFileNameChars) > -1)
			{
				FileManagementExceptionExecutor.ThrowInvalidSymbols();
			}
		}
	}
}
