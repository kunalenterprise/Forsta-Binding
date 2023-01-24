using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/ValidationError", DoNotGenerateAcw=true)]
	public sealed partial class ValidationError : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='MULTI_SELECTED']"
		[Register ("MULTI_SELECTED")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError MultiSelected {
			get {
				const string __id = "MULTI_SELECTED.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='NUMBER']"
		[Register ("NUMBER")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError Number {
			get {
				const string __id = "NUMBER.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='RANGE']"
		[Register ("RANGE")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError Range {
			get {
				const string __id = "RANGE.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='REQUIRED']"
		[Register ("REQUIRED")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError Required {
			get {
				const string __id = "REQUIRED.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='SIZE']"
		[Register ("SIZE")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError Size {
			get {
				const string __id = "SIZE.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/field[@name='XSS_SAFE']"
		[Register ("XSS_SAFE")]
		public static global::Com.Confirmit.Mobilesdk.UI.ValidationError XssSafe {
			get {
				const string __id = "XSS_SAFE.Lcom/confirmit/mobilesdk/ui/ValidationError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/ValidationError", typeof (ValidationError));

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

		internal ValidationError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/ValidationError;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.ValidationError ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/ValidationError;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/ui/ValidationError;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.ValidationError[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/ui/ValidationError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.UI.ValidationError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.UI.ValidationError));
			} finally {
			}
		}

	}
}
