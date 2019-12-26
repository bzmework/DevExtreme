using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// WidgetFactory�ؼ���������������˸��ֿؼ���
	/// ע��ؼ������ǷǾ�̬�࣬˵��ÿ���ؼ���ȡ�ö�����ͨ��ʵ����ȡ�����磺
	/// ButtonBuilder button= new WidgetFactory<object>(null, new HtmlHelperAdapter(html)).Button();
	/// </summary>
	/// <typeparam name="TModel"></typeparam>
	public class WidgetFactory<TModel> : AbstractWidgetFactory
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="owner">ӵ���ߣ�˭ӵ�пؼ�������δ�á�</param>
		/// <param name="html">Html���������ؼ����ĸ�ҳ�洴����</param>
		public WidgetFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
			//
		}

		/// <summary>
		/// Accordion�ؼ�����������ʾ����һ������µ���塣
		/// ��Щ�������������û��۵���չ������ʹ������ؼ����������޵Ŀռ�����ʾ��Ϣ�ǳ����á�
		/// The Accordion widget contains several panels displayed one under another. 
		/// These panels can be collapsed or expanded by an end user, which makes this widget very useful for presenting information in a limited amount of space.
		/// </summary>
		[Generated]
		public AccordionBuilder Accordion()
		{
			return new AccordionBuilder(new OptionsOwnerContext("dxAccordion", base.Owner, base.Html));
		}

		/// <summary>
		/// ��Щ��ťͨ����ʾ�뵥��������صĶ��ѡ�
		/// The ActionSheet widget is a sheet containing a set of buttons located one under the other. 
		/// These buttons usually represent several choices relating to a single task.
		/// ActionSheet�ؼ���һ������һ��λ����һ����ť�µİ�ť�Ĺ�����
		/// </summary>
		[Generated]
		public ActionSheetBuilder ActionSheet()
		{
			return new ActionSheetBuilder(new OptionsOwnerContext("dxActionSheet", base.Owner, base.Html));
		}

		/// <summary>
		/// Autocomplete�ؼ���һ���ı��򣬵��û�����ʱ�����Զ������ı��ṩ���顣
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// Autocomplete�ؼ���һ���ı��򣬵��û�����ʱ�����Զ������ı��ṩ���顣
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder AutocompleteFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			AutocompleteBuilder autocompleteBuilder = Autocomplete();
			autocompleteBuilder.PrepareEditorFor(base.Html, expression);
			return autocompleteBuilder;
		}

		/// <summary>
		/// Box�ؼ����������������и���Ԫ�ء�
		/// ����������Ӧ��Box�ؼ��䵱���ֵĹ����顣
		/// The Box widget allows you to arrange various elements within it. 
		/// Separate and adaptive, the Box widget acts as a building block for the layout.
		/// </summary>
		[Generated]
		public BoxBuilder Box()
		{
			return new BoxBuilder(new OptionsOwnerContext("dxBox", base.Owner, base.Html));
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
		/// ButtongGroup�ؼ���������һ���л���ť����������ģʽ�л�����
		/// The ButtonGroup is a widget that contains a set of toggle buttons and can be used as a mode switcher.
		/// </summary>
		[Generated]
		public ButtonGroupBuilder ButtonGroup()
		{
			return new ButtonGroupBuilder(new OptionsOwnerContext("dxButtonGroup", base.Owner, base.Html));
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
		/// ������һ����ʾ�����Ŀؼ������������û���ָ�������ڷ�Χ��ѡ����������ڡ�
		/// The Calendar is a widget that displays a calendar and allows an end user to select the required date within a specified date range.
		/// </summary>
		[Generated]
		public CalendarBuilder CalendarFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			CalendarBuilder calendarBuilder = Calendar();
			calendarBuilder.PrepareEditorFor(base.Html, expression);
			return calendarBuilder;
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
		/// ��ѡ����һ��С�򣬵������û�ѡ��ʱ������ʾ�������ض����ܻ���ѡ���ض�ѡ�
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			CheckBoxBuilder checkBoxBuilder = CheckBox();
			checkBoxBuilder.PrepareEditorFor(base.Html, expression);
			return checkBoxBuilder;
		}

		/// <summary>
		/// ColorBox�ؼ������������û�������ɫ��������༭����ѡ����ɫ�� 
		/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
		/// </summary>
		[Generated]
		public ColorBoxBuilder ColorBox()
		{
			return new ColorBoxBuilder(new OptionsOwnerContext("dxColorBox", base.Owner, base.Html));
		}

		/// <summary>
		/// ColorBox�ؼ������������û�������ɫ��������༭����ѡ����ɫ�� 
		/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
		/// </summary>
		[Generated]
		public ColorBoxBuilder ColorBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			ColorBoxBuilder colorBoxBuilder = ColorBox();
			colorBoxBuilder.PrepareEditorFor(base.Html, expression);
			return colorBoxBuilder;
		}

		/// <summary>
		/// ContextMenu�ؼ���ʾһ����������������Ĳ˵���
		/// �����û�ͨ���Ҽ������򳤰������ô˲˵���
		/// The ContextMenu widget displays a single- or multi-level context menu. 
		/// An end user invokes this menu by a right click or a long press.
		/// </summary>
		[Generated]
		public ContextMenuBuilder ContextMenu()
		{
			return new ContextMenuBuilder(new OptionsOwnerContext("dxContextMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// DataGrid�ؼ��������������ʽ��ʾ���Ա��ػ�Զ��Դ�����ݡ�
		/// ����ؼ��ṩ���������򡢷��顢ɸѡ�Ȼ������ܣ��Լ����߼��Ĺ��ܣ���״̬�洢��������Excel����ϸ�ڽ��������������ܡ�
		/// The DataGrid is a widget that represents data from a local or remote source in the form of a grid. 
		/// This widget offers such basic features as sorting, grouping, filtering, as well as more advanced capabilities, like state storing, export to Excel, master-detail interface, and many others.
		/// </summary>
		[Generated]
		public DataGridBuilder<object> DataGrid()
		{
			return new DataGridBuilder<object>(new OptionsOwnerContext("dxDataGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// DataGrid�ؼ��������������ʽ��ʾ���Ա��ػ�Զ��Դ�����ݡ�
		/// ����ؼ��ṩ���������򡢷��顢ɸѡ�Ȼ������ܣ��Լ����߼��Ĺ��ܣ���״̬�洢��������Excel����ϸ�ڽ��������������ܡ�
		/// The DataGrid is a widget that represents data from a local or remote source in the form of a grid. 
		/// This widget offers such basic features as sorting, grouping, filtering, as well as more advanced capabilities, like state storing, export to Excel, master-detail interface, and many others.
		/// </summary>
		[Generated]
		public DataGridBuilder<T> DataGrid<T>()
		{
			return new DataGridBuilder<T>(new OptionsOwnerContext("dxDataGrid", base.Owner, base.Html));
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
		/// DateBox�ؼ�������ָ���ĸ�ʽ��ʾ���ں�ʱ�䣬�������û�ѡ���������������/ʱ��ֵ��
		/// The DateBox is a widget that displays date and time in a specified format, and enables a user to pick or type in the required date/time value.
		/// </summary>
		[Generated]
		public DateBoxBuilder DateBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			DateBoxBuilder dateBoxBuilder = DateBox();
			dateBoxBuilder.PrepareEditorFor(base.Html, expression);
			return dateBoxBuilder;
		}

		/// <summary>
		/// ͼ��ؼ��ṩ��һ�����ӻ����棬�԰���������µĺ��޸����е�ͼ��
		/// [tags] ctp The Diagram widget provides a visual interface to help you design new and modify existing diagrams. 
		/// #include common-ctp-note with { component: "Diagram" }
		/// </summary>
		[Generated]
		public DiagramBuilder Diagram()
		{
			return new DiagramBuilder(new OptionsOwnerContext("dxDiagram", base.Owner, base.Html));
		}

		/// <summary>
		/// Draggable��һ���û�����ʵ�ó��������Ϸſؼ���
		/// Draggable is a user interface utility that allows widget elements to be dragged and dropped.
		/// </summary>
		[Generated]
		public DraggableBuilder Draggable()
		{
			return new DraggableBuilder(new OptionsOwnerContext("dxDraggable", base.Owner, base.Html));
		}

		/// <summary>
		/// ������һ���ɺ��Ի����ÿɼ�����壬��������ӦʽwebӦ�ó��򲼾��е�����
		/// The Drawer is a dismissible or permanently visible panel used for navigation in responsive web application layouts.
		/// </summary>
		[Generated]
		public DrawerBuilder Drawer()
		{
			return new DrawerBuilder(new OptionsOwnerContext("dxDrawer", base.Owner, base.Html));
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
		/// ������ؼ�����ʾ��ǰֵ���ı��ֶκͿ��԰����κ�UIԪ�ص������ֶ���ɡ�
		/// The DropDownBox widget consists of a text field, which displays the current value, and a drop-down field, which can contain any UI element.
		/// </summary>
		[Generated]
		public DropDownBoxBuilder DropDownBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			DropDownBoxBuilder dropDownBoxBuilder = DropDownBox();
			dropDownBoxBuilder.PrepareEditorFor(base.Html, expression);
			return dropDownBoxBuilder;
		}

		/// <summary>
		/// ������ť�ؼ��Ǵ������˵��İ�ť��
		/// The DropDownButton is a button that opens a drop-down menu.
		/// </summary>
		[Generated]
		public DropDownButtonBuilder DropDownButton()
		{
			return new DropDownButtonBuilder(new OptionsOwnerContext("dxDropDownButton", base.Owner, base.Html));
		}

		/// <summary>
		/// �ļ��������ؼ��������û��ϴ���ѡ��͹���ͬ�ļ��洢�е��ļ���Ŀ¼��
		/// [tags] ctp The FileManager is a widget that allows users to upload, select, and manage files and directories in different file storages. 
		/// #include common-ctp-note with { component: "FileManager" }
		/// </summary>
		[Generated]
		public FileManagerBuilder FileManager()
		{
			return new FileManagerBuilder(new OptionsOwnerContext("dxFileManager", base.Owner, base.Html));
		}

		/// <summary>
		/// FileUploader�ؼ����������û����ļ����ص���������
		/// �����û��������ļ���Դ��������ѡ���ļ������ļ��Ϸŵ�ҳ���ϵ��ļ����س�������
		/// The FileUploader widget enables an end user to upload files to the server. 
		/// An end user can select files in the file explorer or drag and drop files to the FileUploader area on the page.
		/// </summary>
		[Generated]
		public FileUploaderBuilder FileUploader()
		{
			return new FileUploaderBuilder(new OptionsOwnerContext("dxFileUploader", base.Owner, base.Html));
		}

		/// <summary>
		/// FilterBuilder�ؼ������û�ͨ��ʹ��UI���߼��������ʹ�����������Ĺ����������������ӵĹ��˱��ʽ��
		/// The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions, combined by logical operations using the UI.
		/// </summary>
		[Generated]
		public FilterBuilderBuilder<object> FilterBuilder()
		{
			return new FilterBuilderBuilder<object>(new OptionsOwnerContext("dxFilterBuilder", base.Owner, base.Html));
		}

		/// <summary>
		/// FilterBuilder�ؼ������û�ͨ��ʹ��UI���߼��������ʹ�����������Ĺ����������������ӵĹ��˱��ʽ��
		/// The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions, combined by logical operations using the UI.
		/// </summary>
		[Generated]
		public FilterBuilderBuilder<T> FilterBuilder<T>()
		{
			return new FilterBuilderBuilder<T>(new OptionsOwnerContext("dxFilterBuilder", base.Owner, base.Html));
		}

		/// <summary>
		/// ���ؼ������ݶ�����ֶα�ʾΪ��ǩ�༭���Եļ��ϡ�
		/// ��Щ�Կ��԰�����顢ѡ��������С�
		/// The Form widget represents fields of a data object as a collection of label-editor pairs. 
		/// These pairs can be arranged in several groups, tabs and columns.
		/// </summary>
		[Generated]
		public FormBuilder<object> Form()
		{
			return new FormBuilder<object>(new OptionsOwnerContext("dxForm", base.Owner, base.Html));
		}

		/// <summary>
		/// ���ؼ������ݶ�����ֶα�ʾΪ��ǩ�༭���Եļ��ϡ�
		/// ��Щ�Կ��԰�����顢ѡ��������С�
		/// The Form widget represents fields of a data object as a collection of label-editor pairs. 
		/// These pairs can be arranged in several groups, tabs and columns.
		/// </summary>
		[Generated]
		public FormBuilder<T> Form<T>()
		{
			return new FormBuilder<T>(new OptionsOwnerContext("dxForm", base.Owner, base.Html));
		}

		/// <summary>
		/// Gallery�ؼ�����������תľ������ʾͼ�񼯺ϡ�
		/// �ؼ��ṩ�˸��ֵ����ؼ��������û���ͼ��֮���л���
		/// The Gallery is a widget that displays a collection of images in a carousel. 
		/// The widget is supplied with various navigation controls that allow a user to switch between images.
		/// </summary>
		[Generated]
		public GalleryBuilder Gallery()
		{
			return new GalleryBuilder(new OptionsOwnerContext("dxGallery", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ͼ�ؼ�����ʾ������������֮���������ϵ��
		/// [tags] ctp The Gantt is a widget that displays the task flow and dependencies between tasks. 
		/// #include common-ctp-note with { component: "Gantt" }
		/// </summary>
		[Generated]
		public GanttBuilder<object> Gantt()
		{
			return new GanttBuilder<object>(new OptionsOwnerContext("dxGantt", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ͼ�ؼ�����ʾ������������֮���������ϵ��
		/// [tags] ctp The Gantt is a widget that displays the task flow and dependencies between tasks. 
		/// #include common-ctp-note with { component: "Gantt" }
		/// </summary>
		[Generated]
		public GanttBuilder<T> Gantt<T>()
		{
			return new GanttBuilder<T>(new OptionsOwnerContext("dxGantt", base.Owner, base.Html));
		}

		/// <summary>
		/// HTML editor��һ��WYSIWYG�༭������������ʽ���ı��Ϳ������ݣ�����HTML���ǵ���ʽ�����HtmlEditor���������棬��Ҫʹ��Quill��
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
		/// HTML editor��һ��WYSIWYG�༭������������ʽ���ı��Ϳ������ݣ�����HTML���ǵ���ʽ�����
		/// [tags] ctp HtmlEditor is a WYSIWYG editor that allows you to format textual and visual content and to output it in HTML or Markdown. 
		/// HtmlEditor is built on top of and requires Quill. #include common-ctp-note with { component: "HtmlEditor" }
		/// </summary>
		[Generated]
		public HtmlEditorBuilder HtmlEditorFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			HtmlEditorBuilder htmlEditorBuilder = HtmlEditor();
			htmlEditorBuilder.PrepareEditorFor(base.Html, expression);
			return htmlEditorBuilder;
		}

		/// <summary>
		/// �б�ؼ�����ʾ�ɹ����б��е���Ŀ���ϡ�
		/// The List is a widget that represents a collection of items in a scrollable list.
		/// </summary>
		[Generated]
		public ListBuilder List()
		{
			return new ListBuilder(new OptionsOwnerContext("dxList", base.Owner, base.Html));
		}

		/// <summary>
		/// LoadIndicator��һ��UIԪ�أ�֪ͨ�鿴���������ڽ��С�
		/// The LoadIndicator is a UI element notifying the viewer that a process is in progress.
		/// </summary>
		[Generated]
		public LoadIndicatorBuilder LoadIndicator()
		{
			return new LoadIndicatorBuilder(new OptionsOwnerContext("dxLoadIndicator", base.Owner, base.Html));
		}

		/// <summary>
		/// LoadPanel��һ�����ǿؼ���֪ͨ�鿴�����ڼ��ء�
		/// The LoadPanel is an overlay widget notifying the viewer that loading is in progress.
		/// </summary>
		[Generated]
		public LoadPanelBuilder LoadPanel()
		{
			return new LoadPanelBuilder(new OptionsOwnerContext("dxLoadPanel", base.Owner, base.Html));
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
		/// ���ҿؼ������������û��������˵�����ʾ�ļ�����������Ŀ��
		/// The Lookup is a widget that allows an end user to search for an item in a collection shown in a drop-down menu.
		/// </summary>
		[Generated]
		public LookupBuilder LookupFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			LookupBuilder lookupBuilder = Lookup();
			lookupBuilder.PrepareEditorFor(base.Html, expression);
			return lookupBuilder;
		}

		/// <summary>
		/// ��ͼ��һ������ʽС����������ʾ���б�Ǻ�·�ߵĵ����ͼ��
		/// The Map is an interactive widget that displays a geographic map with markers and routes.
		/// </summary>
		[Generated]
		public MapBuilder Map()
		{
			return new MapBuilder(new OptionsOwnerContext("dxMap", base.Owner, base.Html));
		}

		/// <summary>
		/// �˵��ؼ���һ�����пɵ��������塣����ĳ����Ŀ����һ�������˵������п��԰�������Ӳ˵���
		/// The Menu widget is a panel with clickable items. 
		/// A click on an item opens a drop-down menu, which can contain several submenus.
		/// </summary>
		[Generated]
		public MenuBuilder Menu()
		{
			return new MenuBuilder(new OptionsOwnerContext("dxMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ͼ��һ�����������ͼ�Ŀؼ���
		/// �����û�ͨ����ˮƽ�����ϻ�����ͼ��������ͼ��
		/// The MultiView is a widget that contains several views. 
		/// An end user navigates through the views by swiping them in the horizontal direction.
		/// </summary>
		[Generated]
		public MultiViewBuilder MultiView()
		{
			return new MultiViewBuilder(new OptionsOwnerContext("dxMultiView", base.Owner, base.Html));
		}

		/// <summary>
		/// �������ǵ���Ӧ�ó�����ͼ�Ŀؼ���
		/// The NavBar is a widget that navigates the application views.
		/// </summary>
		[Generated]
		public NavBarBuilder NavBar()
		{
			return new NavBarBuilder(new OptionsOwnerContext("dxNavBar", base.Owner, base.Html));
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
		/// NumberBox�ؼ�������ʾһ����ֵ���������û�ͨ������һ����ֵ��Ȼ��ʹ�ü��̻���������е�����ݼ����޸�����
		/// The NumberBox is a widget that displays a numeric value and allows a user to modify it by typing in a value, and incrementing or decrementing it using the keyboard or mouse.
		/// </summary>
		[Generated]
		public NumberBoxBuilder NumberBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			NumberBoxBuilder numberBoxBuilder = NumberBox();
			numberBoxBuilder.PrepareEditorFor(base.Html, expression);
			return numberBoxBuilder;
		}

		/// <summary>
		/// PivotGrid�ؼ�����������ʾ�ͷ������Ա��ش洢��OLAP��ά���ݼ��Ķ�ά���ݡ�
		/// The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.
		/// </summary>
		[Generated]
		public PivotGridBuilder<object> PivotGrid()
		{
			return new PivotGridBuilder<object>(new OptionsOwnerContext("dxPivotGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// PivotGrid�ؼ�����������ʾ�ͷ������Ա��ش洢��OLAP��ά���ݼ��Ķ�ά���ݡ�
		/// The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.
		/// </summary>
		[Generated]
		public PivotGridBuilder<T> PivotGrid<T>()
		{
			return new PivotGridBuilder<T>(new OptionsOwnerContext("dxPivotGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// Popover�ؼ�������һ������ָ��ָ��UIԪ�صļ�ͷ�Ŀ�����ʾ֪ͨ��
		/// The Popover is a widget that shows notifications within a box with an arrow pointing to a specified UI element.
		/// </summary>
		[Generated]
		public PopoverBuilder Popover()
		{
			return new PopoverBuilder(new OptionsOwnerContext("dxPopover", base.Owner, base.Html));
		}

		/// <summary>
		/// The Popup widget is a pop-up window overlaying the current view.
		/// �������ڿؼ��Ǹ��ǵ�ǰ��ͼ�ĵ������ڡ�
		/// </summary>
		[Generated]
		public PopupBuilder Popup()
		{
			return new PopupBuilder(new OptionsOwnerContext("dxPopup", base.Owner, base.Html));
		}

		/// <summary>
		/// ProgressBar����ʾ��ǰ���ȵĿؼ���
		/// The ProgressBar is a widget that shows current progress.
		/// </summary>
		[Generated]
		public ProgressBarBuilder ProgressBar()
		{
			return new ProgressBarBuilder(new OptionsOwnerContext("dxProgressBar", base.Owner, base.Html));
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
		/// RadioGroup�ؼ���������һ�鵥ѡ��ť�����������û����н��е���ѡ��
		/// The RadioGroup is a widget that contains a set of radio buttons and allows an end user to make a single selection from the set.
		/// </summary>
		[Generated]
		public RadioGroupBuilder RadioGroupFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			RadioGroupBuilder radioGroupBuilder = RadioGroup();
			radioGroupBuilder.PrepareEditorFor(base.Html, expression);
			return radioGroupBuilder;
		}

		/// <summary>
		/// RangeSlider�ؼ������������û�ѡ��һ����ֵ��Χ��
		/// The RangeSlider is a widget that allows an end user to choose a range of numeric values.
		/// </summary>
		[Generated]
		public RangeSliderBuilder RangeSlider()
		{
			return new RangeSliderBuilder(new OptionsOwnerContext("dxRangeSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// �༭�ڵĻ��ࡣ
		/// A base class for editors.
		/// </summary>
		[Generated]
		public RecurrenceEditorBuilder RecurrenceEditor()
		{
			return new RecurrenceEditorBuilder(new OptionsOwnerContext("dxRecurrenceEditor", base.Owner, base.Html));
		}

		/// <summary>
		/// �༭�ڵĻ��ࡣ
		/// A base class for editors.
		/// </summary>
		[Generated]
		public RecurrenceEditorBuilder RecurrenceEditorFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			RecurrenceEditorBuilder recurrenceEditorBuilder = RecurrenceEditor();
			recurrenceEditorBuilder.PrepareEditorFor(base.Html, expression);
			return recurrenceEditorBuilder;
		}

		/// <summary>
		/// �ɵ�����С�ؼ�ʹ��������UI�пɵ�����С�� 
		/// The Resizable widget enables its content to be resizable in the UI.
		/// </summary>
		[Generated]
		public ResizableBuilder Resizable()
		{
			return new ResizableBuilder(new OptionsOwnerContext("dxResizable", base.Owner, base.Html));
		}

		/// <summary>
		/// ResponsiveBox�ؼ�����������һ��Ӧ�ó������վ���䲼���ʺϲ�ͬ����Ļ��С��
		/// The ResponsiveBox widget allows you to create an application or a website with a layout adapted to different screen sizes.
		/// </summary>
		[Generated]
		public ResponsiveBoxBuilder ResponsiveBox()
		{
			return new ResponsiveBoxBuilder(new OptionsOwnerContext("dxResponsiveBox", base.Owner, base.Html));
		}

		/// <summary>
		/// Sankey�ؼ��������Կ��ӻ�ֵ��֮�������С��
		/// ���ӵ�ֵ��Ϊ�ڵ㣻����-���ӡ�
		/// ������СԽ������Խ��
		/// The Sankey is a widget that visualizes the flow magnitude between value sets. 
		/// The values being connected are called nodes; the connections - links. 
		/// The higher the flow magnitude, the wider the link is.
		/// </summary>
		[Generated]
		public SankeyBuilder Sankey()
		{
			return new SankeyBuilder(new OptionsOwnerContext("dxSankey", base.Owner, base.Html));
		}

		/// <summary>
		/// ��������һ��С����������ʾ�ƻ������ݣ��������û�����ͱ༭����
		/// The Scheduler is a widget that represents scheduled data and allows a user to manage and edit it.
		/// </summary>
		[Generated]
		public SchedulerBuilder Scheduler()
		{
			return new SchedulerBuilder(new OptionsOwnerContext("dxScheduler", base.Owner, base.Html));
		}

		/// <summary>
		/// ScrollView�ؼ��������û����������ݡ�
		/// The ScrollView is a widget that enables a user to scroll its content.
		/// </summary>
		[Generated]
		public ScrollViewBuilder ScrollView()
		{
			return new ScrollViewBuilder(new OptionsOwnerContext("dxScrollView", base.Owner, base.Html));
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
		/// SelectBox�ؼ���һ���༭�������������û��������б���ѡ����Ŀ��
		/// The SelectBox widget is an editor that allows an end user to select an item from a drop-down list.
		/// </summary>
		[Generated]
		public SelectBoxBuilder SelectBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			SelectBoxBuilder selectBoxBuilder = SelectBox();
			selectBoxBuilder.PrepareEditorFor(base.Html, expression);
			return selectBoxBuilder;
		}

		/// <summary>
		/// SlideOutС������һ������ͼ��Եľ��们���˵���
		/// �����û�ͨ��������ͼ�򿪲˵���
		/// The SlideOut widget is a classic slide-out menu paired with a view. 
		/// An end user opens the menu by swiping away the view.
		/// </summary>
		[Generated]
		public SlideOutBuilder SlideOut()
		{
			return new SlideOutBuilder(new OptionsOwnerContext("dxSlideOut", base.Owner, base.Html));
		}

		/// <summary>
		/// SlideOutView�ؼ�������ͼ��Եľ��们���˵���
		/// ����ؼ���SlideOut�ǳ����ƣ�ֻ��һ����֮ͬ����SlideOut���ǰ���SlideOut�˵��е��б���SlideOut��ͼ���Ա����κμ��ϡ�
		/// The SlideOutView widget is a classic slide-out menu paired with a view. 
		/// This widget is very similar to the SlideOut with only one difference - the SlideOut always contains the List in the slide-out menu, while the SlideOutView can hold any collection there.
		/// </summary>
		[Generated]
		public SlideOutViewBuilder SlideOutView()
		{
			return new SlideOutViewBuilder(new OptionsOwnerContext("dxSlideOutView", base.Owner, base.Html));
		}

		/// <summary>
		/// ������һ���ؼ������������û��ڿ���ֵ��������Χ��������ֵ��
		/// The Slider is a widget that allows an end user to set a numeric value on a continuous range of possible values.
		/// </summary>
		[Generated]
		public SliderBuilder Slider()
		{
			return new SliderBuilder(new OptionsOwnerContext("dxSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ؼ������������û��ڿ���ֵ��������Χ��������ֵ��
		/// The Slider is a widget that allows an end user to set a numeric value on a continuous range of possible values.
		/// </summary>
		[Generated]
		public SliderBuilder SliderFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			SliderBuilder sliderBuilder = Slider();
			sliderBuilder.PrepareEditorFor(base.Html, expression);
			return sliderBuilder;
		}

		/// <summary>
		/// Sortable��һ���û�����ʵ�ó���������ͨ���Ϸ����ƶԿؼ�������������
		/// Sortable is a user interface utility that allows a widget's items to be reordered via drag and drop gestures.
		/// </summary>
		[Generated]
		public SortableBuilder Sortable()
		{
			return new SortableBuilder(new OptionsOwnerContext("dxSortable", base.Owner, base.Html));
		}

		/// <summary>
		/// SpeedDialAction��ִ���Զ�������İ�ť��
		/// ��������һ������������ť��FAB����һ�����ٲ��Ų˵��еİ�ť����ʾ��
		/// The SpeedDialAction is a button that performs a custom action. 
		/// It can be represented by a Floating Action Button (FAB) or a button in a speed dial menu opened with the FAB.
		/// </summary>
		[Generated]
		public SpeedDialActionBuilder SpeedDialAction()
		{
			return new SpeedDialActionBuilder(new OptionsOwnerContext("dxSpeedDialAction", base.Owner, base.Html));
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
		/// ���ؿؼ�������������״̬��"��"��"��"��
		/// The Switch is a widget that can be in two states: "On" and "Off".
		/// </summary>
		[Generated]
		public SwitchBuilder SwitchFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			SwitchBuilder switchBuilder = Switch();
			switchBuilder.PrepareEditorFor(base.Html, expression);
			return switchBuilder;
		}

		/// <summary>
		/// TabPanel��һ����Tabs��MultiView�ؼ���ɵĿؼ���
		/// �����Զ���ѡ����ѡ��뵱ǰ��ʾ����ͼͬ������֮��Ȼ��
		/// The TabPanel is a widget consisting of the Tabs and MultiView widgets. 
		/// It automatically synchronizes the selected tab with the currently displayed view and vice versa.
		/// </summary>
		[Generated]
		public TabPanelBuilder TabPanel()
		{
			return new TabPanelBuilder(new OptionsOwnerContext("dxTabPanel", base.Owner, base.Html));
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
		/// TagBox�ؼ���һ���༭�������������û��������б���ѡ������Ŀ��
		/// The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.
		/// </summary>
		[Generated]
		public TagBoxBuilder TagBox()
		{
			return new TagBoxBuilder(new OptionsOwnerContext("dxTagBox", base.Owner, base.Html));
		}

		/// <summary>
		/// TagBox�ؼ���һ���༭�������������û��������б���ѡ������Ŀ��
		/// The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.
		/// </summary>
		[Generated]
		public TagBoxBuilder TagBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			TagBoxBuilder tagBoxBuilder = TagBox();
			tagBoxBuilder.PrepareEditorFor(base.Html, expression);
			return tagBoxBuilder;
		}

		/// <summary>
		/// �ı�������һ���ؼ���ʹ�û���������ͱ༭�����ı���
		/// The TextArea is a widget that enables a user to enter and edit a multi-line text.
		/// </summary>
		[Generated]
		public TextAreaBuilder TextArea()
		{
			return new TextAreaBuilder(new OptionsOwnerContext("dxTextArea", base.Owner, base.Html));
		}

		/// <summary>
		/// �ı�������һ���ؼ���ʹ�û���������ͱ༭�����ı���
		/// The TextArea is a widget that enables a user to enter and edit a multi-line text.
		/// </summary>
		[Generated]
		public TextAreaBuilder TextAreaFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			TextAreaBuilder textAreaBuilder = TextArea();
			textAreaBuilder.PrepareEditorFor(base.Html, expression);
			return textAreaBuilder;
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
		/// �ı���ؼ��������û�����ͱ༭һ���ı���
		/// The TextBox is a widget that enables a user to enter and edit a single line of text.
		/// </summary>
		[Generated]
		public TextBoxBuilder TextBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			TextBoxBuilder textBoxBuilder = TextBox();
			textBoxBuilder.PrepareEditorFor(base.Html, expression);
			return textBoxBuilder;
		}

		/// <summary>
		/// TileView�ؼ�����һ��tile���ϡ�
		/// Tiles���Դ洢����ͨ��ť��ö����Ϣ�������Ϊʲô������Ϊ�����豸��Ƶ�Ӧ�ó����зǳ��ܻ�ӭ��ԭ��
		/// The TileView widget contains a collection of tiles. 
		/// Tiles can store much more information than ordinary buttons, that is why they are very popular in apps designed for touch devices.
		/// </summary>
		[Generated]
		public TileViewBuilder TileView()
		{
			return new TileViewBuilder(new OptionsOwnerContext("dxTileView", base.Owner, base.Html));
		}

		/// <summary>
		/// The Toast is a widget that provides pop-up notifications.
		/// Toast��һ���ṩ����֪ͨ�Ŀؼ��� 
		/// </summary>
		[Generated]
		public ToastBuilder Toast()
		{
			return new ToastBuilder(new OptionsOwnerContext("dxToast", base.Owner, base.Html));
		}

		/// <summary>
		/// �������ؼ�������ͨ��������Ļ���ݵ��
		/// ��Щ������Ǵ��ı���ؼ���
		/// The Toolbar is a widget containing items that usually manage screen content. 
		/// Those items can be plain text or widgets.
		/// </summary>
		[Generated]
		public ToolbarBuilder Toolbar()
		{
			return new ToolbarBuilder(new OptionsOwnerContext("dxToolbar", base.Owner, base.Html));
		}

		/// <summary>
		/// ������ʾ�ؼ���ʾҳ����ָ��Ԫ�صĹ�����ʾ�� 
		/// The Tooltip widget displays a tooltip for a specified element on the page.
		/// </summary>
		[Generated]
		public TooltipBuilder Tooltip()
		{
			return new TooltipBuilder(new OptionsOwnerContext("dxTooltip", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeList�ؼ������Զ�������ͼ����ʽ��ʾ���Ա��ػ�Զ��Դ�����ݡ�
		/// ����ؼ��ṩ���򡢹��ˡ��༭��ѡ��ȹ��ܡ�
		/// The TreeList is a widget that represents data from a local or remote source in the form of a multi-column tree view. 
		/// This widget offers such features as sorting, filtering, editing, selection, etc.
		/// </summary>
		[Generated]
		public TreeListBuilder<object> TreeList()
		{
			return new TreeListBuilder<object>(new OptionsOwnerContext("dxTreeList", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeList�ؼ������Զ�������ͼ����ʽ��ʾ���Ա��ػ�Զ��Դ�����ݡ�
		/// ����ؼ��ṩ���򡢹��ˡ��༭��ѡ��ȹ��ܡ�
		/// The TreeList is a widget that represents data from a local or remote source in the form of a multi-column tree view. 
		/// This widget offers such features as sorting, filtering, editing, selection, etc.
		/// </summary>
		[Generated]
		public TreeListBuilder<T> TreeList<T>()
		{
			return new TreeListBuilder<T>(new OptionsOwnerContext("dxTreeList", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeView�ؼ����ı����ݵ���״��ʾ�� 
		/// The TreeView widget is a tree-like representation of textual data.
		/// </summary>
		[Generated]
		public TreeViewBuilder TreeView()
		{
			return new TreeViewBuilder(new OptionsOwnerContext("dxTreeView", base.Owner, base.Html));
		}

		/// <summary>
		/// A widget for displaying the result of checking validation rules for editors.
		/// ��ʾ�༭�������֤�������Ŀؼ���
		/// </summary>
		[Generated]
		public ValidationSummaryBuilder ValidationSummary()
		{
			return new ValidationSummaryBuilder(new OptionsOwnerContext("dxValidationSummary", base.Owner, base.Html));
		}

		/// <summary>
		/// BarGauge�ؼ���������Բ������ÿ��������ʾһ��ֵ��
		/// The BarGauge widget contains several circular bars that each indicates a single value.
		/// </summary>
		[Generated]
		public BarGaugeBuilder BarGauge()
		{
			return new BarGaugeBuilder(new OptionsOwnerContext("dxBarGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// ����Ҫ����������ֵ��Ŀ��ֵ���бȽ�ʱ����Ŀ���ſؼ��ǳ����á�
		/// �ÿؼ�����һ����ʾ����ֵ��ˮƽ����һ����ʾĿ��ֵ�Ĵ�ֱ�ߡ�
		/// The Bullet widget is useful when you need to compare a single measure to a target value. 
		/// The widget comprises a horizontal bar indicating the measure and a vertical line indicating the target value.
		/// </summary>
		[Generated]
		public BulletBuilder Bullet()
		{
			return new BulletBuilder(new OptionsOwnerContext("dxBullet", base.Owner, base.Html));
		}

		/// <summary>
		/// ͼ����һ���ؼ�����ʹ�ø���ϵ�������Լ���ͬ�Ľ���Ԫ�أ��繤����ʾ��ʮ�ֹ�ꡢͼ���ȣ����ӻ����Ա��ػ�Զ�̴洢�����ݡ�
		/// The Chart is a widget that visualizes data from a local or remote storage using a great variety of series types along with different interactive elements, such as tooltips, crosshair pointer, legend, etc.
		/// </summary>
		[Generated]
		public ChartBuilder Chart()
		{
			return new ChartBuilder(new OptionsOwnerContext("dxChart", base.Owner, base.Html));
		}

		/// <summary>
		/// CircularGage�ؼ�������ָʾѭ����ֵ�̶��ϵ�ֵ��
		/// The CircularGauge is a widget that indicates values on a circular numeric scale.
		/// </summary>
		[Generated]
		public CircularGaugeBuilder CircularGauge()
		{
			return new CircularGaugeBuilder(new OptionsOwnerContext("dxCircularGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// ©���ؼ��������ڲ�ͬ�׶ο��ӻ�һ��ֵ��
		/// ��������������Щ�׶εļ�ֵ�仯����ȷ��Ǳ�����⡣
        /// ©���ؼ�ʹ�ò�ͬ�Ľ���Ԫ�أ�������ʾ����ǩ��ͼ����������Ϣ��ʹ���������Դ���©���������Դ�����׶ͼ��
		/// The Funnel is a widget that visualizes a value at different stages. 
		/// It helps assess value changes throughout these stages and identify potential issues. 
		/// The Funnel widget conveys information using different interactive elements (tooltips, labels, legend) and enables you to create not only a funnel, but also a pyramid chart.
		/// </summary>
		[Generated]
		public FunnelBuilder Funnel()
		{
			return new FunnelBuilder(new OptionsOwnerContext("dxFunnel", base.Owner, base.Html));
		}

		/// <summary>
		/// LinearGauge�ؼ�������ָʾ�������̶ֿ��ϵ�ֵ��
		/// The LinearGauge is a widget that indicates values on a linear numeric scale.
		/// </summary>
		[Generated]
		public LinearGaugeBuilder LinearGauge()
		{
			return new LinearGaugeBuilder(new OptionsOwnerContext("dxLinearGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// PieChart�ؼ����������ݿ��ӻ�Ϊһ��ԲȦ���ֳɼ���������ÿ��������������������һ���֡�
		/// The PieChart is a widget that visualizes data as a circle divided into sectors that each represents a portion of the whole.
		/// </summary>
		[Generated]
		public PieChartBuilder PieChart()
		{
			return new PieChartBuilder(new OptionsOwnerContext("dxPieChart", base.Owner, base.Html));
		}

		/// <summary>
		/// PolarChart��һ���ڼ�����ϵ�п��ӻ����ݵĿؼ���
		/// The PolarChart is a widget that visualizes data in a polar coordinate system.
		/// </summary>
		[Generated]
		public PolarChartBuilder PolarChart()
		{
			return new PolarChartBuilder(new OptionsOwnerContext("dxPolarChart", base.Owner, base.Html));
		}

		/// <summary>
		/// RangeSelector�ؼ��������û���һ���̶���ѡ��һ��ֵ��Χ��
		/// The RangeSelector is a widget that allows a user to select a range of values on a scale.
		/// </summary>
		[Generated]
		public RangeSelectorBuilder RangeSelector()
		{
			return new RangeSelectorBuilder(new OptionsOwnerContext("dxRangeSelector", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ͼ�ؼ���һ�����յ�ͼ��ֻ����һ��ϵ�С�
		/// ��������ͼ�Ĵ�С������ռ�õĿռ�ǳ�С�����Ժ����׵��ռ������л�ֱ��Ƕ�뵽�ı��С�
		/// The Sparkline widget is a compact chart that contains only one series. 
		/// Owing to their size, sparklines occupy very little space and can be easily collected in a table or embedded straight in text.
		/// </summary>
		[Generated]
		public SparklineBuilder Sparkline()
		{
			return new SparklineBuilder(new OptionsOwnerContext("dxSparkline", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeMap�ؼ�����ʹ��Ƕ�׾�����ʾ�ֲ����ݡ�
		/// The TreeMap is a widget that displays hierarchical data by using nested rectangles.
		/// </summary>
		[Generated]
		public TreeMapBuilder TreeMap()
		{
			return new TreeMapBuilder(new OptionsOwnerContext("dxTreeMap", base.Owner, base.Html));
		}

		/// <summary>
		/// VectorMap��һ�����ӻ�����λ�õĿؼ���
		/// �˿ؼ���ʾ��������ͱ�ǵĵ����ͼ��
		/// ���������½�͹��ҡ�
		/// ��Ǳ�ǵ�ͼ�ϵ��ض��㣬������򡢳��л��׶���
		/// The VectorMap is a widget that visualizes geographical locations. 
		/// This widget represents a geographical map that contains areas and markers. 
		/// Areas embody continents and countries. 
		/// Markers flag specific points on the map, for example, towns, cities or capitals.
		/// </summary>
		[Generated]
		public VectorMapBuilder VectorMap()
		{
			return new VectorMapBuilder(new OptionsOwnerContext("dxVectorMap", base.Owner, base.Html));
		}

		/// <summary>
		/// ����ģ�塣�Զ���һ��ģ�幩�����ؼ����á�
		/// </summary>
		/// <param name="name">ģ������</param>
		/// <returns></returns>
		public IDisposable NamedTemplate(string name)
		{
			return new NamedTemplate(base.Html.ViewContext, name);
		}

		/// <summary>
		/// ��֤��
		/// </summary>
		/// <returns></returns>
		public ValidationGroup ValidationGroup()
		{
			return new ValidationGroup(base.Html.ViewContext);
		}

		/// <summary>
		/// ��֤��
		/// </summary>
		/// <param name="name">��֤�������</param>
		/// <returns></returns>
		public ValidationGroup ValidationGroup(string name)
		{
			return new ValidationGroup(base.Html.ViewContext, name);
		}
	}
}
