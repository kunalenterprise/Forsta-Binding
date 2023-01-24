using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/utils/a", DoNotGenerateAcw=true)]
	public sealed partial class UtilsA : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.Utils.HtmlParser.ITagHandler {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='a']"
		[Register ("a")]
		public bool UtilsAObjA {
			get {
				const string __id = "a.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "a.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='b']"
		[Register ("b")]
		public int UtilsAObjB {
			get {
				const string __id = "b.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "b.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='d']"
		[Register ("d")]
		public static global::Java.Util.Regex.Pattern D {
			get {
				const string __id = "d.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/util/regex/Pattern;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='e']"
		[Register ("e")]
		public static global::Java.Util.Regex.Pattern E {
			get {
				const string __id = "e.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Ljava/util/regex/Pattern;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='f']"
		[Register ("f")]
		public static global::Java.Util.Regex.Pattern F {
			get {
				const string __id = "f.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Ljava/util/regex/Pattern;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='g']"
		[Register ("g")]
		public static global::Java.Util.Regex.Pattern G {
			get {
				const string __id = "g.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g.Ljava/util/regex/Pattern;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/field[@name='h']"
		[Register ("h")]
		public static global::Java.Util.Regex.Pattern H {
			get {
				const string __id = "h.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "h.Ljava/util/regex/Pattern;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/utils/a", typeof (UtilsA));

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

		internal UtilsA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/constructor[@name='a' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UtilsA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("a", "(Landroid/text/Editable;)V", "")]
		public unsafe void A (global::Android.Text.IEditable p0)
		{
			const string __id = "a.(Landroid/text/Editable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.text.Editable'] and parameter[2][@type='org.xml.sax.Attributes']]"
		[Register ("a", "(Landroid/text/Editable;Lorg/xml/sax/Attributes;)I", "")]
		public unsafe int A (global::Android.Text.IEditable p0, global::Org.Xml.Sax.IAttributes p1)
		{
			const string __id = "a.(Landroid/text/Editable;Lorg/xml/sax/Attributes;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.text.Editable'] and parameter[2][@type='org.xml.sax.Attributes'] and parameter[3][@type='int']]"
		[Register ("a", "(Landroid/text/Editable;Lorg/xml/sax/Attributes;I)V", "")]
		public unsafe void A (global::Android.Text.IEditable p0, global::Org.Xml.Sax.IAttributes p1, int p2)
		{
			const string __id = "a.(Landroid/text/Editable;Lorg/xml/sax/Attributes;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.xml.sax.Attributes']]"
		[Register ("a", "(Ljava/lang/String;Lorg/xml/sax/Attributes;)Ljava/lang/String;", "")]
		public unsafe string A (string p0, global::Org.Xml.Sax.IAttributes p1)
		{
			const string __id = "a.(Ljava/lang/String;Lorg/xml/sax/Attributes;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("b", "(Landroid/text/Editable;)V", "")]
		public unsafe void B (global::Android.Text.IEditable p0)
		{
			const string __id = "b.(Landroid/text/Editable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='a']/method[@name='handleTag' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.text.Editable'] and parameter[4][@type='org.xml.sax.Attributes']]"
		[Register ("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/Attributes;)Z", "")]
		public unsafe bool HandleTag (bool p0, string p1, global::Android.Text.IEditable p2, global::Org.Xml.Sax.IAttributes p3)
		{
			const string __id = "handleTag.(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/Attributes;)Z";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
