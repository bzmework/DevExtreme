using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>[tags] ctp The FileManager is a widget that allows users to upload, select, and manage files and directories in different file storages. #include common-ctp-note with { component: "FileManager" }</summary>
	public class FileManagerBuilder : WidgetBuilder
	{
		public FileManagerBuilder FileProvider(JS js)
		{
			base.Options["fileProvider"] = js;
			return this;
		}

		public FileManagerBuilder FileProvider(string staticJsonUrl)
		{
			base.Options["fileProvider"] = staticJsonUrl;
			return this;
		}

		public FileManagerBuilder FileProvider(Func<FileProviderFactory, OptionsOwnerBuilder> configurator)
		{
			FileProviderFactory arg = new FileProviderFactory(CreateChildContext("fileProvider"));
			configurator(arg).AttachNestedOptionsToParent(base.Options);
			return this;
		}

		[Generated]
		public FileManagerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public FileManagerBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public FileManagerBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FileManagerBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FileManagerBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FileManagerBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FileManagerBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the allowed upload file extensions.</summary>
		[Generated]
		public FileManagerBuilder AllowedFileExtensions(IEnumerable<string> value)
		{
			base.Options["allowedFileExtensions"] = value;
			return this;
		}

		/// <summary>Specifies the allowed upload file extensions.</summary>
		[Generated]
		public FileManagerBuilder AllowedFileExtensions(JS value)
		{
			base.Options["allowedFileExtensions"] = value;
			return this;
		}

		/// <summary>Configures the context menu settings.</summary>
		[Generated]
		public FileManagerBuilder ContextMenu(Action<FileManagerContextMenuBuilder> configurator)
		{
			NestedOptions("contextMenu", configurator);
			return this;
		}

		/// <summary>Specifies the path that is used when the FileManager is initialized.</summary>
		[Generated]
		public FileManagerBuilder CurrentPath(string value)
		{
			base.Options["currentPath"] = value;
			return this;
		}

		/// <summary>Specifies the path that is used when the FileManager is initialized.</summary>
		[Generated]
		public FileManagerBuilder CurrentPath(JS value)
		{
			base.Options["currentPath"] = value;
			return this;
		}

		/// <summary>Customizes columns in details view. Applies only if itemView.mode is "details".</summary>
		[Generated]
		public FileManagerBuilder CustomizeDetailColumns(string jsFunc)
		{
			AssignJS("customizeDetailColumns", jsFunc);
			return this;
		}

		/// <summary>Customizes columns in details view. Applies only if itemView.mode is "details".</summary>
		[Generated]
		public FileManagerBuilder CustomizeDetailColumns(RazorBlock jsFunc)
		{
			return CustomizeDetailColumns(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to provide custom icons to be used as thumbnails.</summary>
		[Generated]
		public FileManagerBuilder CustomizeThumbnail(string jsFunc)
		{
			AssignJS("customizeThumbnail", jsFunc);
			return this;
		}

		/// <summary>Allows you to provide custom icons to be used as thumbnails.</summary>
		[Generated]
		public FileManagerBuilder CustomizeThumbnail(RazorBlock jsFunc)
		{
			return CustomizeThumbnail(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FileManagerBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FileManagerBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileManagerBuilder ElementAttr(string attributeName, object value)
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

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileManagerBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileManagerBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileManagerBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FileManagerBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FileManagerBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileManagerBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileManagerBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileManagerBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FileManagerBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FileManagerBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FileManagerBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FileManagerBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures the file and folder view.</summary>
		[Generated]
		public FileManagerBuilder ItemView(Action<FileManagerItemViewBuilder> configurator)
		{
			NestedOptions("itemView", configurator);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FileManagerBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FileManagerBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the current directory is changed.</summary>
		[Generated]
		public FileManagerBuilder OnCurrentDirectoryChanged(string jsFunc)
		{
			AssignJS("onCurrentDirectoryChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the current directory is changed.</summary>
		[Generated]
		public FileManagerBuilder OnCurrentDirectoryChanged(RazorBlock jsFunc)
		{
			return OnCurrentDirectoryChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FileManagerBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FileManagerBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FileManagerBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FileManagerBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FileManagerBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FileManagerBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the selected file is opened.</summary>
		[Generated]
		public FileManagerBuilder OnSelectedFileOpened(string jsFunc)
		{
			AssignJS("onSelectedFileOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the selected file is opened.</summary>
		[Generated]
		public FileManagerBuilder OnSelectedFileOpened(RazorBlock jsFunc)
		{
			return OnSelectedFileOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies actions that a user is allowed to perform on files and folders.</summary>
		[Generated]
		public FileManagerBuilder Permissions(Action<FileManagerPermissionsBuilder> configurator)
		{
			NestedOptions("permissions", configurator);
			return this;
		}

		/// <summary>Specifies the root folder name.</summary>
		[Generated]
		public FileManagerBuilder RootFolderName(string value)
		{
			base.Options["rootFolderName"] = value;
			return this;
		}

		/// <summary>Specifies the root folder name.</summary>
		[Generated]
		public FileManagerBuilder RootFolderName(JS value)
		{
			base.Options["rootFolderName"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FileManagerBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FileManagerBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can select a single or multiple files and folders in the item view simultaneously.</summary>
		[Generated]
		public FileManagerBuilder SelectionMode(FileManagerSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FileManagerBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FileManagerBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Configures toolbar settings.</summary>
		[Generated]
		public FileManagerBuilder Toolbar(Action<FileManagerToolbarBuilder> configurator)
		{
			NestedOptions("toolbar", configurator);
			return this;
		}

		/// <summary>Configures upload settings.</summary>
		[Generated]
		public FileManagerBuilder Upload(Action<FileManagerUploadBuilder> configurator)
		{
			NestedOptions("upload", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FileManagerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FileManagerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileManagerBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileManagerBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileManagerBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
