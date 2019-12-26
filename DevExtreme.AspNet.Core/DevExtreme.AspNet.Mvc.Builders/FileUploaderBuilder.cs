using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The FileUploader widget enables an end user to upload files to the server. An end user can select files in the file explorer or drag and drop files to the FileUploader area on the page.</summary>
	public class FileUploaderBuilder : WidgetBuilder
	{
		[Generated]
		public FileUploaderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public FileUploaderBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public FileUploaderBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileUploaderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>A function that cancels the file upload.</summary>
		[Generated]
		public FileUploaderBuilder AbortUpload(string jsFunc)
		{
			AssignJS("abortUpload", jsFunc);
			return this;
		}

		/// <summary>A function that cancels the file upload.</summary>
		[Generated]
		public FileUploaderBuilder AbortUpload(RazorBlock jsFunc)
		{
			return AbortUpload(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a file type or several types accepted by the widget.</summary>
		[Generated]
		public FileUploaderBuilder Accept(string value)
		{
			base.Options["accept"] = value;
			return this;
		}

		/// <summary>Specifies a file type or several types accepted by the widget.</summary>
		[Generated]
		public FileUploaderBuilder Accept(JS value)
		{
			base.Options["accept"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FileUploaderBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FileUploaderBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FileUploaderBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FileUploaderBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies if an end user can remove a file from the selection and interrupt uploading.</summary>
		[Generated]
		public FileUploaderBuilder AllowCanceling(bool value)
		{
			base.Options["allowCanceling"] = value;
			return this;
		}

		/// <summary>Specifies if an end user can remove a file from the selection and interrupt uploading.</summary>
		[Generated]
		public FileUploaderBuilder AllowCanceling(JS value)
		{
			base.Options["allowCanceling"] = value;
			return this;
		}

		/// <summary>Restricts file extensions that can be uploaded to the server.</summary>
		[Generated]
		public FileUploaderBuilder AllowedFileExtensions(IEnumerable<string> value)
		{
			base.Options["allowedFileExtensions"] = value;
			return this;
		}

		/// <summary>Restricts file extensions that can be uploaded to the server.</summary>
		[Generated]
		public FileUploaderBuilder AllowedFileExtensions(JS value)
		{
			base.Options["allowedFileExtensions"] = value;
			return this;
		}

		/// <summary>Specifies the chunk size in bytes. Applies only if uploadMode is "instantly" or "useButtons". Requires a server that can process file chunks.</summary>
		[Generated]
		public FileUploaderBuilder ChunkSize(double value)
		{
			base.Options["chunkSize"] = value;
			return this;
		}

		/// <summary>Specifies the chunk size in bytes. Applies only if uploadMode is "instantly" or "useButtons". Requires a server that can process file chunks.</summary>
		[Generated]
		public FileUploaderBuilder ChunkSize(JS value)
		{
			base.Options["chunkSize"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FileUploaderBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FileUploaderBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileUploaderBuilder ElementAttr(string attributeName, object value)
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
		public FileUploaderBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileUploaderBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FileUploaderBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FileUploaderBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FileUploaderBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileUploaderBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileUploaderBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FileUploaderBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FileUploaderBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FileUploaderBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FileUploaderBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FileUploaderBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The text displayed when the extension of the file being uploaded is not an allowed file extension.</summary>
		[Generated]
		public FileUploaderBuilder InvalidFileExtensionMessage(string value)
		{
			base.Options["invalidFileExtensionMessage"] = value;
			return this;
		}

		/// <summary>The text displayed when the extension of the file being uploaded is not an allowed file extension.</summary>
		[Generated]
		public FileUploaderBuilder InvalidFileExtensionMessage(JS value)
		{
			base.Options["invalidFileExtensionMessage"] = value;
			return this;
		}

		/// <summary>The text displayed when the size of the file being uploaded is greater than the maxFileSize.</summary>
		[Generated]
		public FileUploaderBuilder InvalidMaxFileSizeMessage(string value)
		{
			base.Options["invalidMaxFileSizeMessage"] = value;
			return this;
		}

		/// <summary>The text displayed when the size of the file being uploaded is greater than the maxFileSize.</summary>
		[Generated]
		public FileUploaderBuilder InvalidMaxFileSizeMessage(JS value)
		{
			base.Options["invalidMaxFileSizeMessage"] = value;
			return this;
		}

		/// <summary>The text displayed when the size of the file being uploaded is less than the minFileSize.</summary>
		[Generated]
		public FileUploaderBuilder InvalidMinFileSizeMessage(string value)
		{
			base.Options["invalidMinFileSizeMessage"] = value;
			return this;
		}

		/// <summary>The text displayed when the size of the file being uploaded is less than the minFileSize.</summary>
		[Generated]
		public FileUploaderBuilder InvalidMinFileSizeMessage(JS value)
		{
			base.Options["invalidMinFileSizeMessage"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public FileUploaderBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public FileUploaderBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed on the area to which an end-user can drop a file.</summary>
		[Generated]
		public FileUploaderBuilder LabelText(string value)
		{
			base.Options["labelText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed on the area to which an end-user can drop a file.</summary>
		[Generated]
		public FileUploaderBuilder LabelText(JS value)
		{
			base.Options["labelText"] = value;
			return this;
		}

		/// <summary>Specifies the maximum file size (in bytes) allowed for uploading. Applies only if uploadMode is "instantly" or "useButtons".</summary>
		[Generated]
		public FileUploaderBuilder MaxFileSize(double value)
		{
			base.Options["maxFileSize"] = value;
			return this;
		}

		/// <summary>Specifies the maximum file size (in bytes) allowed for uploading. Applies only if uploadMode is "instantly" or "useButtons".</summary>
		[Generated]
		public FileUploaderBuilder MaxFileSize(JS value)
		{
			base.Options["maxFileSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimum file size (in bytes) allowed for uploading. Applies only if uploadMode is "instantly" or "useButtons".</summary>
		[Generated]
		public FileUploaderBuilder MinFileSize(double value)
		{
			base.Options["minFileSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimum file size (in bytes) allowed for uploading. Applies only if uploadMode is "instantly" or "useButtons".</summary>
		[Generated]
		public FileUploaderBuilder MinFileSize(JS value)
		{
			base.Options["minFileSize"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget enables an end-user to select a single file or multiple files.</summary>
		[Generated]
		public FileUploaderBuilder Multiple(bool value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget enables an end-user to select a single file or multiple files.</summary>
		[Generated]
		public FileUploaderBuilder Multiple(JS value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>Specifies the value passed to the name attribute of the underlying input element. Required to access uploaded files on the server.</summary>
		[Generated]
		public FileUploaderBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the value passed to the name attribute of the underlying input element. Required to access uploaded files on the server.</summary>
		[Generated]
		public FileUploaderBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FileUploaderBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FileUploaderBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FileUploaderBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FileUploaderBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FileUploaderBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FileUploaderBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FileUploaderBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FileUploaderBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a file segment is uploaded.</summary>
		[Generated]
		public FileUploaderBuilder OnProgress(string jsFunc)
		{
			AssignJS("onProgress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a file segment is uploaded.</summary>
		[Generated]
		public FileUploaderBuilder OnProgress(RazorBlock jsFunc)
		{
			return OnProgress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the file upload is aborted.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadAborted(string jsFunc)
		{
			AssignJS("onUploadAborted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the file upload is aborted.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadAborted(RazorBlock jsFunc)
		{
			return OnUploadAborted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a file is successfully uploaded.</summary>
		[Generated]
		public FileUploaderBuilder OnUploaded(string jsFunc)
		{
			AssignJS("onUploaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a file is successfully uploaded.</summary>
		[Generated]
		public FileUploaderBuilder OnUploaded(RazorBlock jsFunc)
		{
			return OnUploaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs during the file upload.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadError(string jsFunc)
		{
			AssignJS("onUploadError", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs during the file upload.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadError(RazorBlock jsFunc)
		{
			return OnUploadError(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the file upload is started.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadStarted(string jsFunc)
		{
			AssignJS("onUploadStarted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the file upload is started.</summary>
		[Generated]
		public FileUploaderBuilder OnUploadStarted(RazorBlock jsFunc)
		{
			return OnUploadStarted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when one or several files are added to or removed from the selection.</summary>
		[Generated]
		public FileUploaderBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when one or several files are added to or removed from the selection.</summary>
		[Generated]
		public FileUploaderBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Gets the current progress in percentages.</summary>
		[Generated]
		public FileUploaderBuilder Progress(double value)
		{
			base.Options["progress"] = value;
			return this;
		}

		/// <summary>Gets the current progress in percentages.</summary>
		[Generated]
		public FileUploaderBuilder Progress(JS value)
		{
			base.Options["progress"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public FileUploaderBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public FileUploaderBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>The message displayed by the widget when it is ready to upload the specified files.</summary>
		[Generated]
		public FileUploaderBuilder ReadyToUploadMessage(string value)
		{
			base.Options["readyToUploadMessage"] = value;
			return this;
		}

		/// <summary>The message displayed by the widget when it is ready to upload the specified files.</summary>
		[Generated]
		public FileUploaderBuilder ReadyToUploadMessage(JS value)
		{
			base.Options["readyToUploadMessage"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FileUploaderBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FileUploaderBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>The text displayed on the button that opens the file browser.</summary>
		[Generated]
		public FileUploaderBuilder SelectButtonText(string value)
		{
			base.Options["selectButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the button that opens the file browser.</summary>
		[Generated]
		public FileUploaderBuilder SelectButtonText(JS value)
		{
			base.Options["selectButtonText"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the list of selected files.</summary>
		[Generated]
		public FileUploaderBuilder ShowFileList(bool value)
		{
			base.Options["showFileList"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the list of selected files.</summary>
		[Generated]
		public FileUploaderBuilder ShowFileList(JS value)
		{
			base.Options["showFileList"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FileUploaderBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FileUploaderBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>The text displayed on the button that starts uploading.</summary>
		[Generated]
		public FileUploaderBuilder UploadButtonText(string value)
		{
			base.Options["uploadButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the button that starts uploading.</summary>
		[Generated]
		public FileUploaderBuilder UploadButtonText(JS value)
		{
			base.Options["uploadButtonText"] = value;
			return this;
		}

		/// <summary>A function that uploads a file in chunks.</summary>
		[Generated]
		public FileUploaderBuilder UploadChunk(string jsFunc)
		{
			AssignJS("uploadChunk", jsFunc);
			return this;
		}

		/// <summary>A function that uploads a file in chunks.</summary>
		[Generated]
		public FileUploaderBuilder UploadChunk(RazorBlock jsFunc)
		{
			return UploadChunk(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>The message displayed by the widget when uploading is finished.</summary>
		[Generated]
		public FileUploaderBuilder UploadedMessage(string value)
		{
			base.Options["uploadedMessage"] = value;
			return this;
		}

		/// <summary>The message displayed by the widget when uploading is finished.</summary>
		[Generated]
		public FileUploaderBuilder UploadedMessage(JS value)
		{
			base.Options["uploadedMessage"] = value;
			return this;
		}

		/// <summary>The message displayed by the widget on uploading failure.</summary>
		[Generated]
		public FileUploaderBuilder UploadFailedMessage(string value)
		{
			base.Options["uploadFailedMessage"] = value;
			return this;
		}

		/// <summary>The message displayed by the widget on uploading failure.</summary>
		[Generated]
		public FileUploaderBuilder UploadFailedMessage(JS value)
		{
			base.Options["uploadFailedMessage"] = value;
			return this;
		}

		/// <summary>A function that uploads a file.</summary>
		[Generated]
		public FileUploaderBuilder UploadFile(string jsFunc)
		{
			AssignJS("uploadFile", jsFunc);
			return this;
		}

		/// <summary>A function that uploads a file.</summary>
		[Generated]
		public FileUploaderBuilder UploadFile(RazorBlock jsFunc)
		{
			return UploadFile(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies headers for the upload request.</summary>
		[Generated]
		public FileUploaderBuilder UploadHeaders(object value)
		{
			base.Options["uploadHeaders"] = value;
			return this;
		}

		/// <summary>Specifies the method for the upload request.</summary>
		[Generated]
		public FileUploaderBuilder UploadMethod(UploadHttpMethod value)
		{
			base.Options["uploadMethod"] = value;
			return this;
		}

		/// <summary>Specifies how the widget uploads files.</summary>
		[Generated]
		public FileUploaderBuilder UploadMode(FileUploadMode value)
		{
			base.Options["uploadMode"] = value;
			return this;
		}

		/// <summary>Specifies a target Url for the upload request.</summary>
		[Generated]
		public FileUploaderBuilder UploadUrl(string value)
		{
			base.Options["uploadUrl"] = value;
			return this;
		}

		/// <summary>Specifies a target Url for the upload request.</summary>
		[Generated]
		public FileUploaderBuilder UploadUrl(JS value)
		{
			base.Options["uploadUrl"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public FileUploaderBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public FileUploaderBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public FileUploaderBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public FileUploaderBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies a File instance representing the selected file. Read-only when uploadMode is "useForm".</summary>
		[Generated]
		public FileUploaderBuilder Value(IEnumerable value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies a File instance representing the selected file. Read-only when uploadMode is "useForm".</summary>
		[Generated]
		public FileUploaderBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FileUploaderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FileUploaderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileUploaderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileUploaderBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FileUploaderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
