using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// Accordion�ؼ�������������ʾ����һ������µ���塣
	/// ��Щ�������������û��۵���չ������ʹ�����С�������������޵Ŀռ�����ʾ��Ϣ�ǳ����á�
	/// The Accordion widget contains several panels displayed one under another. 
	/// These panels can be collapsed or expanded by an end user, which makes this widget very useful for presenting information in a limited amount of space.
	/// </summary>
	public class AccordionBuilder : WidgetBuilder
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		[Generated]
		public AccordionBuilder(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// ָ���ؼ���Ԫ�ص�HTML id��
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// ָ��һ��JS���ʽ���ñ��ʽ����ģ���ж����С������Ԫ�ص�HTML id�� 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public AccordionBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AccordionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// ָ�����ÿؼ���ý���Ŀ�ݼ���
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����ÿؼ���ý���Ŀ�ݼ��� 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ������û�����ʱ�Ƿ������״̬�� 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AccordionBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ������û�����ʱ�Ƿ������״̬�� 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AccordionBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A number specifying the time in milliseconds spent on the animation of the expanding or collapsing of a panel.</summary>
		[Generated]
		public AccordionBuilder AnimationDuration(double value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����չ�����۵�ʱ���������õ�ʱ�䣨���������� 
		/// A number specifying the time in milliseconds spent on the animation of the expanding or collapsing of a panel.
		/// </summary>
		[Generated]
		public AccordionBuilder AnimationDuration(JS value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�����۵�����������Ƿ����ʼ��չ������һ��� 
		/// Specifies whether all items can be collapsed or whether at least one item must always be expanded.
		/// </summary>
		[Generated]
		public AccordionBuilder Collapsible(bool value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�����۵�����������Ƿ����ʼ��չ������һ��� 
		/// Specifies whether all items can be collapsed or whether at least one item must always be expanded.
		/// </summary>
		[Generated]
		public AccordionBuilder Collapsible(JS value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ��
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AccordionBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ��
		/// Binds the widget to data.
		/// </summary>
		/// <param name="staticJsonUrl">����Json���ݵ�Url</param>
		/// <param name="key">ɸѡָ��key������</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ��
		/// Binds the widget to data.
		/// </summary>
		/// <param name="data">���ݣ������б��</param>
		/// <param name="key">ɸѡָ��key������</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ��
		/// Binds the widget to data.
		/// </summary>
		/// <param name="js">Js�ű�</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ��
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AccordionBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// ָ������ʾ�������ʱ�Ƿ���ָ����ݡ����Ϊfalse���������������ݡ� 
		/// Specifies whether to render the panel's content when it is displayed. If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AccordionBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// ָ������ʾ�������ʱ�Ƿ���ָ����ݡ����Ϊfalse���������������ݡ�
		/// Specifies whether to render the panel's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AccordionBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û������� 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AccordionBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û�������
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AccordionBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(string attributeName, object value)
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
		public AccordionBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ����ʹ�ü��̵������۽��ؼ��� 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AccordionBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ����ʹ�ü��̵������۽��ؼ��� 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AccordionBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣʱ�ؼ��Ƿ������״̬�� 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AccordionBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣʱ�ؼ��Ƿ������״̬�� 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AccordionBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ����onItemHold�¼�֮ǰ��ʱ��Σ����������� 
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public AccordionBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// ����onItemHold�¼�֮ǰ��ʱ��Σ�����������
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public AccordionBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ���ʾ����Ŀ���顣 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Items(Action<CollectionFactory<AccordionItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// Ϊ��ָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// <param name="templateContent">ģ������</param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��ָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// <param name="templateContent">ģ�����ݣ�һ��Razor Block</param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��ָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		/// <param name="name">ģ������</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// Ϊ��ָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// <param name="value"></param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀ����ָ���Զ���ģ�塣 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="templateContent">ģ������</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(string templateContent)
		{
			AssignTemplate("itemTitleTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀ����ָ���Զ���ģ�塣 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="templateContent">ģ�����ݣ�һ��Razor Block</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTitleTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀ����ָ���Զ���ģ�塣 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="name">ģ������</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(TemplateName name)
		{
			AssignTemplate("itemTitleTemplate", name);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀ����ָ���Զ���ģ�塣 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(JS value)
		{
			base.Options["itemTitleTemplate"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ĸ������ֶ�Ϊ�ؼ����ṩ���� 
		/// Specifies which data field provides keys for widget items.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ĸ������ֶ�Ϊ�ؼ����ṩ���� 
		/// Specifies which data field provides keys for widget items.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ǿ���ͬʱչ����������ֻ��չ�������
		/// Specifies whether the widget can expand several items or only a single item at once.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder Multiple(bool value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ǿ���ͬʱչ����������ֻ��չ�������
		/// Specifies whether the widget can expand several items or only a single item at once.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder Multiple(JS value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>
		/// �����Ŀ����Ϊ�գ��ؼ���ʾ���ı���HTML��ǡ�
		/// The text or HTML markup displayed by the widget if the item collection is empty.
		/// </summary>
		[Generated]
		public AccordionBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>
		/// �����Ŀ����Ϊ�գ��ؼ���ʾ���ı���HTML��ǡ�
		/// The text or HTML markup displayed by the widget if the item collection is empty.
		/// </summary>
		[Generated]
		public AccordionBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>
		/// һ�����������ؼ�������׼���ò���ÿ�����ݸ���ʱִ�С�
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// һ�����������ؼ�������׼���ò���ÿ�����ݸ���ʱִ�С�
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ�����
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AccordionBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ�����
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AccordionBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ�����
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AccordionBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ�����
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AccordionBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڵ��������������ʱִ�еĺ�����
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڵ��������������ʱִ�еĺ�����
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �һ����¼�����ʱִ�еĺ�����
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>
		/// �һ����¼�����ʱִ�еĺ�����
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// һ����������һ�����������һ��ָ����ʱ���ִ�С�
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>
		/// һ����������һ�����������һ��ָ����ʱ���ִ�С�
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڳ��ּ������ִ�еĺ�����
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڳ��ּ������ִ�еĺ�����
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڵ���������ַ�����ı���ʱִ�еĺ�����
		/// A function that is executed when an accordion item's title is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemTitleClick(string jsFunc)
		{
			AssignJS("onItemTitleClick", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڵ���������ַ�����ı���ʱִ�еĺ�����
		/// A function that is executed when an accordion item's title is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemTitleClick(RazorBlock jsFunc)
		{
			return OnItemTitleClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ�����
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ�����
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ��ѡ�񼯺����ȡ��ѡ��ʱִ�еĺ�����
		/// A function that is executed when a collection item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AccordionBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// ��ѡ�񼯺����ȡ��ѡ��ʱִ�еĺ�����
		/// A function that is executed when a collection item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AccordionBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ָ���Ƿ�����»����������Ѹ��ĵ�Ԫ�ء�
		/// Specifies whether to repaint only those elements whose data changed.
		/// </summary>
		[Generated]
		public AccordionBuilder RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�����»����������Ѹ��ĵ�Ԫ�ء�
		/// Specifies whether to repaint only those elements whose data changed.
		/// </summary>
		[Generated]
		public AccordionBuilder RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ��ʽ��
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AccordionBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ��ʽ��
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AccordionBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ��ǰѡ����������š�
		/// The index number of the currently selected item.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>
		/// ��ǰѡ����������š�
		/// The index number of the currently selected item.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>
		/// ѡ������Ŀ����
		/// The selected item object.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ǰѡ����Ŀ�������顣
		/// Specifies an array of currently selected item keys.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ǰѡ����Ŀ�������顣
		/// Specifies an array of currently selected item keys.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>
		/// ��ǰѡ������������顣
		/// An array of currently selected item objects.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>
		/// ��ǰѡ������������顣
		/// An array of currently selected item objects.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>
		/// ָ��ʹ��Tab�����е���ʱԪ�ص�������
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AccordionBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// ָ��ʹ��Tab�����е���ʱԪ�ص�������
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AccordionBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ�ɼ���
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AccordionBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ�ɼ���
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AccordionBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ�
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ�
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ�
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
