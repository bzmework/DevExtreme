namespace DevExtreme.AspNet.Mvc.Builders
{
	public class CustomFileProviderBuilder : FileProviderBuilder
	{
		protected override string ClientFileProviderName => "DevExpress.fileProviders.Custom";

		public CustomFileProviderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		public CustomFileProviderBuilder GetItems(string jsFunc)
		{
			base.StoreOptions["getItems"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder GetItems(RazorBlock jsFunc)
		{
			return GetItems(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder CreateDirectory(string jsFunc)
		{
			base.StoreOptions["createDirectory"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder CreateDirectory(RazorBlock jsFunc)
		{
			return CreateDirectory(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder RenameItem(string jsFunc)
		{
			base.StoreOptions["renameItem"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder RenameItem(RazorBlock jsFunc)
		{
			return RenameItem(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder DeleteItem(string jsFunc)
		{
			base.StoreOptions["deleteItem"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder DeleteItem(RazorBlock jsFunc)
		{
			return DeleteItem(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder CopyItem(string jsFunc)
		{
			base.StoreOptions["copyItem"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder CopyItem(RazorBlock jsFunc)
		{
			return CopyItem(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder MoveItem(string jsFunc)
		{
			base.StoreOptions["moveItem"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder MoveItem(RazorBlock jsFunc)
		{
			return MoveItem(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder UploadFileChunk(string jsFunc)
		{
			base.StoreOptions["uploadFileChunk"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder UploadFileChunk(RazorBlock jsFunc)
		{
			return UploadFileChunk(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder AbortFileUpload(string jsFunc)
		{
			base.StoreOptions["abortFileUpload"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder AbortFileUpload(RazorBlock jsFunc)
		{
			return AbortFileUpload(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder DownloadItems(string jsFunc)
		{
			base.StoreOptions["downloadItems"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder DownloadItems(RazorBlock jsFunc)
		{
			return DownloadItems(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder GetItemsContent(string jsFunc)
		{
			base.StoreOptions["getItemsContent"] = new JS(jsFunc);
			return this;
		}

		public CustomFileProviderBuilder GetItemsContent(RazorBlock jsFunc)
		{
			return GetItemsContent(UnwrapJavaScriptFunc(jsFunc));
		}

		public CustomFileProviderBuilder UploadChunkSize(double value)
		{
			base.StoreOptions["uploadChunkSize"] = value;
			return this;
		}

		public CustomFileProviderBuilder UploadChunkSize(JS value)
		{
			base.StoreOptions["uploadChunkSize"] = value;
			return this;
		}
	}
}
