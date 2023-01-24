using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Managers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.managers']/class[@name='h']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/managers/h", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEngineManagersH : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.managers']/class[@name='h']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineS A {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/s;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/s;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.managers']/class[@name='h']/field[@name='b']"
		[Register ("b")]
		public string B {
			get {
				const string __id = "b.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/managers/h", typeof (SurveyEngineManagersH));

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

		internal SurveyEngineManagersH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.managers']/class[@name='h']/constructor[@name='h' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.s'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.constraints.a'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/s;Lcom/confirmit/mobilesdk/surveyengine/packages/question/constraints/a;Ljava/lang/String;)V", "")]
		public unsafe SurveyEngineManagersH (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineS p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/s;Lcom/confirmit/mobilesdk/surveyengine/packages/question/constraints/a;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
