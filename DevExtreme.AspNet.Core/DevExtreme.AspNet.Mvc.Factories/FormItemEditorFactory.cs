using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ����Ŀ����
	/// </summary>
	public class FormItemEditorFactory : AbstractWidgetFactory
	{
		/// <summary>
		/// ��ʼ��
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
		/// Autocomplete�ؼ���һ���ı��򣬵��û�����ʱ�����ṩ���顣
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// ������һ����ʾ�����Ŀؼ������������û���ָ�������ڷ�Χ��ѡ����������ڡ� 
		/// The Calendar is a widget that displays a calendar and allows an end user to select the required date within a specified date range.
		/// </summary>
		[Generated]
		public CalendarBuilder Calendar()
		{
			return new CalendarBuilder(new OptionsOwnerContext("dxCalendar", base.Owner, base.Html));
		}

		/// <summary>
		/// ��ѡ����һ��С�򣬵������û�ѡ��ʱ������ʾ�������ض����ܻ���ѡ���ض�ѡ�
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBox()
		{
			return new CheckBoxBuilder(new OptionsOwnerContext("dxCheckBox", base.Owner, base.Html));
		}

		/// <summary>
		///  ColorBox�ؼ������������û�������ɫ��������༭����ѡ����ɫ�� 
		/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
		/// </summary>
		[Generated]
		public ColorBoxBuilder ColorBox()
		{
			return new ColorBoxBuilder(new OptionsOwnerContext("dxColorBox", base.Owner, base.Html));
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
		/// ������ؼ�����ʾ��ǰֵ���ı��ֶκͿ��԰����κ�UIԪ�ص������ֶ���ɡ� 
		/// The DropDownBox widget consists of a text field, which displays the current value, and a drop-down field, which can contain any UI element.
		/// </summary>
		[Generated]
		public DropDownBoxBuilder DropDownBox()
		{
			return new DropDownBoxBuilder(new OptionsOwnerContext("dxDropDownBox", base.Owner, base.Html));
		}

		/// <summary>
		/// HtmlEditor��һ��WYSIWYG�༭������������ʽ���ı��Ϳ������ݣ�����HTML���ǵ���ʽ�����HtmlEditor���������棬��Ҫʹ��Quill��
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
		/// ���ҿؼ������������û��������˵�����ʾ�ļ�����������Ŀ�� 
		/// The Lookup is a widget that allows an end user to search for an item in a collection shown in a drop-down menu.
		/// </summary>
		[Generated]
		public LookupBuilder Lookup()
		{
			return new LookupBuilder(new OptionsOwnerContext("dxLookup", base.Owner, base.Html));
		}

		/// <summary>
		/// NumberBox�ؼ�������ʾһ����ֵ���������û�ͨ������һ����ֵ��Ȼ��ʹ�ü��̻���������е�����ݼ����޸����� 
		/// The NumberBox is a widget that displays a numeric value and allows a user to modify it by typing in a value, and incrementing or decrementing it using the keyboard or mouse.
		/// </summary>
		[Generated]
		public NumberBoxBuilder NumberBox()
		{
			return new NumberBoxBuilder(new OptionsOwnerContext("dxNumberBox", base.Owner, base.Html));
		}

		/// <summary>
		/// RadioGroup�ؼ���������һ�鵥ѡ��ť�����������û����н��е���ѡ�� 
		/// The RadioGroup is a widget that contains a set of radio buttons and allows an end user to make a single selection from the set.
		/// </summary>
		[Generated]
		public RadioGroupBuilder RadioGroup()
		{
			return new RadioGroupBuilder(new OptionsOwnerContext("dxRadioGroup", base.Owner, base.Html));
		}

		/// <summary>
		///  RangeSlider�ؼ������������û�ѡ��һ����ֵ��Χ�� 
		/// The RangeSlider is a widget that allows an end user to choose a range of numeric values.
		/// </summary>
		[Generated]
		public RangeSliderBuilder RangeSlider()
		{
			return new RangeSliderBuilder(new OptionsOwnerContext("dxRangeSlider", base.Owner, base.Html));
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
		/// ����ؼ������������û��ڿ���ֵ��������Χ��������ֵ�� 
		/// The Slider is a widget that allows an end user to set a numeric value on a continuous range of possible values.
		/// </summary>
		[Generated]
		public SliderBuilder Slider()
		{
			return new SliderBuilder(new OptionsOwnerContext("dxSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// ���ؿؼ�������������״̬��"��"��"��"�� 
		/// The Switch is a widget that can be in two states: "On" and "Off".
		/// </summary>
		[Generated]
		public SwitchBuilder Switch()
		{
			return new SwitchBuilder(new OptionsOwnerContext("dxSwitch", base.Owner, base.Html));
		}

		/// <summary>
		/// TagBox�ؼ���һ���༭�������������û��������б���ѡ������Ŀ�� 
		/// The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.
		/// </summary>
		[Generated]
		public TagBoxBuilder TagBox()
		{
			return new TagBoxBuilder(new OptionsOwnerContext("dxTagBox", base.Owner, base.Html));
		}

		/// <summary>
		/// �ı�����ؼ���ʹ�û���������ͱ༭�����ı��� 
		/// The TextArea is a widget that enables a user to enter and edit a multi-line text.
		/// </summary>
		[Generated]
		public TextAreaBuilder TextArea()
		{
			return new TextAreaBuilder(new OptionsOwnerContext("dxTextArea", base.Owner, base.Html));
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
	}
}
