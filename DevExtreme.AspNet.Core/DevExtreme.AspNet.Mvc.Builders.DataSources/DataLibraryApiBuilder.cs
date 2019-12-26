namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public abstract class DataLibraryApiBuilder<TSelf> : StoreDataSourceBuilder where TSelf : DataLibraryApiBuilder<TSelf>
	{
		private const string LOAD = "load";

		private const string INSERT = "insert";

		private const string UPDATE = "update";

		private const string DELETE = "delete";

		public DataLibraryApiBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the key property or properties.
		/// </summary>
		/// <param name="key">A key property or properties.</param>
		public TSelf Key(params string[] key)
		{
			SetKey(key);
			return (TSelf)this;
		}

		/// <summary>
		/// Specifies a function used to customize a web request before it is sent.
		/// </summary>
		/// <param name="jsFunc">A JavaScript function.</param>
		public TSelf OnBeforeSend(string jsFunc)
		{
			StoreOptions["onBeforeSend"] = new JS(jsFunc);
			return (TSelf)this;
		}

		/// <summary>
		/// Specifies a function used to customize a web request before it is sent.
		/// </summary>
		/// <param name="jsFunc">A RazorBlock containing a JavaScript function.</param>
		public TSelf OnBeforeSend(RazorBlock jsFunc)
		{
			return OnBeforeSend(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// Specifies additional parameters to pass with the load request.
		/// </summary>
		/// <param name="params">Load parameters.</param>
		public TSelf LoadParams(object @params)
		{
			StoreOptions["loadParams"] = @params;
			return (TSelf)this;
		}

		/// <summary>
		/// Specifies the HTTP method for load requests; "GET" by default.
		/// Requires DevExtreme.AspNet.Data &gt;= 1.4.
		/// </summary>
		/// <param name="httpMethod">An HTTP method.</param>
		public TSelf LoadMethod(string httpMethod)
		{
			return SetMethod("load", httpMethod);
		}

		/// <summary>
		/// Specifies the HTTP method for update requests; "PUT" by default.
		/// </summary>
		/// <param name="httpMethod">An HTTP method.</param>
		public TSelf UpdateMethod(string httpMethod)
		{
			return SetMethod("update", httpMethod);
		}

		/// <summary>
		/// Specifies the HTTP method for insert requests; "POST" by default.
		/// </summary>
		/// <param name="httpMethod">An HTTP method.</param>
		public TSelf InsertMethod(string httpMethod)
		{
			return SetMethod("insert", httpMethod);
		}

		/// <summary>
		/// Specifies the HTTP method for delete requests; "DELETE" by default.
		/// </summary>
		/// <param name="httpMethod">An HTTP method.</param>
		public TSelf DeleteMethod(string httpMethod)
		{
			return SetMethod("delete", httpMethod);
		}

		protected override string FormatStoreFactory(string args)
		{
			return "DevExpress.data.AspNet.createStore(" + args + ")";
		}

		protected override void CustomizeStoreOptions()
		{
			SetUrl("load", BuildLoadUrl());
			SetUrl("insert", BuildInsertUrl());
			SetUrl("update", BuildUpdateUrl());
			SetUrl("delete", BuildDeleteUrl());
		}

		protected abstract string BuildLoadUrl();

		protected abstract string BuildInsertUrl();

		protected abstract string BuildUpdateUrl();

		protected abstract string BuildDeleteUrl();

		private TSelf SetMethod(string op, string value)
		{
			return SetStoreOptionIfNotEmpty(op + "Method", value);
		}

		private TSelf SetUrl(string op, string value)
		{
			return SetStoreOptionIfNotEmpty(op + "Url", value);
		}

		private TSelf SetStoreOptionIfNotEmpty(string key, string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				StoreOptions[key] = value;
			}
			return (TSelf)this;
		}
	}
}
