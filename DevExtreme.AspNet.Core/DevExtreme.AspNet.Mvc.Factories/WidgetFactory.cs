using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// WidgetFactory控件工厂，里面包含了各种控件。
	/// 注意控件工厂是非静态类，说明每个控件的取得都必须通过实例获取，例如：
	/// ButtonBuilder button= new WidgetFactory<object>(null, new HtmlHelperAdapter(html)).Button();
	/// </summary>
	/// <typeparam name="TModel"></typeparam>
	public class WidgetFactory<TModel> : AbstractWidgetFactory
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="owner">拥有者，谁拥有控件。保留未用。</param>
		/// <param name="html">Html适配器，控件在哪个页面创建。</param>
		public WidgetFactory(OptionsOwnerBuilder owner, IHtmlHelperAdapter html)
			: base(owner, html)
		{
			//
		}

		/// <summary>
		/// Accordion控件包含几个显示在另一个面板下的面板。
		/// 这些面板可以由最终用户折叠或展开，这使得这个控件对于在有限的空间中显示信息非常有用。
		/// The Accordion widget contains several panels displayed one under another. 
		/// These panels can be collapsed or expanded by an end user, which makes this widget very useful for presenting information in a limited amount of space.
		/// </summary>
		[Generated]
		public AccordionBuilder Accordion()
		{
			return new AccordionBuilder(new OptionsOwnerContext("dxAccordion", base.Owner, base.Html));
		}

		/// <summary>
		/// 这些按钮通常表示与单个任务相关的多个选项。
		/// The ActionSheet widget is a sheet containing a set of buttons located one under the other. 
		/// These buttons usually represent several choices relating to a single task.
		/// ActionSheet控件是一个包含一组位于另一个按钮下的按钮的工作表。
		/// </summary>
		[Generated]
		public ActionSheetBuilder ActionSheet()
		{
			return new ActionSheetBuilder(new OptionsOwnerContext("dxActionSheet", base.Owner, base.Html));
		}

		/// <summary>
		/// Autocomplete控件是一个文本框，当用户键入时，它自动弹出文本提供建议。
		/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Autocomplete()
		{
			return new AutocompleteBuilder(new OptionsOwnerContext("dxAutocomplete", base.Owner, base.Html));
		}

		/// <summary>
		/// Autocomplete控件是一个文本框，当用户键入时，它自动弹出文本提供建议。
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
		/// Box控件允许您在其中排列各种元素。
		/// 独立且自适应的Box控件充当布局的构建块。
		/// The Box widget allows you to arrange various elements within it. 
		/// Separate and adaptive, the Box widget acts as a building block for the layout.
		/// </summary>
		[Generated]
		public BoxBuilder Box()
		{
			return new BoxBuilder(new OptionsOwnerContext("dxBox", base.Owner, base.Html));
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
		/// ButtongGroup控件，它包含一组切换按钮，可以用作模式切换程序。
		/// The ButtonGroup is a widget that contains a set of toggle buttons and can be used as a mode switcher.
		/// </summary>
		[Generated]
		public ButtonGroupBuilder ButtonGroup()
		{
			return new ButtonGroupBuilder(new OptionsOwnerContext("dxButtonGroup", base.Owner, base.Html));
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
		/// 日历是一个显示日历的控件，允许最终用户在指定的日期范围内选择所需的日期。
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
		/// 复选框控件是一个小框，当最终用户选择时，它显示已启用特定功能或已选择特定选项。
		/// The CheckBox is a small box, which when selected by the end user, shows that a particular feature has been enabled or a specific option has been chosen.
		/// </summary>
		[Generated]
		public CheckBoxBuilder CheckBox()
		{
			return new CheckBoxBuilder(new OptionsOwnerContext("dxCheckBox", base.Owner, base.Html));
		}

		/// <summary>
		/// 复选框是一个小框，当最终用户选择时，它显示已启用特定功能或已选择特定选项。
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
		/// ColorBox控件，允许最终用户输入颜色或从下拉编辑器中选择颜色。 
		/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
		/// </summary>
		[Generated]
		public ColorBoxBuilder ColorBox()
		{
			return new ColorBoxBuilder(new OptionsOwnerContext("dxColorBox", base.Owner, base.Html));
		}

		/// <summary>
		/// ColorBox控件，允许最终用户输入颜色或从下拉编辑器中选择颜色。 
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
		/// ContextMenu控件显示一个或多个级别的上下文菜单。
		/// 最终用户通过右键单击或长按来调用此菜单。
		/// The ContextMenu widget displays a single- or multi-level context menu. 
		/// An end user invokes this menu by a right click or a long press.
		/// </summary>
		[Generated]
		public ContextMenuBuilder ContextMenu()
		{
			return new ContextMenuBuilder(new OptionsOwnerContext("dxContextMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// DataGrid控件，它以网格的形式表示来自本地或远程源的数据。
		/// 这个控件提供了诸如排序、分组、筛选等基本功能，以及更高级的功能，如状态存储、导出到Excel、主细节界面和许多其他功能。
		/// The DataGrid is a widget that represents data from a local or remote source in the form of a grid. 
		/// This widget offers such basic features as sorting, grouping, filtering, as well as more advanced capabilities, like state storing, export to Excel, master-detail interface, and many others.
		/// </summary>
		[Generated]
		public DataGridBuilder<object> DataGrid()
		{
			return new DataGridBuilder<object>(new OptionsOwnerContext("dxDataGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// DataGrid控件，它以网格的形式表示来自本地或远程源的数据。
		/// 这个控件提供了诸如排序、分组、筛选等基本功能，以及更高级的功能，如状态存储、导出到Excel、主细节界面和许多其他功能。
		/// The DataGrid is a widget that represents data from a local or remote source in the form of a grid. 
		/// This widget offers such basic features as sorting, grouping, filtering, as well as more advanced capabilities, like state storing, export to Excel, master-detail interface, and many others.
		/// </summary>
		[Generated]
		public DataGridBuilder<T> DataGrid<T>()
		{
			return new DataGridBuilder<T>(new OptionsOwnerContext("dxDataGrid", base.Owner, base.Html));
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
		/// DateBox控件，它以指定的格式显示日期和时间，并允许用户选择或键入所需的日期/时间值。
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
		/// 图表控件提供了一个可视化界面，以帮助您设计新的和修改现有的图表。
		/// [tags] ctp The Diagram widget provides a visual interface to help you design new and modify existing diagrams. 
		/// #include common-ctp-note with { component: "Diagram" }
		/// </summary>
		[Generated]
		public DiagramBuilder Diagram()
		{
			return new DiagramBuilder(new OptionsOwnerContext("dxDiagram", base.Owner, base.Html));
		}

		/// <summary>
		/// Draggable是一个用户界面实用程序，允许拖放控件。
		/// Draggable is a user interface utility that allows widget elements to be dragged and dropped.
		/// </summary>
		[Generated]
		public DraggableBuilder Draggable()
		{
			return new DraggableBuilder(new OptionsOwnerContext("dxDraggable", base.Owner, base.Html));
		}

		/// <summary>
		/// 抽屉是一个可忽略或永久可见的面板，用于在响应式web应用程序布局中导航。
		/// The Drawer is a dismissible or permanently visible panel used for navigation in responsive web application layouts.
		/// </summary>
		[Generated]
		public DrawerBuilder Drawer()
		{
			return new DrawerBuilder(new OptionsOwnerContext("dxDrawer", base.Owner, base.Html));
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
		/// 下拉框控件由显示当前值的文本字段和可以包含任何UI元素的下拉字段组成。
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
		/// 下拉按钮控件是打开下拉菜单的按钮。
		/// The DropDownButton is a button that opens a drop-down menu.
		/// </summary>
		[Generated]
		public DropDownButtonBuilder DropDownButton()
		{
			return new DropDownButtonBuilder(new OptionsOwnerContext("dxDropDownButton", base.Owner, base.Html));
		}

		/// <summary>
		/// 文件管理器控件，允许用户上传、选择和管理不同文件存储中的文件和目录。
		/// [tags] ctp The FileManager is a widget that allows users to upload, select, and manage files and directories in different file storages. 
		/// #include common-ctp-note with { component: "FileManager" }
		/// </summary>
		[Generated]
		public FileManagerBuilder FileManager()
		{
			return new FileManagerBuilder(new OptionsOwnerContext("dxFileManager", base.Owner, base.Html));
		}

		/// <summary>
		/// FileUploader控件允许最终用户将文件上载到服务器。
		/// 最终用户可以在文件资源管理器中选择文件，或将文件拖放到页面上的文件上载程序区域。
		/// The FileUploader widget enables an end user to upload files to the server. 
		/// An end user can select files in the file explorer or drag and drop files to the FileUploader area on the page.
		/// </summary>
		[Generated]
		public FileUploaderBuilder FileUploader()
		{
			return new FileUploaderBuilder(new OptionsOwnerContext("dxFileUploader", base.Owner, base.Html));
		}

		/// <summary>
		/// FilterBuilder控件允许用户通过使用UI的逻辑操作组合使用无限数量的过滤条件来构建复杂的过滤表达式。
		/// The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions, combined by logical operations using the UI.
		/// </summary>
		[Generated]
		public FilterBuilderBuilder<object> FilterBuilder()
		{
			return new FilterBuilderBuilder<object>(new OptionsOwnerContext("dxFilterBuilder", base.Owner, base.Html));
		}

		/// <summary>
		/// FilterBuilder控件允许用户通过使用UI的逻辑操作组合使用无限数量的过滤条件来构建复杂的过滤表达式。
		/// The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions, combined by logical operations using the UI.
		/// </summary>
		[Generated]
		public FilterBuilderBuilder<T> FilterBuilder<T>()
		{
			return new FilterBuilderBuilder<T>(new OptionsOwnerContext("dxFilterBuilder", base.Owner, base.Html));
		}

		/// <summary>
		/// 表单控件将数据对象的字段表示为标签编辑器对的集合。
		/// 这些对可以按多个组、选项卡和列排列。
		/// The Form widget represents fields of a data object as a collection of label-editor pairs. 
		/// These pairs can be arranged in several groups, tabs and columns.
		/// </summary>
		[Generated]
		public FormBuilder<object> Form()
		{
			return new FormBuilder<object>(new OptionsOwnerContext("dxForm", base.Owner, base.Html));
		}

		/// <summary>
		/// 表单控件将数据对象的字段表示为标签编辑器对的集合。
		/// 这些对可以按多个组、选项卡和列排列。
		/// The Form widget represents fields of a data object as a collection of label-editor pairs. 
		/// These pairs can be arranged in several groups, tabs and columns.
		/// </summary>
		[Generated]
		public FormBuilder<T> Form<T>()
		{
			return new FormBuilder<T>(new OptionsOwnerContext("dxForm", base.Owner, base.Html));
		}

		/// <summary>
		/// Gallery控件，用于在旋转木马中显示图像集合。
		/// 控件提供了各种导航控件，允许用户在图像之间切换。
		/// The Gallery is a widget that displays a collection of images in a carousel. 
		/// The widget is supplied with various navigation controls that allow a user to switch between images.
		/// </summary>
		[Generated]
		public GalleryBuilder Gallery()
		{
			return new GalleryBuilder(new OptionsOwnerContext("dxGallery", base.Owner, base.Html));
		}

		/// <summary>
		/// 甘特图控件，显示任务流和任务之间的依赖关系。
		/// [tags] ctp The Gantt is a widget that displays the task flow and dependencies between tasks. 
		/// #include common-ctp-note with { component: "Gantt" }
		/// </summary>
		[Generated]
		public GanttBuilder<object> Gantt()
		{
			return new GanttBuilder<object>(new OptionsOwnerContext("dxGantt", base.Owner, base.Html));
		}

		/// <summary>
		/// 甘特图控件，显示任务流和任务之间的依赖关系。
		/// [tags] ctp The Gantt is a widget that displays the task flow and dependencies between tasks. 
		/// #include common-ctp-note with { component: "Gantt" }
		/// </summary>
		[Generated]
		public GanttBuilder<T> Gantt<T>()
		{
			return new GanttBuilder<T>(new OptionsOwnerContext("dxGantt", base.Owner, base.Html));
		}

		/// <summary>
		/// HTML editor是一个WYSIWYG编辑器，允许您格式化文本和可视内容，并以HTML或标记的形式输出。HtmlEditor构建在上面，需要使用Quill。
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
		/// HTML editor是一个WYSIWYG编辑器，允许您格式化文本和可视内容，并以HTML或标记的形式输出。
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
		/// 列表控件，表示可滚动列表中的项目集合。
		/// The List is a widget that represents a collection of items in a scrollable list.
		/// </summary>
		[Generated]
		public ListBuilder List()
		{
			return new ListBuilder(new OptionsOwnerContext("dxList", base.Owner, base.Html));
		}

		/// <summary>
		/// LoadIndicator是一个UI元素，通知查看器进程正在进行。
		/// The LoadIndicator is a UI element notifying the viewer that a process is in progress.
		/// </summary>
		[Generated]
		public LoadIndicatorBuilder LoadIndicator()
		{
			return new LoadIndicatorBuilder(new OptionsOwnerContext("dxLoadIndicator", base.Owner, base.Html));
		}

		/// <summary>
		/// LoadPanel是一个覆盖控件，通知查看器正在加载。
		/// The LoadPanel is an overlay widget notifying the viewer that loading is in progress.
		/// </summary>
		[Generated]
		public LoadPanelBuilder LoadPanel()
		{
			return new LoadPanelBuilder(new OptionsOwnerContext("dxLoadPanel", base.Owner, base.Html));
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
		/// 查找控件，允许最终用户在下拉菜单中显示的集合中搜索项目。
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
		/// 地图是一个交互式小部件，它显示带有标记和路线的地理地图。
		/// The Map is an interactive widget that displays a geographic map with markers and routes.
		/// </summary>
		[Generated]
		public MapBuilder Map()
		{
			return new MapBuilder(new OptionsOwnerContext("dxMap", base.Owner, base.Html));
		}

		/// <summary>
		/// 菜单控件是一个带有可单击项的面板。单击某个项目将打开一个下拉菜单，其中可以包含多个子菜单。
		/// The Menu widget is a panel with clickable items. 
		/// A click on an item opens a drop-down menu, which can contain several submenus.
		/// </summary>
		[Generated]
		public MenuBuilder Menu()
		{
			return new MenuBuilder(new OptionsOwnerContext("dxMenu", base.Owner, base.Html));
		}

		/// <summary>
		/// 多视图是一个包含多个视图的控件。
		/// 最终用户通过在水平方向上滑动视图来导航视图。
		/// The MultiView is a widget that contains several views. 
		/// An end user navigates through the views by swiping them in the horizontal direction.
		/// </summary>
		[Generated]
		public MultiViewBuilder MultiView()
		{
			return new MultiViewBuilder(new OptionsOwnerContext("dxMultiView", base.Owner, base.Html));
		}

		/// <summary>
		/// 导航栏是导航应用程序视图的控件。
		/// The NavBar is a widget that navigates the application views.
		/// </summary>
		[Generated]
		public NavBarBuilder NavBar()
		{
			return new NavBarBuilder(new OptionsOwnerContext("dxNavBar", base.Owner, base.Html));
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
		/// NumberBox控件，它显示一个数值，并允许用户通过键入一个数值，然后使用键盘或鼠标对其进行递增或递减来修改它。
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
		/// PivotGrid控件，允许您显示和分析来自本地存储或OLAP多维数据集的多维数据。
		/// The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.
		/// </summary>
		[Generated]
		public PivotGridBuilder<object> PivotGrid()
		{
			return new PivotGridBuilder<object>(new OptionsOwnerContext("dxPivotGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// PivotGrid控件，允许您显示和分析来自本地存储或OLAP多维数据集的多维数据。
		/// The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.
		/// </summary>
		[Generated]
		public PivotGridBuilder<T> PivotGrid<T>()
		{
			return new PivotGridBuilder<T>(new OptionsOwnerContext("dxPivotGrid", base.Owner, base.Html));
		}

		/// <summary>
		/// Popover控件，它在一个带有指向指定UI元素的箭头的框中显示通知。
		/// The Popover is a widget that shows notifications within a box with an arrow pointing to a specified UI element.
		/// </summary>
		[Generated]
		public PopoverBuilder Popover()
		{
			return new PopoverBuilder(new OptionsOwnerContext("dxPopover", base.Owner, base.Html));
		}

		/// <summary>
		/// The Popup widget is a pop-up window overlaying the current view.
		/// 弹出窗口控件是覆盖当前视图的弹出窗口。
		/// </summary>
		[Generated]
		public PopupBuilder Popup()
		{
			return new PopupBuilder(new OptionsOwnerContext("dxPopup", base.Owner, base.Html));
		}

		/// <summary>
		/// ProgressBar是显示当前进度的控件。
		/// The ProgressBar is a widget that shows current progress.
		/// </summary>
		[Generated]
		public ProgressBarBuilder ProgressBar()
		{
			return new ProgressBarBuilder(new OptionsOwnerContext("dxProgressBar", base.Owner, base.Html));
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
		/// RadioGroup控件，它包含一组单选按钮，允许最终用户从中进行单个选择。
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
		/// RangeSlider控件，允许最终用户选择一个数值范围。
		/// The RangeSlider is a widget that allows an end user to choose a range of numeric values.
		/// </summary>
		[Generated]
		public RangeSliderBuilder RangeSlider()
		{
			return new RangeSliderBuilder(new OptionsOwnerContext("dxRangeSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// 编辑期的基类。
		/// A base class for editors.
		/// </summary>
		[Generated]
		public RecurrenceEditorBuilder RecurrenceEditor()
		{
			return new RecurrenceEditorBuilder(new OptionsOwnerContext("dxRecurrenceEditor", base.Owner, base.Html));
		}

		/// <summary>
		/// 编辑期的基类。
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
		/// 可调整大小控件使其内容在UI中可调整大小。 
		/// The Resizable widget enables its content to be resizable in the UI.
		/// </summary>
		[Generated]
		public ResizableBuilder Resizable()
		{
			return new ResizableBuilder(new OptionsOwnerContext("dxResizable", base.Owner, base.Html));
		}

		/// <summary>
		/// ResponsiveBox控件允许您创建一个应用程序或网站，其布局适合不同的屏幕大小。
		/// The ResponsiveBox widget allows you to create an application or a website with a layout adapted to different screen sizes.
		/// </summary>
		[Generated]
		public ResponsiveBoxBuilder ResponsiveBox()
		{
			return new ResponsiveBoxBuilder(new OptionsOwnerContext("dxResponsiveBox", base.Owner, base.Html));
		}

		/// <summary>
		/// Sankey控件，它可以可视化值集之间的流大小。
		/// 连接的值称为节点；连接-链接。
		/// 流量大小越大，连接越宽。
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
		/// 调度器是一个小部件，它表示计划的数据，并允许用户管理和编辑它。
		/// The Scheduler is a widget that represents scheduled data and allows a user to manage and edit it.
		/// </summary>
		[Generated]
		public SchedulerBuilder Scheduler()
		{
			return new SchedulerBuilder(new OptionsOwnerContext("dxScheduler", base.Owner, base.Html));
		}

		/// <summary>
		/// ScrollView控件，允许用户滚动其内容。
		/// The ScrollView is a widget that enables a user to scroll its content.
		/// </summary>
		[Generated]
		public ScrollViewBuilder ScrollView()
		{
			return new ScrollViewBuilder(new OptionsOwnerContext("dxScrollView", base.Owner, base.Html));
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
		/// SelectBox控件是一个编辑器，允许最终用户从下拉列表中选择项目。
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
		/// SlideOut小部件是一个与视图配对的经典滑出菜单。
		/// 最终用户通过滑动视图打开菜单。
		/// The SlideOut widget is a classic slide-out menu paired with a view. 
		/// An end user opens the menu by swiping away the view.
		/// </summary>
		[Generated]
		public SlideOutBuilder SlideOut()
		{
			return new SlideOutBuilder(new OptionsOwnerContext("dxSlideOut", base.Owner, base.Html));
		}

		/// <summary>
		/// SlideOutView控件是与视图配对的经典滑出菜单。
		/// 这个控件与SlideOut非常相似，只有一个不同之处：SlideOut总是包含SlideOut菜单中的列表，而SlideOut视图可以保存任何集合。
		/// The SlideOutView widget is a classic slide-out menu paired with a view. 
		/// This widget is very similar to the SlideOut with only one difference - the SlideOut always contains the List in the slide-out menu, while the SlideOutView can hold any collection there.
		/// </summary>
		[Generated]
		public SlideOutViewBuilder SlideOutView()
		{
			return new SlideOutViewBuilder(new OptionsOwnerContext("dxSlideOutView", base.Owner, base.Html));
		}

		/// <summary>
		/// 滑块是一个控件，允许最终用户在可能值的连续范围内设置数值。
		/// The Slider is a widget that allows an end user to set a numeric value on a continuous range of possible values.
		/// </summary>
		[Generated]
		public SliderBuilder Slider()
		{
			return new SliderBuilder(new OptionsOwnerContext("dxSlider", base.Owner, base.Html));
		}

		/// <summary>
		/// 滑块控件，允许最终用户在可能值的连续范围内设置数值。
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
		/// Sortable是一个用户界面实用程序，它允许通过拖放手势对控件的项重新排序。
		/// Sortable is a user interface utility that allows a widget's items to be reordered via drag and drop gestures.
		/// </summary>
		[Generated]
		public SortableBuilder Sortable()
		{
			return new SortableBuilder(new OptionsOwnerContext("dxSortable", base.Owner, base.Html));
		}

		/// <summary>
		/// SpeedDialAction是执行自定义操作的按钮。
		/// 它可以由一个浮动操作按钮（FAB）或一个快速拨号菜单中的按钮来表示。
		/// The SpeedDialAction is a button that performs a custom action. 
		/// It can be represented by a Floating Action Button (FAB) or a button in a speed dial menu opened with the FAB.
		/// </summary>
		[Generated]
		public SpeedDialActionBuilder SpeedDialAction()
		{
			return new SpeedDialActionBuilder(new OptionsOwnerContext("dxSpeedDialAction", base.Owner, base.Html));
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
		/// 开关控件，可以有两种状态："开"和"关"。
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
		/// TabPanel是一个由Tabs和MultiView控件组成的控件。
		/// 它会自动将选定的选项卡与当前显示的视图同步，反之亦然。
		/// The TabPanel is a widget consisting of the Tabs and MultiView widgets. 
		/// It automatically synchronizes the selected tab with the currently displayed view and vice versa.
		/// </summary>
		[Generated]
		public TabPanelBuilder TabPanel()
		{
			return new TabPanelBuilder(new OptionsOwnerContext("dxTabPanel", base.Owner, base.Html));
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
		/// TagBox控件是一个编辑器，允许最终用户从下拉列表中选择多个项目。
		/// The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.
		/// </summary>
		[Generated]
		public TagBoxBuilder TagBox()
		{
			return new TagBoxBuilder(new OptionsOwnerContext("dxTagBox", base.Owner, base.Html));
		}

		/// <summary>
		/// TagBox控件是一个编辑器，允许最终用户从下拉列表中选择多个项目。
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
		/// 文本区域是一个控件，使用户可以输入和编辑多行文本。
		/// The TextArea is a widget that enables a user to enter and edit a multi-line text.
		/// </summary>
		[Generated]
		public TextAreaBuilder TextArea()
		{
			return new TextAreaBuilder(new OptionsOwnerContext("dxTextArea", base.Owner, base.Html));
		}

		/// <summary>
		/// 文本区域是一个控件，使用户可以输入和编辑多行文本。
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
		/// 文本框控件，允许用户输入和编辑一行文本。
		/// The TextBox is a widget that enables a user to enter and edit a single line of text.
		/// </summary>
		[Generated]
		public TextBoxBuilder TextBox()
		{
			return new TextBoxBuilder(new OptionsOwnerContext("dxTextBox", base.Owner, base.Html));
		}

		/// <summary>
		/// 文本框控件，允许用户输入和编辑一行文本。
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
		/// TileView控件包含一个tile集合。
		/// Tiles可以存储比普通按钮多得多的信息，这就是为什么它们在为触摸设备设计的应用程序中非常受欢迎的原因。
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
		/// Toast是一个提供弹出通知的控件。 
		/// </summary>
		[Generated]
		public ToastBuilder Toast()
		{
			return new ToastBuilder(new OptionsOwnerContext("dxToast", base.Owner, base.Html));
		}

		/// <summary>
		/// 工具栏控件，包含通常管理屏幕内容的项。
		/// 这些项可以是纯文本或控件。
		/// The Toolbar is a widget containing items that usually manage screen content. 
		/// Those items can be plain text or widgets.
		/// </summary>
		[Generated]
		public ToolbarBuilder Toolbar()
		{
			return new ToolbarBuilder(new OptionsOwnerContext("dxToolbar", base.Owner, base.Html));
		}

		/// <summary>
		/// 工具提示控件显示页面上指定元素的工具提示。 
		/// The Tooltip widget displays a tooltip for a specified element on the page.
		/// </summary>
		[Generated]
		public TooltipBuilder Tooltip()
		{
			return new TooltipBuilder(new OptionsOwnerContext("dxTooltip", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeList控件，它以多列树视图的形式表示来自本地或远程源的数据。
		/// 这个控件提供排序、过滤、编辑、选择等功能。
		/// The TreeList is a widget that represents data from a local or remote source in the form of a multi-column tree view. 
		/// This widget offers such features as sorting, filtering, editing, selection, etc.
		/// </summary>
		[Generated]
		public TreeListBuilder<object> TreeList()
		{
			return new TreeListBuilder<object>(new OptionsOwnerContext("dxTreeList", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeList控件，它以多列树视图的形式表示来自本地或远程源的数据。
		/// 这个控件提供排序、过滤、编辑、选择等功能。
		/// The TreeList is a widget that represents data from a local or remote source in the form of a multi-column tree view. 
		/// This widget offers such features as sorting, filtering, editing, selection, etc.
		/// </summary>
		[Generated]
		public TreeListBuilder<T> TreeList<T>()
		{
			return new TreeListBuilder<T>(new OptionsOwnerContext("dxTreeList", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeView控件是文本数据的树状表示。 
		/// The TreeView widget is a tree-like representation of textual data.
		/// </summary>
		[Generated]
		public TreeViewBuilder TreeView()
		{
			return new TreeViewBuilder(new OptionsOwnerContext("dxTreeView", base.Owner, base.Html));
		}

		/// <summary>
		/// A widget for displaying the result of checking validation rules for editors.
		/// 显示编辑器检查验证规则结果的控件。
		/// </summary>
		[Generated]
		public ValidationSummaryBuilder ValidationSummary()
		{
			return new ValidationSummaryBuilder(new OptionsOwnerContext("dxValidationSummary", base.Owner, base.Html));
		}

		/// <summary>
		/// BarGauge控件包含几个圆形条，每个条都表示一个值。
		/// The BarGauge widget contains several circular bars that each indicates a single value.
		/// </summary>
		[Generated]
		public BarGaugeBuilder BarGauge()
		{
			return new BarGaugeBuilder(new OptionsOwnerContext("dxBarGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// 当需要将单个度量值与目标值进行比较时，项目符号控件非常有用。
		/// 该控件包括一个表示测量值的水平条和一个表示目标值的垂直线。
		/// The Bullet widget is useful when you need to compare a single measure to a target value. 
		/// The widget comprises a horizontal bar indicating the measure and a vertical line indicating the target value.
		/// </summary>
		[Generated]
		public BulletBuilder Bullet()
		{
			return new BulletBuilder(new OptionsOwnerContext("dxBullet", base.Owner, base.Html));
		}

		/// <summary>
		/// 图表是一个控件，它使用各种系列类型以及不同的交互元素（如工具提示、十字光标、图例等）可视化来自本地或远程存储的数据。
		/// The Chart is a widget that visualizes data from a local or remote storage using a great variety of series types along with different interactive elements, such as tooltips, crosshair pointer, legend, etc.
		/// </summary>
		[Generated]
		public ChartBuilder Chart()
		{
			return new ChartBuilder(new OptionsOwnerContext("dxChart", base.Owner, base.Html));
		}

		/// <summary>
		/// CircularGage控件，用于指示循环数值刻度上的值。
		/// The CircularGauge is a widget that indicates values on a circular numeric scale.
		/// </summary>
		[Generated]
		public CircularGaugeBuilder CircularGauge()
		{
			return new CircularGaugeBuilder(new OptionsOwnerContext("dxCircularGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// 漏斗控件，可以在不同阶段可视化一个值。
		/// 它有助于评估这些阶段的价值变化，并确定潜在问题。
        /// 漏斗控件使用不同的交互元素（工具提示、标签、图例）传递信息，使您不仅可以创建漏斗，还可以创建棱锥图。
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
		/// LinearGauge控件，用于指示线性数字刻度上的值。
		/// The LinearGauge is a widget that indicates values on a linear numeric scale.
		/// </summary>
		[Generated]
		public LinearGaugeBuilder LinearGauge()
		{
			return new LinearGaugeBuilder(new OptionsOwnerContext("dxLinearGauge", base.Owner, base.Html));
		}

		/// <summary>
		/// PieChart控件，它将数据可视化为一个圆圈，分成几个扇区，每个扇区代表整个扇区的一部分。
		/// The PieChart is a widget that visualizes data as a circle divided into sectors that each represents a portion of the whole.
		/// </summary>
		[Generated]
		public PieChartBuilder PieChart()
		{
			return new PieChartBuilder(new OptionsOwnerContext("dxPieChart", base.Owner, base.Html));
		}

		/// <summary>
		/// PolarChart是一个在极坐标系中可视化数据的控件。
		/// The PolarChart is a widget that visualizes data in a polar coordinate system.
		/// </summary>
		[Generated]
		public PolarChartBuilder PolarChart()
		{
			return new PolarChartBuilder(new OptionsOwnerContext("dxPolarChart", base.Owner, base.Html));
		}

		/// <summary>
		/// RangeSelector控件，允许用户在一个刻度上选择一个值范围。
		/// The RangeSelector is a widget that allows a user to select a range of values on a scale.
		/// </summary>
		[Generated]
		public RangeSelectorBuilder RangeSelector()
		{
			return new RangeSelectorBuilder(new OptionsOwnerContext("dxRangeSelector", base.Owner, base.Html));
		}

		/// <summary>
		/// 迷你图控件是一个紧凑的图表，只包含一个系列。
		/// 由于迷你图的大小，它们占用的空间非常小，可以很容易地收集到表中或直接嵌入到文本中。
		/// The Sparkline widget is a compact chart that contains only one series. 
		/// Owing to their size, sparklines occupy very little space and can be easily collected in a table or embedded straight in text.
		/// </summary>
		[Generated]
		public SparklineBuilder Sparkline()
		{
			return new SparklineBuilder(new OptionsOwnerContext("dxSparkline", base.Owner, base.Html));
		}

		/// <summary>
		/// TreeMap控件，它使用嵌套矩形显示分层数据。
		/// The TreeMap is a widget that displays hierarchical data by using nested rectangles.
		/// </summary>
		[Generated]
		public TreeMapBuilder TreeMap()
		{
			return new TreeMapBuilder(new OptionsOwnerContext("dxTreeMap", base.Owner, base.Html));
		}

		/// <summary>
		/// VectorMap是一个可视化地理位置的控件。
		/// 此控件表示包含区域和标记的地理地图。
		/// 地区代表大陆和国家。
		/// 标记标记地图上的特定点，例如城镇、城市或首都。
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
		/// 命名模板。自定义一个模板供其它控件调用。
		/// </summary>
		/// <param name="name">模板名称</param>
		/// <returns></returns>
		public IDisposable NamedTemplate(string name)
		{
			return new NamedTemplate(base.Html.ViewContext, name);
		}

		/// <summary>
		/// 验证组
		/// </summary>
		/// <returns></returns>
		public ValidationGroup ValidationGroup()
		{
			return new ValidationGroup(base.Html.ViewContext);
		}

		/// <summary>
		/// 验证组
		/// </summary>
		/// <param name="name">验证组的名称</param>
		/// <returns></returns>
		public ValidationGroup ValidationGroup(string name)
		{
			return new ValidationGroup(base.Html.ViewContext, name);
		}
	}
}
