namespace DevExtreme.AspNet.Mvc.FileManagement.Internals
{
	internal enum FileManagementErrorCode
	{
		NoAccess = 0,
		FileExists = 1,
		FileNotFound = 2,
		DirectoryExists = 3,
		DirectoryNotFound = 4,
		WrongFileExtension = 5,
		MaxFileSizeExceeded = 6,
		InvalidSymbols = 7,
		Other = 0x7FFF
	}
}
