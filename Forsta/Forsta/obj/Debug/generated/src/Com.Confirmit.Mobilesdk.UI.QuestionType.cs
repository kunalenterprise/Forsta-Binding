using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/QuestionType", DoNotGenerateAcw=true)]
	public sealed partial class QuestionType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType Info {
			get {
				const string __id = "INFO.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='MULTI']"
		[Register ("MULTI")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType Multi {
			get {
				const string __id = "MULTI.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='NOT_SUPPORTED']"
		[Register ("NOT_SUPPORTED")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType NotSupported {
			get {
				const string __id = "NOT_SUPPORTED.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType Numeric {
			get {
				const string __id = "NUMERIC.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='SINGLE']"
		[Register ("SINGLE")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType Single {
			get {
				const string __id = "SINGLE.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Confirmit.Mobilesdk.UI.QuestionType Text {
			get {
				const string __id = "TEXT.Lcom/confirmit/mobilesdk/ui/QuestionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/QuestionType", typeof (QuestionType));

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

		internal QuestionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/QuestionType;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.QuestionType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/QuestionType;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='QuestionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/ui/QuestionType;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.QuestionType[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/ui/QuestionType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.UI.QuestionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.UI.QuestionType));
			} finally {
			}
		}

	}
}
