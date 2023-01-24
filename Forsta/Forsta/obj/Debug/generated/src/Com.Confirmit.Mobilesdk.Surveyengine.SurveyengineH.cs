using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/h", DoNotGenerateAcw=true)]
	public sealed partial class SurveyengineH : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='a']"
		[Register ("a")]
		public static IList<Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> A {
			get {
				const string __id = "a.[Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='ALLOW_BACK_BUTTON']"
		[Register ("ALLOW_BACK_BUTTON")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH AllowBackButton {
			get {
				const string __id = "ALLOW_BACK_BUTTON.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='MULTIPLE']"
		[Register ("MULTIPLE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH Multiple {
			get {
				const string __id = "MULTIPLE.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='NO_BACK_BUTTON']"
		[Register ("NO_BACK_BUTTON")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH NoBackButton {
			get {
				const string __id = "NO_BACK_BUTTON.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='PROGRESSBAR_BEGIN']"
		[Register ("PROGRESSBAR_BEGIN")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH ProgressbarBegin {
			get {
				const string __id = "PROGRESSBAR_BEGIN.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='PROGRESSBAR_END']"
		[Register ("PROGRESSBAR_END")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH ProgressbarEnd {
			get {
				const string __id = "PROGRESSBAR_END.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/field[@name='SINGLE']"
		[Register ("SINGLE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH Single {
			get {
				const string __id = "SINGLE.Lcom/confirmit/mobilesdk/surveyengine/h;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/h", typeof (SurveyengineH));

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

		internal SurveyengineH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/constructor[@name='h' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe SurveyengineH (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/h;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/h;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='h']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/surveyengine/h;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/surveyengine/h;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH));
			} finally {
			}
		}

	}
}
