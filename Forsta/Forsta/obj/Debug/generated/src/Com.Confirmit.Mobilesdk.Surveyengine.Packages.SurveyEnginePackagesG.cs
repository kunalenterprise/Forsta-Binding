using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Packages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/packages/g", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEnginePackagesG : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/packages/g", typeof (SurveyEnginePackagesG));

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

		internal SurveyEnginePackagesG (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']/constructor[@name='g' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveyEnginePackagesG () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']/constructor[@name='g' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.confirmit.mobilesdk.surveyengine.packages.d&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.Integer, com.confirmit.mobilesdk.surveyengine.packages.f&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/Map;)V", "")]
		public unsafe SurveyEnginePackagesG (global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesD> p0, global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesF> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesD>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesF>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']/constructor[@name='g' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/Map;I)V", "")]
		public unsafe SurveyEnginePackagesG (global::System.Collections.IList p0, global::System.Collections.IDictionary p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/Map;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesD> A ()
		{
			const string __id = "a.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesD>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='g']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/confirmit/mobilesdk/surveyengine/packages/f;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesF A (int p0)
		{
			const string __id = "a.(I)Lcom/confirmit/mobilesdk/surveyengine/packages/f;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
