using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 工具栏项目工厂
	/// </summary>
	public class ToolbarItemFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="owner">拥有者，谁拥有控件。保留未用。</param>
		/// <param name="html">Html适配器，控件在哪个页面创建。</param>
		[Generated]
		public ToolbarItemFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
		}

		/// <summary>
		/// Autocomplete小部件是一个文本框，当用户键入时，它提供建议。
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// Button控件是一个简单的按钮，当用户单击它时，它执行指定的命令。 
		/// The Button widget is a simple button that performs specified commands when a user clicks it.
		/// </summary>
		[Generated]
		public ButtonBuilder Button()
		{
			return new ButtonBuilder(new OptionsOwnerContext("dxButton", base.Owner, base.Html));
		}

		/// <summary>
		/// 复选框控件是一个小框，当最终用户选择时，它显示已启用特定功能或已选择特定选项。 
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBox()
		{
			return new CheckBoxBuilder(new OptionsOwnerContext("dxCheckBox", base.Owner, base.Html));
		}

		/// <summary>
		/// DateBox控件，它以指定的格式显示日期和时间，并允许用户选择或键入所需的日期/时间值。
		/// The DateBox is a widget that displays date and time in a specified format, and enables a user to pick or type in the required date/time value.
		/// </summary>
		[Generated]
		public DateBoxBuilder DateBox()
		{
			return new DateBoxBuilder(new OptionsOwnerContext("dxDateBox", base.Owner, base.Html));
		}

		/// <summary>
		/// 菜单小部件是一个带有可单击项的面板。
		/// 单击某个项目将打开一个下拉菜单，其中可以包含多个子菜单。
		/// The Menu widget is a panel with clickable items. 
		/// A click on an item opens a drop-down menu, which can contain several submenus.
		/// </summary>
		[Generated]
		public MenuBuilder Menu()
		{
			return new MenuBuilder(new OptionsOwnerContext("dxMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// SelectBox控件是一个编辑器，允许最终用户从下拉列表中选择项目。
		/// The SelectBox widget is an editor that allows an end user to select an item from a drop-down list.
		/// </summary>
		[Generated]
		public SelectBoxBuilder SelectBox()
		{
			return new SelectBoxBuilder(new OptionsOwnerContext("dxSelectBox", base.Owner, base.Html));
		}

		/// <summary>
		/// 选项卡是用于在页面或视图之间切换的选项卡栏。
		/// 这个控件包含在TabPanel控件中，但是您也可以单独使用这些选项卡。
		/// The Tabs is a tab strip used to switch between pages or views. 
		/// This widget is included in the TabPanel widget, but you can use the Tabs separately as well.
		/// </summary>
		[Generated]
		public TabsBuilder Tabs()
		{
			return new TabsBuilder(new OptionsOwnerContext("dxTabs", base.Owner, base.Html));
		}

		/// <summary>
		/// 文本框控件，允许用户输入和编辑一行文本。
		/// The TextBox is a widget that enables a user to enter and edit a single line of text.
		/// </summary>
		[Generated]
		public TextBoxBuilder TextBox()
		{
			return new TextBoxBuilder(new OptionsOwnerContext("dxTextBox", base.Owner, base.Html));
		}

		/// <summary>
		/// ButtongGroup控件，它包含一组切换按钮，可以用作模式切换程序。
		/// The ButtonGroup is a widget that contains a set of toggle buttons and can be used as a mode switcher.
		/// </summary>
		[Generated]
		public ButtonGroupBuilder ButtonGroup()
		{
			return new ButtonGroupBuilder(new OptionsOwnerContext("dxButtonGroup", base.Owner, base.Html));
		}

		/// <summary>
		/// 下拉按钮是打开下拉菜单的按钮。 
		/// The DropDownButton is a button that opens a drop-down menu.
		/// </summary>
		[Generated]
		public DropDownButtonBuilder DropDownButton()
		{
			return new DropDownButtonBuilder(new OptionsOwnerContext("dxDropDownButton", base.Owner, base.Html));
		}
	}
}
