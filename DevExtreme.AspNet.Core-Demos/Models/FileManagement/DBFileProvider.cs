using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DevExtreme.AspNet.Mvc.FileManagement;
using DevExtreme.AspNet.Mvc.FileManagement.Internals;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace DevExtreme.NETCore.Demos.Models.FileManagement {
    public class DbFileProvider : IFileProvider {

        class ClientFileSystemItem : IClientFileSystemItem {
            public ClientFileSystemItem() {
                CustomFields = new Dictionary<string, object>();
            }
            public object Key { get; set; }
            public string Name { get; set; }
            public DateTime DateModified { get; set; }
            public bool IsDirectory { get; set; }
            public long Size { get; set; }
            public bool HasSubDirectories { get; set; }
            public IDictionary<string, object> CustomFields { get; }
        }

        const int GuestPersonId = 1;

        public DbFileProvider(FileManagementDbContext fileManagementDbContext, IHttpContextAccessor contextAccessor, IMemoryCache memoryCache) {
            FileManagementDbContext = new InMemoryFileManagementDataContext(fileManagementDbContext, contextAccessor, memoryCache);
        }

        InMemoryFileManagementDataContext FileManagementDbContext { get; }

        public IList<IClientFileSystemItem> GetDirectoryContents(FileItemPathInfo pathInfo) {
            var fileItems = GetDirectoryContents(pathInfo.GetFileItemKey<int>());
            var hasSubDirectoriesInfo = GetHasSubDirectoriesInfo(fileItems);

            var clientItemList = new List<IClientFileSystemItem>();
            foreach(var item in fileItems) {
                var clientItem = new ClientFileSystemItem {
                    Key = item.Id,
                    Name = item.Name,
                    IsDirectory = item.IsDirectory,
                    DateModified = item.Modified
                };

                if(item.IsDirectory) {
                    clientItem.HasSubDirectories = hasSubDirectoriesInfo.ContainsKey(item.Id) && hasSubDirectoriesInfo[item.Id];
                }

                clientItem.CustomFields["modifiedBy"] = item.ModifiedBy.FullName;
                clientItem.CustomFields["created"] = item.Created;
                clientItemList.Add(clientItem);
            }
            return clientItemList;
        }

        public void CreateDirectory(FileItemPathInfo pathInfo, string name) {
            if(!IsFileItemExists(pathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(pathInfo.GetPath());

            var directory = new FileItem {
                Name = name,
                Modified = DateTime.Now,
                Created = DateTime.Now,
                IsDirectory = true,
                ParentId = pathInfo.GetFileItemKey<int>(),
                ModifiedById = GuestPersonId
            };
            FileManagementDbContext.FileItems.Add(directory);
            FileManagementDbContext.SaveChanges();
        }

        public void Rename(FileItemPathInfo pathInfo, string newName) {
            if(!IsFileItemExists(pathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(pathInfo.GetPath());

            var fileItem = GetFileItem(pathInfo);
            fileItem.Name = newName;
            fileItem.ModifiedById = GuestPersonId;
            fileItem.Modified = DateTime.Now;
            FileManagementDbContext.SaveChanges();
        }

        public void Move(FileItemPathInfo pathInfo, FileItemPathInfo destinationPathInfo) {
            if(!IsFileItemExists(pathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(pathInfo.GetPath());
            if(!IsFileItemExists(destinationPathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(pathInfo.GetPath());
            if(!AllowCopyOrMove(pathInfo, destinationPathInfo))
                FileManagementExceptionExecutor.ThrowNoAccess();

            var fileItem = GetFileItem(pathInfo);
            fileItem.ParentId = destinationPathInfo.GetFileItemKey<int>();
            fileItem.Modified = DateTime.Now;
            fileItem.ModifiedById = GuestPersonId;
            FileManagementDbContext.SaveChanges();
        }

        public void Copy(FileItemPathInfo sourcePathInfo, FileItemPathInfo destinationPathInfo) {
            if(!IsFileItemExists(sourcePathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(sourcePathInfo.GetPath());
            if(!IsFileItemExists(destinationPathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(sourcePathInfo.GetPath());
            if(!AllowCopyOrMove(sourcePathInfo, destinationPathInfo))
                FileManagementExceptionExecutor.ThrowNoAccess();

            var sourceFileItem = GetFileItem(sourcePathInfo);
            var copyFileItem = CreateCopy(sourceFileItem);
            copyFileItem.ParentId = destinationPathInfo.GetFileItemKey<int>();
            copyFileItem.Name = GenerateCopiedFileItemName(destinationPathInfo.GetFileItemKey<int>(), copyFileItem.Name, copyFileItem.IsDirectory);
            FileManagementDbContext.FileItems.Add(copyFileItem);

            if(copyFileItem.IsDirectory)
                CopyDirectoryContentRecursive(sourceFileItem, copyFileItem);
            FileManagementDbContext.SaveChanges();
        }

        void CopyDirectoryContentRecursive(FileItem sourcePathInfo, FileItem destinationPathInfo) {
            foreach(var fileItem in GetDirectoryContents(sourcePathInfo.Id)) {
                var copyItem = CreateCopy(fileItem);
                copyItem.Parent = destinationPathInfo;
                FileManagementDbContext.FileItems.Add(copyItem);
                if(fileItem.IsDirectory)
                    CopyDirectoryContentRecursive(fileItem, copyItem);
            }
        }

        public void Remove(FileItemPathInfo pathInfo) {
            if(!IsFileItemExists(pathInfo))
                FileManagementExceptionExecutor.ThrowDirectoryExists(pathInfo.GetPath());

            var fileItem = GetFileItem(pathInfo);
            FileManagementDbContext.FileItems.Remove(fileItem);

            if(fileItem.IsDirectory)
                RemoveDirectoryContentRecursive(fileItem.Id);

            FileManagementDbContext.SaveChanges();
        }

        void RemoveDirectoryContentRecursive(int parenDirectoryKey) {
            var itemsToRemove = FileManagementDbContext
                .FileItems
                .Where(item => item.ParentId == parenDirectoryKey)
                .Select(item => new FileItem {
                    Id = item.Id,
                    IsDirectory = item.IsDirectory
                });
            foreach(var item in itemsToRemove) {
                FileManagementDbContext.FileItems.Remove(item);
            }

            foreach(var item in itemsToRemove) {
                if(!item.IsDirectory) continue;

                RemoveDirectoryContentRecursive(item.Id);
            }
        }

        public void MoveUploadedFile(FileInfo file, string destinationKey) {
            throw new System.NotImplementedException();
        }

        public void RemoveUploadedFile(FileInfo file) {
            throw new System.NotImplementedException();
        }

        public Stream GetFileContent(FileItemPathInfo pathInfo) {
            throw new System.NotImplementedException();
        }

        IEnumerable<FileItem> GetDirectoryContents(int parentKey) {
            return FileManagementDbContext.FileItems
                .OrderByDescending(item => item.IsDirectory)
                .ThenBy(item => item.Name)
                .Where(items => items.ParentId == parentKey);
        }
        IDictionary<int, bool> GetHasSubDirectoriesInfo(IEnumerable<FileItem> fileItems) {
            var keys = fileItems.Select(i => i.Id).ToArray();
            return FileManagementDbContext.FileItems
                .Where(item => item.IsDirectory)
                .GroupBy(i => i.ParentId)
                .Where(i => keys.Contains(i.Key))
                .ToDictionary(group => group.Key, group => group.Any());
        }

        FileItem GetFileItem(FileItemPathInfo pathInfo) {
            return FileManagementDbContext.FileItems.FirstOrDefault(i => i.Id == pathInfo.GetFileItemKey<int>());
        }

        bool IsFileItemExists(FileItemPathInfo pathInfo) {
            var clientPathParts = pathInfo.GetPathParts<int>();
            var pathKeys = clientPathParts.Select(p => p.Key).ToArray();
            var foundEntries = FileManagementDbContext.FileItems
                .Where(item => pathKeys.Contains(item.Id))
                .Select(item => new { item.Id, item.ParentId, item.Name, item.IsDirectory });

            var isDirectoryExists = true;
            for(var i = 0; i < clientPathParts.Length && isDirectoryExists; i++) {
                var entry = foundEntries.FirstOrDefault(e => e.Id == clientPathParts[i].Key);
                isDirectoryExists = entry != null && entry.Name == clientPathParts[i].Name &&
                                    (i == 0 && entry.ParentId == 0 || entry.ParentId == clientPathParts[i - 1].Key);
                if(isDirectoryExists && i < clientPathParts.Length - 1)
                    isDirectoryExists = entry.IsDirectory;
            }
            return isDirectoryExists;
        }

        static bool AllowCopyOrMove(FileItemPathInfo pathInfo, FileItemPathInfo destinationPathInfo) {
            var sourcePathParts = pathInfo.GetPathParts<int>();
            var destinationPathParts = destinationPathInfo.GetPathParts<int>();

            if(destinationPathParts.Length < sourcePathParts.Length)
                return true;

            var isValid = false;
            for(var i = 0; i < destinationPathParts.Length && !isValid; i++) {
                isValid = destinationPathParts[i].Key != sourcePathParts[i].Key;
            }
            return isValid;
        }

        static FileItem CreateCopy(FileItem fileItem) {
            return new FileItem {
                Name = fileItem.Name,
                Created = DateTime.Now,
                Modified = DateTime.Now,
                IsDirectory = fileItem.IsDirectory,
                ModifiedById = GuestPersonId
            };
        }

        string GenerateCopiedFileItemName(int parentDirKey, string copiedFileItemName, bool isDirectory) {
            var dirNames = GetDirectoryContents(parentDirKey)
                .Where(i => i.IsDirectory == isDirectory)
                .Select(i => i.Name);

            string newName;
            var fileExtension = isDirectory ? "" : "." + Path.GetExtension(copiedFileItemName);
            var copyNamePrefix =
                isDirectory ? copiedFileItemName : Path.GetFileNameWithoutExtension(copiedFileItemName);
            var index = -1;
            do {
                var pathPostfix = index < 1 ? string.Empty : $" {index}{fileExtension}";
                newName = $"{copyNamePrefix} {(index < 0 ? "" : "copy")}{pathPostfix}";
                index++;
            } while(dirNames.Contains(newName));
            return newName;
        }
    }
}
