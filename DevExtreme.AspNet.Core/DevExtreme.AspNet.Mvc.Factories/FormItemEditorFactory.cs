using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 表单项目工厂
	/// </summary>
	public class FormItemEditorFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="html"></param>
		[Generated]
		public FormItemEditorFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
			//
		}

		/// <summary>
		/// Autocomplete控件是一个文本框，当用户键入时，它提供建议。
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// 日历是一个显示日历的控件，允许最终用户在指定的日期范围内选择所需的日期。 
		/// The Calendar is a widget that displays a calendar and allows an end user to select the required date within a specified date range.
		/// </summary>
		[Generated]
		public CalendarBuilder Calendar()
		{
			return new CalendarBuilder(new OptionsOwnerContext("dxCalendar", base.Owner, base.Html));
		}

		/// <summary>
		/// 复选框是一个小框，当最终用户选择时，它显示已启用特定功能或已选择特定选项。
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBox()
		{
			return new CheckBoxBuilder(new OptionsOwnerContext("dxCheckBox", base.Owner, base.Html));
		}

		/// <summary>
		///  ColorBox控件，允许最终用户输入颜色或从下拉编辑器中选择颜色。 
		/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
		/// </summary>
		[Generated]
		public ColorBoxBuilder ColorBox()
		{
			return new ColorBoxBuilder(new OptionsOwnerContext("dxColorBox", base.Owner, base.Html));
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
		/// 下拉框控件由显示当前值的文本字段和可以包含任何UI元素的下拉字段组成。 
		/// The DropDownBox widget consists of a text field, which displays the current value, and a drop-down field, which can contain any UI element.
		/// </summary>
		[Generated]
		public DropDownBoxBuilder DropDownBox()
		{
			return new DropDownBoxBuilder(new OptionsOwnerContext("dxDropDownBox", base.Owner, base.Html));
		}

		/// <summary>
		/// HtmlEditor是一个WYSIWYG编辑器，允许您格式化文本和可视内容，并以HTML或标记的形式输出。HtmlEditor构建在上面，需要使用Quill。
		/// [tags] ctp HtmlEditor is a WYSIWYG editor that allows you to format textual and visual content and to output it in HTML or Markdown. 
		/// HtmlEditor is built on top of and requires Quill. 
		/// #include common-ctp-note with { component: "HtmlEditor" }
		/// </summary>
		[Generated]
		public HtmlEditorBuilder HtmlEditor()
		{
			return new HtmlEditorBuilder(new OptionsOwnerContext("dxHtmlEditor", base.Owner, base.Html));
		}

		/// <summary>
		/// 查找控件，允许最终用户在下拉菜单中显示的集合中搜索项目。 
		/// The Lookup is a widget that allows an end user to search for an item in a collection shown in a drop-down menu.
		/// </summary>
		[Generated]
		public LookupBuilder Lookup()
		{
			return new LookupBuilder(new OptionsOwnerContext("dxLookup", base.Owner, base.Html));
		}

		/// <summary>
		/// NumberBox控件，它显示一个数值，并允许用户通过键入一个数值，然后使用键盘或鼠标对其进行递增或递减来修改它。 
		/// The NumberBox is a widget that displays a numeric value and allows a user to modify it by typing in a value, and incrementing or decrementing it using the keyboard or mouse.
		/// </summary>
		[Generated]
		public NumberBoxBuilder NumberBox()
		{
			return new NumberBoxBuilder(new OptionsOwnerContext("dxNumberBox", base.Owner, base.Html));
		}

		/// <summary>
		/// RadioGroup控件，它包含一组单选按钮，允许最终用户从中进行单个选择。 
		/// The RadioGroup is a widget that contains a set of radio buttons and allows an end user to make a single selection from the set.
		/// </summary>
		[Generated]
		public RadioGroupBuilder RadioGroup()
		{
			return new RadioGroupBuilder(new OptionsOwnerContext("dxRadioGroup", base.Owner, base.Html));
		}

		/// <summary>
		///  RangeSlider控件，允许最终用户选择一个数值范围。 
		/// The RangeSlider is a widget that allows an end user to choose a range of numeric values.
		/// </summary>
		[Generated]
		public RangeSliderBuilder RangeSlider()
		{
			return new RangeSliderBuilder(new OptionsOwnerContext("dxRangeSlider", base.Owner, base.Html));
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
		/// 滑块控件，允许最终用户在可能值的连续范围内设置数值。 
		/// The Slider is a widget that allows an end user to set a numeric value on a continuous range of possible values.
		/// </summary>
		[Generated]
		public SliderBuilder Slider()
		{
			return new SliderBuilder(new OptionsOwnerContext("dxSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// 开关控件，可以有两种状态："开"和"关"。 
		/// The Switch is a widget that can be in two states: "On" and "Off".
		/// </summary>
		[Generated]
		public SwitchBuilder Switch()
		{
			return new SwitchBuilder(new OptionsOwnerContext("dxSwitch", base.Owner, base.Html));
		}

		/// <summary>
		/// TagBox控件是一个编辑器，允许最终用户从下拉列表中选择多个项目。 
		/// The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.
		/// </summary>
		[Generated]
		public TagBoxBuilder TagBox()
		{
			return new TagBoxBuilder(new OptionsOwnerContext("dxTagBox", base.Owner, base.Html));
		}

		/// <summary>
		/// 文本区域控件，使用户可以输入和编辑多行文本。 
		/// The TextArea is a widget that enables a user to enter and edit a multi-line text.
		/// </summary>
		[Generated]
		public TextAreaBuilder TextArea()
		{
			return new TextAreaBuilder(new OptionsOwnerContext("dxTextArea", base.Owner, base.Html));
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
	}
}
