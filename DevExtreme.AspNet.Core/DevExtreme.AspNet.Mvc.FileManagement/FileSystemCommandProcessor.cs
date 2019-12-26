using DevExtreme.AspNet.Mvc.FileManagement.Internals;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public class FileSystemCommandProcessor
	{
		private const string PathInfoParameterKey = "pathInfo";

		private const string PathInfoListParameterKey = "pathInfoList";

		private const string SourcePathInfoParameterKey = "sourcePathInfo";

		private const string DestinationPathInfoParameterKey = "destinationPathInfo";

		private const string NewFileItemNameParameterKey = "name";

		private const string DestinationFileItemIdParameterKey = "destinationId";

		private const string ChunkMetadataParameterKey = "chunkMetadata";

		private const string UploadIdParameterKey = "uploadId";

		private IFileSystemService fileSystemService;

		private FileSystemConfiguration FileSystemConfiguration
		{
			get;
		}

		private IFileProvider FileSystemProvider => FileSystemConfiguration.FileSystemProvider;

		private IFileSystemService FileSystemService => fileSystemService ?? (fileSystemService = CreateFileSystemService());

		private HashSet<string> AllowedFileExtensions
		{
			get;
			set;
		}

		private long MaxUploadFileSize => FileSystemConfiguration.MaxUploadFileSize;

		public FileSystemCommandProcessor(FileSystemConfiguration fileSystemConfiguration)
		{
			ValidateFileSystemConfiguration(fileSystemConfiguration);
			FileSystemConfiguration = fileSystemConfiguration;
			AllowedFileExtensions = new HashSet<string>(FileSystemConfiguration.AllowedFileExtensions);
		}

		public FileSystemCommandResult Execute(FileSystemCommand command, string arguments)
		{
			return Execute(command, JsonConvert.DeserializeObject<IDictionary<string, object>>(arguments));
		}

		public FileSystemCommandResult Execute(FileSystemCommand command, IDictionary<string, object> arguments)
		{
			FileSystemCommandResult fileSystemCommandResult = new FileSystemCommandResult();
			try
			{
				fileSystemCommandResult.Result = ExecuteUnsafe(command, arguments);
				return fileSystemCommandResult;
			}
			catch (Exception ex)
			{
				Exception ex3 = fileSystemCommandResult.Exception = ex;
				return fileSystemCommandResult;
			}
		}

		private object ExecuteUnsafe(FileSystemCommand command, IDictionary<string, object> arguments)
		{
			switch (command)
			{
			case FileSystemCommand.GetDirContents:
				return ExecuteGetDirContentCommand(arguments);
			case FileSystemCommand.CreateDir:
				if (!FileSystemConfiguration.AllowCreate)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteCreateDirCommand(arguments);
			case FileSystemCommand.Rename:
				if (!FileSystemConfiguration.AllowRename)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteRenameCommand(arguments);
			case FileSystemCommand.Move:
				if (!FileSystemConfiguration.AllowMove)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteMoveCommand(arguments);
			case FileSystemCommand.Copy:
				if (!FileSystemConfiguration.AllowCopy)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteCopyCommand(arguments);
			case FileSystemCommand.Remove:
				if (!FileSystemConfiguration.AllowRemove)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteRemoveCommand(arguments);
			case FileSystemCommand.UploadChunk:
				if (!FileSystemConfiguration.AllowUpload)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteUploadChunkCommand(arguments);
			case FileSystemCommand.AbortUpload:
				if (!FileSystemConfiguration.AllowUpload)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteAbortUploadCommand(arguments);
			case FileSystemCommand.Download:
				if (!FileSystemConfiguration.AllowDownload)
				{
					FileManagementExceptionExecutor.ThrowNoAccess();
				}
				return ExecuteDownloadCommand(arguments);
			default:
				throw new NotSupportedException();
			}
		}

		private object ExecuteGetDirContentCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("pathInfo", args);
			return (from item in FileSystemProvider.GetDirectoryContents(pathInfoParam)
				where item.IsDirectory || IsValidFileExtension(item.Name)
				select item).ToList();
		}

		private object ExecuteCreateDirCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("pathInfo", args);
			string commandParam = GetCommandParam("name", args);
			FileSystemProvider.CreateDirectory(pathInfoParam, commandParam);
			return null;
		}

		private object ExecuteRenameCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("pathInfo", args);
			string commandParam = GetCommandParam("name", args);
			ValidateFileExtension(commandParam);
			FileSystemProvider.Rename(pathInfoParam, commandParam);
			return null;
		}

		private object ExecuteMoveCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("sourcePathInfo", args);
			FileItemPathInfo pathInfoParam2 = GetPathInfoParam("destinationPathInfo", args);
			FileSystemProvider.Move(pathInfoParam, pathInfoParam2);
			return null;
		}

		private object ExecuteCopyCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("sourcePathInfo", args);
			FileItemPathInfo pathInfoParam2 = GetPathInfoParam("destinationPathInfo", args);
			FileSystemProvider.Copy(pathInfoParam, pathInfoParam2);
			return null;
		}

		private object ExecuteRemoveCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo pathInfoParam = GetPathInfoParam("pathInfo", args);
			FileSystemProvider.Remove(pathInfoParam);
			return null;
		}

		private object ExecuteUploadChunkCommand(IDictionary<string, object> args)
		{
			FileChunkMetadata fileChunkMetadata = JsonConvert.DeserializeObject<FileChunkMetadata>(GetCommandParam("chunkMetadata", args));
			string uploadedFileName = GetUploadedFileName(fileChunkMetadata.UploadId);
			ValidateFileExtension(fileChunkMetadata.FileName);
			ValidateMaxUploadFileSize(fileChunkMetadata.FileSize);
			using (Stream chunkStream = Portability.GetRequestFileStream(FileSystemConfiguration.Request))
			{
				UploadFileChunk(uploadedFileName, chunkStream);
			}
			if (fileChunkMetadata.Index == fileChunkMetadata.TotalCount - 1)
			{
				string destinationKey = Path.Combine(GetCommandParam("destinationId", args), fileChunkMetadata.FileName);
				FileSystemProvider.MoveUploadedFile(new FileInfo(uploadedFileName), destinationKey);
			}
			return null;
		}

		private void UploadFileChunk(string uploadedFilePath, Stream chunkStream)
		{
			EnsureTempDirectoryCreated();
			using (FileStream fileStream = File.Open(uploadedFilePath, FileMode.Append, FileAccess.Write, FileShare.Read))
			{
				long size = fileStream.Length + chunkStream.Length;
				ValidateMaxUploadFileSize(size);
				chunkStream.CopyTo(fileStream);
			}
		}

		private object ExecuteAbortUploadCommand(IDictionary<string, object> args)
		{
			string commandParam = GetCommandParam("uploadId", args);
			string uploadedFileName = GetUploadedFileName(commandParam);
			FileSystemProvider.RemoveUploadedFile(new FileInfo(uploadedFileName));
			return null;
		}

		private object ExecuteDownloadCommand(IDictionary<string, object> args)
		{
			FileItemPathInfo[] pathInfoListParam = GetPathInfoListParam("pathInfoList", args);
			if (pathInfoListParam.Length == 0)
			{
				return null;
			}
			if (pathInfoListParam.Length == 1)
			{
				FileItemPathInfo pathInfo = pathInfoListParam[0];
				return GetFileContentResult(pathInfo);
			}
			return CreateZipArchive(pathInfoListParam);
		}

		private FileContentResult CreateZipArchive(FileItemPathInfo[] pathInfos)
		{
			EnsureTempDirectoryCreated();
			CleanUpDownloadedArchives();
			string fileName = "dxdownload_" + Guid.NewGuid().ToString("N") + ".zip";
			string tempFilePath = GetTempFilePath(fileName);
			FileStream fileStream = null;
			try
			{
				fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create, leaveOpen: true))
				{
					foreach (FileItemPathInfo fileItemPathInfo in pathInfos)
					{
						ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry(fileItemPathInfo.GetFileItemName());
						using (Stream stream = FileSystemProvider.GetFileContent(fileItemPathInfo))
						{
							using (Stream destination = zipArchiveEntry.Open())
							{
								stream.CopyTo(destination);
							}
						}
					}
				}
				fileStream.Flush();
				fileStream.Seek(0L, SeekOrigin.Begin);
				return new FileContentResult(fileStream, "files.zip");
			}
			catch
			{
				fileStream?.Dispose();
				throw;
			}
		}

		private FileContentResult GetFileContentResult(FileItemPathInfo pathInfo)
		{
			string fileItemName = pathInfo.GetFileItemName();
			return new FileContentResult(FileSystemProvider.GetFileContent(pathInfo), fileItemName);
		}

		private void CleanUpDownloadedArchives()
		{
			TimeSpan timeout = TimeSpan.FromHours(1.0);
			try
			{
				foreach (FileInfo item in from file in new DirectoryInfo(FileSystemConfiguration.UploadTempPath).GetFiles("dxdownload_*.zip")
					where DateTime.UtcNow - file.LastWriteTimeUtc > timeout
					select file)
				{
					try
					{
						item.Delete();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		private string GetTempFilePath(string fileName)
		{
			return Path.Combine(FileSystemConfiguration.UploadTempPath, fileName);
		}

		private void EnsureTempDirectoryCreated()
		{
			if (!FileSystemService.DirectoryExists(FileSystemConfiguration.UploadTempPath))
			{
				FileSystemService.CreateDirectory(FileSystemConfiguration.UploadTempPath);
			}
		}

		private static FileItemPathInfo GetPathInfoParam(string key, IDictionary<string, object> args)
		{
			return FileItemPathInfo.Create(args.ContainsKey(key) ? (args[key] as JArray) : null);
		}

		private static FileItemPathInfo[] GetPathInfoListParam(string key, IDictionary<string, object> args)
		{
			JArray jArray = args.ContainsKey(key) ? (args[key] as JArray) : null;
			if (jArray == null)
			{
				return new FileItemPathInfo[0];
			}
			return (from JArray rawInfo in jArray
				select FileItemPathInfo.Create(rawInfo)).ToArray();
		}

		private static string GetCommandParam(string key, IDictionary<string, object> args)
		{
			if (!args.ContainsKey(key))
			{
				return null;
			}
			return args[key]?.ToString();
		}

		private IFileSystemService CreateFileSystemService()
		{
			return new DefaultFileSystemService();
		}

		private string GetUploadedFileName(string id)
		{
			string fileName = "dxupload_" + id + ".tmp";
			return GetTempFilePath(fileName);
		}

		private void ValidateFileSystemConfiguration(FileSystemConfiguration config)
		{
			if (config == null)
			{
				throw new ArgumentNullException("config");
			}
			if (config.FileSystemProvider == null)
			{
				throw new ArgumentNullException("FileSystemProvider");
			}
			if (config.Request == null)
			{
				throw new ArgumentNullException("Request");
			}
		}

		private bool IsValidFileExtension(string name)
		{
			if (AllowedFileExtensions.Count == 0)
			{
				return true;
			}
			string extension = Path.GetExtension(name);
			return AllowedFileExtensions.Contains(extension);
		}

		private void ValidateFileExtension(string name)
		{
			if (!IsValidFileExtension(name))
			{
				FileManagementExceptionExecutor.ThrowWrongFileExtension();
			}
		}

		private void ValidateMaxUploadFileSize(long size)
		{
			if (MaxUploadFileSize > 0 && size > MaxUploadFileSize)
			{
				FileManagementExceptionExecutor.ThrowMaxFileSizeExceeded();
			}
		}
	}
}
