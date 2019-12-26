using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// ActionSheet�ؼ���һ������һ�鰴ť�Ĺ�������Щ��ťһ������һ�������档
	/// ��Щ��ťͨ����ʾ�뵥��������صĶ��ѡ��
	/// The ActionSheet widget is a sheet containing a set of buttons located one under the other. 
	/// These buttons usually represent several choices relating to a single task.
	/// </summary>
	public class ActionSheetBuilder : WidgetBuilder
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		[Generated]
		public ActionSheetBuilder(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// ָ���ؼ���Ԫ�ص�HTML id�� 
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// ָ��һ��JS���ʽ���ñ��ʽ����ģ���ж���Ŀؼ���Ԫ�ص�HTML id�� 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// �رղ�����İ�ť����ʾ���ı��� 
		/// The text displayed in the button that closes the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder CancelText(string value)
		{
			base.Options["cancelText"] = value;
			return this;
		}

		/// <summary>
		/// �رղ�����İ�ť����ʾ���ı��� 
		/// The text displayed in the button that closes the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder CancelText(JS value)
		{
			base.Options["cancelText"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵����ݡ� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û������� 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û������� 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣʱ�ؼ��Ƿ������״̬�� 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public ActionSheetBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		///  ָ�����û���ͣʱ�ؼ��Ƿ������״̬�� 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public ActionSheetBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ����onItemHold�¼�֮ǰ��ʱ��Σ����룩�� 
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// ����onItemHold�¼�֮ǰ��ʱ��Σ����룩��
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ���ʾ����Ŀ���顣 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Items(Action<CollectionFactory<ActionSheetItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// ��������ȡ����ťʱִ�е�һ�ֹ��ܡ� 
		/// A function that is executed when the Cancel button is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnCancelClick(string jsFunc)
		{
			AssignJS("onCancelClick", jsFunc);
			return this;
		}

		/// <summary>
		/// ��������ȡ����ťʱִ�е�һ�ֹ��ܡ� 
		/// A function that is executed when the Cancel button is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnCancelClick(RazorBlock jsFunc)
		{
			return OnCancelClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ�������׼���ò�ÿ�θ�������ʱִ�еĺ����� 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ�������׼���ò�ÿ�θ�������ʱִ�еĺ����� 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ����� 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ����� 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ����� 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ����� 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// һ���ڵ������һ��������ʱִ�еĺ����� 
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// һ���ڵ������һ��������ʱִ�еĺ����� 
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �Ҽ������򰴼�����ʱִ�еĺ����� 
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>
		/// �Ҽ������򰴼�����ʱִ�еĺ����� 
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �������������һ��ʱ��ʱִ�еĺ����� 
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>
		/// �������������һ��ʱ��ʱִ�еĺ����� 
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ּ������ִ�еĺ����� 
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ּ������ִ�еĺ����� 
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ����� 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ����� 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ�� 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public ActionSheetBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ�� 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public ActionSheetBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڲ���������ʾ"ȡ��"��ť�� 
		/// Specifies whether or not to display the Cancel button in action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowCancelButton(bool value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڲ���������ʾ"ȡ��"��ť��
		/// Specifies whether or not to display the Cancel button in action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowCancelButton(JS value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>
		/// һ������ֵ��ָ��������ı����Ƿ�ɼ��� 
		/// A Boolean value specifying whether or not the title of the action sheet is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowTitle(bool value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>
		/// һ������ֵ��ָ��������ı����Ƿ�ɼ��� 
		/// A Boolean value specifying whether or not the title of the action sheet is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowTitle(JS value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>
		/// ָ���������������ڵ�Ԫ�ء�����usePopoverΪ��ʱ�����á� 
		/// Specifies the element the action sheet popover points at. Applies only if usePopover is true.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>
		/// ָ���������������ڵ�Ԫ�ء�����usePopoverΪ��ʱ�����á� 
		/// Specifies the element the action sheet popover points at. Applies only if usePopover is true.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>
		/// ������ı��⡣ 
		/// The title of the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// ������ı��⡣ 
		/// The title of the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڵ������ڿؼ�����ʾ������ 
		/// Specifies whether or not to show the action sheet within a Popover widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder UsePopover(bool value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڵ������ڿؼ�����ʾ������ 
		/// Specifies whether or not to show the action sheet within a Popover widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder UsePopover(JS value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>
		/// һ������ֵ��ָ��ActionSheetС�����Ƿ�ɼ��� 
		/// A Boolean value specifying whether or not the ActionSheet widget is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// һ������ֵ��ָ��ActionSheetС�����Ƿ�ɼ��� 
		/// A Boolean value specifying whether or not the ActionSheet widget is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ� 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ� 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ� 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
