using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// Autocomplete�ؼ���һ���ı��򣬵��û�����ʱ�����ṩ���顣 
	/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
	/// </summary>
	public class AutocompleteBuilder : WidgetBuilder
	{
		[Obsolete("displayValueѡ����ֻ���ġ����ô˷�������Ӱ��ؼ���The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AutocompleteBuilder DisplayValue(string value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Obsolete("displayValueѡ����ֻ���ġ����ô˷�������Ӱ��ؼ���The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AutocompleteBuilder DisplayValue(JS value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Generated]
		public AutocompleteBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// ָ���ؼ���Ԫ�ص�HTML id�� 
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// ָ��һ��JS���ʽ���ñ��ʽ����ģ���ж���Ŀؼ���Ԫ�ص�HTML id�� 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// ָ������С��������Ŀ�ݼ��� 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// ָ������С��������Ŀ�ݼ��� 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ������û�����ʱ�Ƿ������״̬�� 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ������û�����ʱ�Ƿ������״̬�� 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ���������Զ��尴ť��ӵ������ı��ֶΡ� 
		/// Allows you to add custom buttons to the input text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>
		/// ���������Զ��尴ť��ӵ������ı��ֶΡ� 
		/// Allows you to add custom buttons to the input text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// ���ؼ��󶨵�����Դ�� 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// ָ����ʾ�����ֶ�ʱ�Ƿ���������ݡ����Ϊfalse���������������ݡ�
		/// Specifies whether to render the drop-down field's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ʾ�����ֶ�ʱ�Ƿ���������ݡ����Ϊfalse���������������ݡ�
		/// Specifies whether to render the drop-down field's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û�������
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ���Ӧ�û�������
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ��������ť���Զ���ģ�塣 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��������ť���Զ���ģ�塣 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��������ť���Զ���ģ�塣 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>
		/// ָ��������ť���Զ���ģ�塣 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(string attributeName, object value)
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
		public AutocompleteBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ӵ��ؼ���Ԫ�ص����ԡ� 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ����ʹ�ü��̵������۽�С�ؼ��� 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ����ʹ�ü��̵������۽�С�ؼ��� 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ����������з��顣 
		/// Specifies whether data items should be grouped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ����������з��顣 
		/// Specifies whether data items should be grouped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>
		/// ָ���������Զ���ģ�塣 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// ָ���������Զ���ģ�塣 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// ָ���������Զ���ģ�塣 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>
		/// ָ���������Զ���ģ�塣 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��ĸ߶ȡ� 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣ�ؼ�ʱ���ֵ���ʾ�ı��� 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣʱ�ؼ��Ƿ������״̬�� 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����û���ͣʱ�ؼ��Ƿ������״̬��
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ݸ�����HTMLԪ�ص����ԡ� 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(string attributeName, object value)
		{
			base.Options["inputAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ݸ�����HTMLԪ�ص����ԡ� 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ݸ�����HTMLԪ�ص����ԡ� 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ���ݸ�����HTMLԪ�ص����ԡ� 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ָʾ�༭����ֵ�Ƿ���Ч�� 
		/// Specifies or indicates whether the editor's value is valid.
		/// </summary>
		[Generated]
		public AutocompleteBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ָʾ�༭����ֵ�Ƿ���Ч�� 
		/// Specifies or indicates whether the editor's value is valid.
		/// </summary>
		[Generated]
		public AutocompleteBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ���ʾ����Ŀ���顣 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ���ʾ����Ŀ���顣 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Items(Action<CollectionFactory<AutocompleteItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// Ϊ��Ŀָ���Զ���ģ�塣 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ���ʾ������������� 
		/// Specifies the maximum count of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxItemCount(int value)
		{
			base.Options["maxItemCount"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ���ʾ������������� 
		/// Specifies the maximum count of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxItemCount(JS value)
		{
			base.Options["maxItemCount"] = value;
			return this;
		}

		/// <summary>
		/// ָ���������ı��������������ַ����� 
		/// Specifies the maximum number of characters you can enter into the textbox.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxLength(int value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>
		/// ָ���������ı��������������ַ����� 
		/// Specifies the maximum number of characters you can enter into the textbox.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>
		/// ��ʼ����ʱ�������ı������������С�ַ����� 
		/// The minimum number of characters that must be entered into the text box to begin a search.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>
		/// ��ʼ����ʱ�������ı������������С�ַ����� 
		/// The minimum number of characters that must be entered into the text box to begin a search.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>
		/// Ҫ���������HTMLԪ�ص�"name"���Ե�ֵ�� 
		/// The value to be assigned to the `name` attribute of the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>
		/// Ҫ���������HTMLԪ�ص�"name"���Ե�ֵ�� 
		/// The value to be assigned to the `name` attribute of the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>
		/// ʹ�ü��̸����ı��ֶ����ݺ󣬵�С����ʧȥ����ʱִ�еĺ����� 
		/// A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>
		/// ʹ�ü��̸����ı��ֶ����ݺ󣬵�С����ʧȥ����ʱִ�еĺ�����
		/// A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ر������༭����ִ�еĺ����� 
		/// A function that is executed once the drop-down editor is closed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>
		/// �ر������༭����ִ�еĺ����� 
		/// A function that is executed once the drop-down editor is closed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ�������׼���ò�ÿ�θ�������ʱִ�еĺ����� 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ�������׼���ò�ÿ�θ�������ʱִ�еĺ����� 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ������뱻����ʱִ�еĺ����� 
		/// A function that is executed when the widget's input has been copied.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>
		/// ��С���������뱻����ʱִ�еĺ����� 
		/// A function that is executed when the widget's input has been copied.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ������뱻����ʱִ�еĺ����� 
		/// A function that is executed when the widget's input has been cut.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ������뱻����ʱִ�еĺ����� 
		/// A function that is executed when the widget's input has been cut.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ����� 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڴ���ؼ�֮ǰִ�еĺ����� 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ��۽�ʱ���»س���ʱִ�е�һ�ֹ��ܡ� 
		/// A function that is executed when the Enter key has been pressed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ��۽�ʱ���»س���ʱִ�е�һ�ֹ��ܡ� 
		/// A function that is executed when the Enter key has been pressed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ���ý���ʱִ�еĺ����� 
		/// A function that is executed when the widget gets focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ���ý���ʱִ�еĺ����� 
		/// A function that is executed when the widget gets focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���ؼ�ʧȥ����ʱִ�еĺ����� 
		/// A function that is executed when the widget loses focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>
		/// ���ؼ�ʧȥ����ʱִ�еĺ����� 
		/// A function that is executed when the widget loses focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ����� 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript��������ڱ���ؼ�ʵ���ĺ����� 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڿؼ��۽�ʱ��ÿ�θ���С����������ʱִ�еĺ����� 
		/// A function that is executed each time the widget's input is changed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڿؼ��۽�ʱ��ÿ�θ���С����������ʱִ�еĺ����� 
		/// A function that is executed each time the widget's input is changed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���������б���ʱִ�еĺ����� 
		/// A function that is executed when a list item is clicked or tapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// ���������б���ʱִ�еĺ����� 
		/// A function that is executed when a list item is clicked or tapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���û��������ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user is pressing a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>
		/// ���û��������ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user is pressing a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���û��������ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user presses a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>
		/// ���û��������ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user presses a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���û��ͷż����ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user releases a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>
		/// ���û��ͷż����ϵļ�ʱִ�еĺ����� 
		/// A function that is executed when a user releases a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �������༭����ִ�еĺ����� 
		/// A function that is executed once the drop-down editor is opened.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>
		/// �������༭����ִ�еĺ����� 
		/// A function that is executed once the drop-down editor is opened.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ����� 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// �ڿؼ�ѡ����ĺ�ִ�еĺ����� 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ճ���ؼ�����ʱִ�еĺ����� 
		/// A function that is executed when the widget's input has been pasted.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>
		/// ճ���ؼ�����ʱִ�еĺ�����
		/// A function that is executed when the widget's input has been pasted.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ѡ���б����ȡ��ѡ��ʱִ�еĺ����� 
		/// A function that is executed when a list item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// ѡ���б����ȡ��ѡ��ʱִ�еĺ����� 
		/// A function that is executed when a list item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ���Ŀؼ�ֵ��ִ�еĺ����� 
		/// A function that is executed after the widget's value is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// ���Ŀؼ�ֵ��ִ�еĺ�����
		/// A function that is executed after the widget's value is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ָ���Ƿ���ʾ�����༭���� 
		/// Specifies whether or not the drop-down editor is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ���ʾ�����༭���� 
		/// Specifies whether or not the drop-down editor is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>
		/// ָ���û��Ƿ����ͨ�������ı��ֶδ������б� 
		/// Specifies whether a user can open the drop-down list by clicking a text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>
		/// ָ���û��Ƿ����ͨ�������ı��ֶδ������б� 
		/// Specifies whether a user can open the drop-down list by clicking a text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ�ֵΪ��ʱ�ؼ���ʾ���ı��� 
		/// The text displayed by the widget when the widget value is empty.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>
		/// �ؼ�ֵΪ��ʱ�ؼ���ʾ���ı��� 
		/// The text displayed by the widget when the widget value is empty.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>
		/// ָ���༭���Ƿ�Ϊֻ���� 
		/// Specifies whether the editor is read-only.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>
		/// ָ���༭���Ƿ�Ϊֻ���� 
		/// Specifies whether the editor is read-only.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ�� 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ���ؼ��л�Ϊ���ҵ���ı�ʾ��
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ������Դ���ֶλ���ֵ������������Ƚϵı��ʽ�����ơ� 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>
		/// ָ������Դ���ֶλ���ֵ������������Ƚϵı��ʽ�����ơ� 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ������Դ���ֶλ���ֵ������������Ƚϵı��ʽ�����ơ� 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����������ؼ���ıȽϲ����� 
		/// Specifies a comparison operation used to search widget items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchMode(DropDownSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ִ������֮ǰ���������һ���ַ����ʱ���ӳ٣����룩�� 
		/// Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ִ������֮ǰ���������һ���ַ����ʱ���ӳ٣����룩�� 
		/// Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڿؼ�����ʾ�����ť�� 
		/// Specifies whether to display the Clear button in the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ��ڿؼ�����ʾ�����ť�� 
		/// Specifies whether to display the Clear button in the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>
		/// ָ��������ť�Ƿ�ɼ��� 
		/// Specifies whether the drop-down button is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>
		/// ָ��������ť�Ƿ�ɼ��� 
		/// Specifies whether the drop-down button is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ����ڲ��ı���ƴд���� 
		/// Specifies whether or not the widget checks the inner text for spelling mistakes.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Spellcheck(bool value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ����ڲ��ı���ƴд���� 
		/// Specifies whether or not the widget checks the inner text for spelling mistakes.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Spellcheck(JS value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ����ı��ֶε���ʽ�� 
		/// Specifies how the widget's text field is styled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����ڵ������Ʊ��ʱԪ�صı�š� 
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AutocompleteBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����ڵ������Ʊ��ʱԪ�صı�š� 
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AutocompleteBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// �й����ƻ�����֤�������Ϣ������validationErrors�����еĵ�һ��� 
		/// Information on the broken validation rule. Contains the first item from the validationErrors array.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>
		/// ʧ�ܵ���֤�������顣 
		/// An array of the validation rules that failed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>
		/// ʧ�ܵ���֤�������顣 
		/// An array of the validation rules that failed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>
		/// ָ�������ʾ�йش˱༭��ֵ���������֤�������Ϣ�� 
		/// Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>
		/// ָʾ��ָ����ǰ��֤״̬�� 
		/// Indicates or specifies the current validation status.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ���ʾ�ĵ�ǰֵ�� 
		/// Specifies the current value displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ���ʾ�ĵ�ǰֵ�� 
		/// Specifies the current value displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����¿ؼ�ֵ֮���DOM�¼��� 
		/// Specifies the DOM events after which the widget's value should be updated.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����¿�ֵ֮���DOM�¼��� 
		/// Specifies the DOM events after which the widget's value should be updated.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ĸ������ֶ�Ϊ�ؼ���ֵ�ṩΨһֵ�� 
		/// Specifies which data field provides unique values to the widget's value.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ĸ������ֶ�Ϊ�ؼ���ֵ�ṩΨһֵ��
		/// Specifies which data field provides unique values to the widget's value.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ�ɼ��� 
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ƿ�ɼ��� 
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ� 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ�
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���ؼ��Ŀ�ȡ�
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ��װ���������б��ȵ��ı��� 
		/// Specifies whether text that exceeds the drop-down list width should be wrapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ��װ���������б��ȵ��ı��� 
		/// Specifies whether text that exceeds the drop-down list width should be wrapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
