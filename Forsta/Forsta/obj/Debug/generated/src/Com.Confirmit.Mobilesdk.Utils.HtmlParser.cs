using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/utils/HtmlParser", DoNotGenerateAcw=true)]
	public sealed partial class HtmlParser : global::Java.Lang.Object, global::Android.Text.Html.ITagHandler, global::Org.Xml.Sax.IContentHandler {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Utils.HtmlParser.ITagHandler A {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/utils/HtmlParser$TagHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Utils.HtmlParser.ITagHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/utils/HtmlParser$TagHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/field[@name='b']"
		[Register ("b")]
		public global::Org.Xml.Sax.IContentHandler B {
			get {
				const string __id = "b.Lorg/xml/sax/ContentHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Xml.Sax.IContentHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lorg/xml/sax/ContentHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/field[@name='c']"
		[Register ("c")]
		public global::Android.Text.IEditable C {
			get {
				const string __id = "c.Landroid/text/Editable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Landroid/text/Editable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/field[@name='d']"
		[Register ("d")]
		public global::Java.Util.ArrayDeque D {
			get {
				const string __id = "d.Ljava/util/ArrayDeque;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.ArrayDeque> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/util/ArrayDeque;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/interface[@name='HtmlParser.TagHandler']"
		[Register ("com/confirmit/mobilesdk/utils/HtmlParser$TagHandler", "", "Com.Confirmit.Mobilesdk.Utils.HtmlParser/ITagHandlerInvoker")]
		public partial interface ITagHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/interface[@name='HtmlParser.TagHandler']/method[@name='handleTag' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.text.Editable'] and parameter[4][@type='org.xml.sax.Attributes']]"
			[Register ("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/Attributes;)Z", "GetHandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_Handler:Com.Confirmit.Mobilesdk.Utils.HtmlParser/ITagHandlerInvoker, Forsta")]
			bool HandleTag (bool opening, string tag, global::Android.Text.IEditable output, global::Org.Xml.Sax.IAttributes attributes);

		}

		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/utils/HtmlParser$TagHandler", DoNotGenerateAcw=true)]
		internal partial class ITagHandlerInvoker : global::Java.Lang.Object, ITagHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/utils/HtmlParser$TagHandler", typeof (ITagHandlerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ITagHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITagHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.utils.HtmlParser.TagHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITagHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_;
#pragma warning disable 0169
			static Delegate GetHandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_Handler ()
			{
				if (cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_ == null)
					cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLLL_Z) n_HandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_);
				return cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_;
			}

			static bool n_HandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_ (IntPtr jnienv, IntPtr native__this, bool opening, IntPtr native_tag, IntPtr native_output, IntPtr native_attributes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Utils.HtmlParser.ITagHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var output = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_output, JniHandleOwnership.DoNotTransfer);
				var attributes = (global::Org.Xml.Sax.IAttributes)global::Java.Lang.Object.GetObject<global::Org.Xml.Sax.IAttributes> (native_attributes, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleTag (opening, tag, output, attributes);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_;
			public unsafe bool HandleTag (bool opening, string tag, global::Android.Text.IEditable output, global::Org.Xml.Sax.IAttributes attributes)
			{
				if (id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_ == IntPtr.Zero)
					id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_ = JNIEnv.GetMethodID (class_ref, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/Attributes;)Z");
				IntPtr native_tag = JNIEnv.NewString ((string)tag);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (opening);
				__args [1] = new JValue (native_tag);
				__args [2] = new JValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [3] = new JValue ((attributes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attributes).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_Attributes_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/utils/HtmlParser", typeof (HtmlParser));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal HtmlParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/constructor[@name='HtmlParser' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.utils.HtmlParser.TagHandler']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/utils/HtmlParser$TagHandler;)V", "")]
		public unsafe HtmlParser (global::Com.Confirmit.Mobilesdk.Utils.HtmlParser.ITagHandler p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/utils/HtmlParser$TagHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='characters' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("characters", "([CII)V", "")]
		public unsafe void Characters (char[] p0, int p1, int p2)
		{
			const string __id = "characters.([CII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='endDocument' and count(parameter)=0]"
		[Register ("endDocument", "()V", "")]
		public unsafe void EndDocument ()
		{
			const string __id = "endDocument.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='endElement' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void EndElement (string p0, string p1, string p2)
		{
			const string __id = "endElement.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='endPrefixMapping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("endPrefixMapping", "(Ljava/lang/String;)V", "")]
		public unsafe void EndPrefixMapping (string p0)
		{
			const string __id = "endPrefixMapping.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='handleTag' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.text.Editable'] and parameter[4][@type='org.xml.sax.XMLReader']]"
		[Register ("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", "")]
		public unsafe void HandleTag (bool p0, string p1, global::Android.Text.IEditable p2, global::Org.Xml.Sax.IXMLReader p3)
		{
			const string __id = "handleTag.(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='ignorableWhitespace' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ignorableWhitespace", "([CII)V", "")]
		public unsafe void IgnorableWhitespace (char[] p0, int p1, int p2)
		{
			const string __id = "ignorableWhitespace.([CII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='processingInstruction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ProcessingInstruction (string p0, string p1)
		{
			const string __id = "processingInstruction.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='setDocumentLocator' and count(parameter)=1 and parameter[1][@type='org.xml.sax.Locator']]"
		[Register ("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", "")]
		public unsafe void SetDocumentLocator (global::Org.Xml.Sax.ILocator p0)
		{
			const string __id = "setDocumentLocator.(Lorg/xml/sax/Locator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='skippedEntity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("skippedEntity", "(Ljava/lang/String;)V", "")]
		public unsafe void SkippedEntity (string p0)
		{
			const string __id = "skippedEntity.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='startDocument' and count(parameter)=0]"
		[Register ("startDocument", "()V", "")]
		public unsafe void StartDocument ()
		{
			const string __id = "startDocument.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='startElement' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.xml.sax.Attributes']]"
		[Register ("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V", "")]
		public unsafe void StartElement (string p0, string p1, string p2, global::Org.Xml.Sax.IAttributes p3)
		{
			const string __id = "startElement.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='HtmlParser']/method[@name='startPrefixMapping' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void StartPrefixMapping (string p0, string p1)
		{
			const string __id = "startPrefixMapping.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
