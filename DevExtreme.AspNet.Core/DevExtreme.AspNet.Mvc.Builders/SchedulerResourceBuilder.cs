using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies an array of resources available in the scheduler.</summary>
	public class SchedulerResourceBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public SchedulerResourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SchedulerResourceBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Indicates whether or not several resources of this kind can be assigned to an appointment.</summary>
		[Generated]
		public SchedulerResourceBuilder AllowMultiple(bool value)
		{
			base.Options["allowMultiple"] = value;
			return this;
		}

		/// <summary>Indicates whether or not several resources of this kind can be assigned to an appointment.</summary>
		[Generated]
		public SchedulerResourceBuilder AllowMultiple(JS value)
		{
			base.Options["allowMultiple"] = value;
			return this;
		}

		/// <summary>Specifies the resource object field that is used as a resource color.</summary>
		[Generated]
		public SchedulerResourceBuilder ColorExpr(string value)
		{
			base.Options["colorExpr"] = value;
			return this;
		}

		/// <summary>Specifies the resource object field that is used as a resource color.</summary>
		[Generated]
		public SchedulerResourceBuilder ColorExpr(JS value)
		{
			base.Options["colorExpr"] = value;
			return this;
		}

		/// <summary>Specifies available resource instances.</summary>
		[Generated]
		public SchedulerResourceBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies available resource instances.</summary>
		[Generated]
		public SchedulerResourceBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies available resource instances.</summary>
		[Generated]
		public SchedulerResourceBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies available resource instances.</summary>
		[Generated]
		public SchedulerResourceBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies available resource instances.</summary>
		[Generated]
		public SchedulerResourceBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies which field from the resource data objects provides values to be displayed in the resource editor.</summary>
		[Generated]
		public SchedulerResourceBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies which field from the resource data objects provides values to be displayed in the resource editor.</summary>
		[Generated]
		public SchedulerResourceBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>The name of the appointment object field that specifies a resource of this kind.</summary>
		[Generated]
		public SchedulerResourceBuilder FieldExpr(string value)
		{
			base.Options["fieldExpr"] = value;
			return this;
		}

		/// <summary>The name of the appointment object field that specifies a resource of this kind.</summary>
		[Generated]
		public SchedulerResourceBuilder FieldExpr(JS value)
		{
			base.Options["fieldExpr"] = value;
			return this;
		}

		/// <summary>Specifies the label of the Appointment popup window field that allows end users to assign a resource of this kind.</summary>
		[Generated]
		public SchedulerResourceBuilder Label(string value)
		{
			base.Options["label"] = value;
			return this;
		}

		/// <summary>Specifies the label of the Appointment popup window field that allows end users to assign a resource of this kind.</summary>
		[Generated]
		public SchedulerResourceBuilder Label(JS value)
		{
			base.Options["label"] = value;
			return this;
		}

		/// <summary>Specifies whether appointments are colored like this resource kind.</summary>
		[Generated]
		public SchedulerResourceBuilder UseColorAsDefault(bool value)
		{
			base.Options["useColorAsDefault"] = value;
			return this;
		}

		/// <summary>Specifies whether appointments are colored like this resource kind.</summary>
		[Generated]
		public SchedulerResourceBuilder UseColorAsDefault(JS value)
		{
			base.Options["useColorAsDefault"] = value;
			return this;
		}

		/// <summary>Specifies the resource object field that is used as a value of the Resource editor in the Appointment popup window.</summary>
		[Generated]
		public SchedulerResourceBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies the resource object field that is used as a value of the Resource editor in the Appointment popup window.</summary>
		[Generated]
		public SchedulerResourceBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}
	}
}
