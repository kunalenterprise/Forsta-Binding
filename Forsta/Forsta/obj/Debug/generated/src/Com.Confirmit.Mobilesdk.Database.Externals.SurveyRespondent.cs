using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Externals {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/externals/SurveyRespondent", DoNotGenerateAcw=true)]
	public sealed partial class SurveyRespondent : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/externals/SurveyRespondent", typeof (SurveyRespondent));

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

		internal SurveyRespondent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/constructor[@name='SurveyRespondent' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.u'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.v'] and parameter[5][@type='java.util.Date'] and parameter[6][@type='java.util.Date'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/surveyengine/u;Lcom/confirmit/mobilesdk/surveyengine/v;Ljava/util/Date;Ljava/util/Date;IZ)V", "")]
		public unsafe SurveyRespondent (string p0, string p1, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineV p3, global::Java.Util.Date p4, global::Java.Util.Date p5, int p6, bool p7) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/surveyengine/u;Lcom/confirmit/mobilesdk/surveyengine/v;Ljava/util/Date;Ljava/util/Date;IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		public unsafe bool Deleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getDeleted' and count(parameter)=0]"
			[Register ("getDeleted", "()Z", "")]
			get {
				const string __id = "getDeleted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Guid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getGuid' and count(parameter)=0]"
			[Register ("getGuid", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getGuid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Date LastUploadTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getLastUploadTime' and count(parameter)=0]"
			[Register ("getLastUploadTime", "()Ljava/util/Date;", "")]
			get {
				const string __id = "getLastUploadTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Date NextUploadTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getNextUploadTime' and count(parameter)=0]"
			[Register ("getNextUploadTime", "()Ljava/util/Date;", "")]
			get {
				const string __id = "getNextUploadTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/confirmit/mobilesdk/surveyengine/u;", "")]
			get {
				const string __id = "getStatus.()Lcom/confirmit/mobilesdk/surveyengine/u;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int UploadRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getUploadRetry' and count(parameter)=0]"
			[Register ("getUploadRetry", "()I", "")]
			get {
				const string __id = "getUploadRetry.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineV UploadStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyRespondent']/method[@name='getUploadStatus' and count(parameter)=0]"
			[Register ("getUploadStatus", "()Lcom/confirmit/mobilesdk/surveyengine/v;", "")]
			get {
				const string __id = "getUploadStatus.()Lcom/confirmit/mobilesdk/surveyengine/v;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineV> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
