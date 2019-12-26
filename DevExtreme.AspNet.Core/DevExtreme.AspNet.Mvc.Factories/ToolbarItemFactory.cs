using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ��������Ŀ����
	/// </summary>
	public class ToolbarItemFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="owner">ӵ���ߣ�˭ӵ�пؼ�������δ�á�</param>
		/// <param name="html">Html���������ؼ����ĸ�ҳ�洴����</param>
		[Generated]
		public ToolbarItemFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
		}

		/// <summary>
		/// AutocompleteС������һ���ı��򣬵��û�����ʱ�����ṩ���顣
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// Button�ؼ���һ���򵥵İ�ť�����û�������ʱ����ִ��ָ������� 
		/// The Button widget is a simple button that performs specified commands when a user clicks it.
		/// </summary>
		[Generated]
		public ButtonBuilder Button()
		{
			return new ButtonBuilder(new OptionsOwnerContext("dxButton", base.Owner, base.Html));
		}

		/// <summary>
		/// ��ѡ��ؼ���һ��С�򣬵������û�ѡ��ʱ������ʾ�������ض����ܻ���ѡ���ض�ѡ� 
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBox()
		{
			return new CheckBoxBuilder(new OptionsOwnerContext("dxCheckBox", base.Owner, base.Html));
		}

		/// <summary>
		/// DateBox�ؼ�������ָ���ĸ�ʽ��ʾ���ں�ʱ�䣬�������û�ѡ���������������/ʱ��ֵ��
		/// The DateBox is a widget that displays date and time in a specified format, and enables a user to pick or type in the required date/time value.
		/// </summary>
		[Generated]
		public DateBoxBuilder DateBox()
		{
			return new DateBoxBuilder(new OptionsOwnerContext("dxDateBox", base.Owner, base.Html));
		}

		/// <summary>
		/// �˵�С������һ�����пɵ��������塣
		/// ����ĳ����Ŀ����һ�������˵������п��԰�������Ӳ˵���
		/// The Menu widget is a panel with clickable items. 
		/// A click on an item opens a drop-down menu, which can contain several submenus.
		/// </summary>
		[Generated]
		public MenuBuilder Menu()
		{
			return new MenuBuilder(new OptionsOwnerContext("dxMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// SelectBox�ؼ���һ���༭�������������û��������б���ѡ����Ŀ��
		/// The SelectBox widget is an editor that allows an end user to select an item from a drop-down list.
		/// </summary>
		[Generated]
		public SelectBoxBuilder SelectBox()
		{
			return new SelectBoxBuilder(new OptionsOwnerContext("dxSelectBox", base.Owner, base.Html));
		}

		/// <summary>
		/// ѡ���������ҳ�����ͼ֮���л���ѡ�����
		/// ����ؼ�������TabPanel�ؼ��У�������Ҳ���Ե���ʹ����Щѡ���
		/// The Tabs is a tab strip used to switch between pages or views. 
		/// This widget is included in the TabPanel widget, but you can use the Tabs separately as well.
		/// </summary>
		[Generated]
		public TabsBuilder Tabs()
		{
			return new TabsBuilder(new OptionsOwnerContext("dxTabs", base.Owner, base.Html));
		}

		/// <summary>
		/// �ı���ؼ��������û�����ͱ༭һ���ı���
		/// The TextBox is a widget that enables a user to enter and edit a single line of text.
		/// </summary>
		[Generated]
		public TextBoxBuilder TextBox()
		{
			return new TextBoxBuilder(new OptionsOwnerContext("dxTextBox", base.Owner, base.Html));
		}

		/// <summary>
		/// ButtongGroup�ؼ���������һ���л���ť����������ģʽ�л�����
		/// The ButtonGroup is a widget that contains a set of toggle buttons and can be used as a mode switcher.
		/// </summary>
		[Generated]
		public ButtonGroupBuilder ButtonGroup()
		{
			return new ButtonGroupBuilder(new OptionsOwnerContext("dxButtonGroup", base.Owner, base.Html));
		}

		/// <summary>
		/// ������ť�Ǵ������˵��İ�ť�� 
		/// The DropDownButton is a button that opens a drop-down menu.
		/// </summary>
		[Generated]
		public DropDownButtonBuilder DropDownButton()
		{
			return new DropDownButtonBuilder(new OptionsOwnerContext("dxDropDownButton", base.Owner, base.Html));
		}
	}
}
