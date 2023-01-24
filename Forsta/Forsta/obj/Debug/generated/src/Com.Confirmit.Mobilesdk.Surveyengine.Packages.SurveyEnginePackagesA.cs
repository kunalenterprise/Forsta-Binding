using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Packages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/packages/a", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEnginePackagesA : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/packages/a", typeof (SurveyEnginePackagesA));

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

		internal SurveyEnginePackagesA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/constructor[@name='a' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveyEnginePackagesA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/constructor[@name='a' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;com.confirmit.mobilesdk.surveyengine.packages.b&gt;'] and parameter[7][@type='com.confirmit.mobilesdk.surveyengine.n'] and parameter[8][@type='com.confirmit.mobilesdk.surveyengine.l'] and parameter[9][@type='com.confirmit.mobilesdk.surveyengine.m']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;IILjava/util/List;Lcom/confirmit/mobilesdk/surveyengine/n;Lcom/confirmit/mobilesdk/surveyengine/l;Lcom/confirmit/mobilesdk/surveyengine/m;)V", "")]
		public unsafe SurveyEnginePackagesA (int p0, string p1, string p2, int p3, int p4, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesB> p5, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineN p6, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineL p7, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineM p8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;IILjava/util/List;Lcom/confirmit/mobilesdk/surveyengine/n;Lcom/confirmit/mobilesdk/surveyengine/l;Lcom/confirmit/mobilesdk/surveyengine/m;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesB>.ToLocalJniHandle (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				__args [8] = new JniArgumentValue ((p8 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p8).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p5);
				global::System.GC.KeepAlive (p6);
				global::System.GC.KeepAlive (p7);
				global::System.GC.KeepAlive (p8);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/constructor[@name='a' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List'] and parameter[7][@type='com.confirmit.mobilesdk.surveyengine.n'] and parameter[8][@type='com.confirmit.mobilesdk.surveyengine.l'] and parameter[9][@type='com.confirmit.mobilesdk.surveyengine.m'] and parameter[10][@type='int']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;IILjava/util/List;Lcom/confirmit/mobilesdk/surveyengine/n;Lcom/confirmit/mobilesdk/surveyengine/l;Lcom/confirmit/mobilesdk/surveyengine/m;I)V", "")]
		public unsafe SurveyEnginePackagesA (int p0, string p1, string p2, int p3, int p4, global::System.Collections.IList p5, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineN p6, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineL p7, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineM p8, int p9) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;IILjava/util/List;Lcom/confirmit/mobilesdk/surveyengine/n;Lcom/confirmit/mobilesdk/surveyengine/l;Lcom/confirmit/mobilesdk/surveyengine/m;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList.ToLocalJniHandle (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				__args [8] = new JniArgumentValue ((p8 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p8).Handle);
				__args [9] = new JniArgumentValue (p9);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p5);
				global::System.GC.KeepAlive (p6);
				global::System.GC.KeepAlive (p7);
				global::System.GC.KeepAlive (p8);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()I", "")]
		public unsafe int B ()
		{
			const string __id = "b.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public unsafe string C ()
		{
			const string __id = "c.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/confirmit/mobilesdk/surveyengine/l;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineL D ()
		{
			const string __id = "d.()Lcom/confirmit/mobilesdk/surveyengine/l;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/confirmit/mobilesdk/surveyengine/m;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineM E ()
		{
			const string __id = "e.()Lcom/confirmit/mobilesdk/surveyengine/m;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineM> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Lcom/confirmit/mobilesdk/surveyengine/n;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineN F ()
		{
			const string __id = "f.()Lcom/confirmit/mobilesdk/surveyengine/n;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineN> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "")]
		public unsafe string G ()
		{
			const string __id = "g.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()I", "")]
		public unsafe int H ()
		{
			const string __id = "h.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages']/class[@name='a']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage> I ()
		{
			const string __id = "i.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
