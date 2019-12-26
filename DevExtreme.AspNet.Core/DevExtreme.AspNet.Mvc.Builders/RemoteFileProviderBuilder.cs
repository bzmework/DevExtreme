namespace DevExtreme.AspNet.Mvc.Builders
{
	public class RemoteFileProviderBuilder : FileProviderBuilder
	{
		protected override string ClientFileProviderName => "DevExpress.fileProviders.Remote";

		public RemoteFileProviderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		public RemoteFileProviderBuilder Url(string url)
		{
			base.StoreOptions["endpointUrl"] = Portability.GetContentUrl(base.ViewContext, url);
			return this;
		}
	}
}
