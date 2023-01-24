using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/SurveySDK", DoNotGenerateAcw=true)]
	public sealed partial class SurveySDK : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Confirmit.Mobilesdk.SurveySDK Instance {
			get {
				const string __id = "INSTANCE.Lcom/confirmit/mobilesdk/SurveySDK;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.SurveySDK> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/SurveySDK", typeof (SurveySDK));

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

		internal SurveySDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> SurveyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='getSurveyList' and count(parameter)=0]"
			[Register ("getSurveyList", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSurveyList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='deleteSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteSurvey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void DeleteSurvey (string p0, string p1)
		{
			const string __id = "deleteSurvey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='downloadSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("downloadSurvey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/SurveyDownloadResult;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.SurveyDownloadResult DownloadSurvey (string p0, string p1)
		{
			const string __id = "downloadSurvey.(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/SurveyDownloadResult;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.SurveyDownloadResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='getSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSurvey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Survey GetSurvey (string p0, string p1)
		{
			const string __id = "getSurvey.(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='setScriptBridge' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.SurveyScriptBridge']]"
		[Register ("setScriptBridge", "(Lcom/confirmit/mobilesdk/SurveyScriptBridge;)V", "")]
		public unsafe void SetScriptBridge (global::Com.Confirmit.Mobilesdk.ISurveyScriptBridge p0)
		{
			const string __id = "setScriptBridge.(Lcom/confirmit/mobilesdk/SurveyScriptBridge;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveySDK']/method[@name='setUniqueIdProvider' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.UniqueIdProvider']]"
		[Register ("setUniqueIdProvider", "(Lcom/confirmit/mobilesdk/UniqueIdProvider;)V", "")]
		public unsafe void SetUniqueIdProvider (global::Com.Confirmit.Mobilesdk.IUniqueIdProvider p0)
		{
			const string __id = "setUniqueIdProvider.(Lcom/confirmit/mobilesdk/UniqueIdProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
