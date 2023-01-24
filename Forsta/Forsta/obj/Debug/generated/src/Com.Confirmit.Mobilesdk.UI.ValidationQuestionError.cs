using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationQuestionError']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/ValidationQuestionError", DoNotGenerateAcw=true)]
	public sealed partial class ValidationQuestionError : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/ValidationQuestionError", typeof (ValidationQuestionError));

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

		internal ValidationQuestionError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationQuestionError']/constructor[@name='ValidationQuestionError' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.ui.ValidationError'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/ui/ValidationError;Ljava/lang/String;)V", "")]
		public unsafe ValidationQuestionError (global::Com.Confirmit.Mobilesdk.UI.ValidationError p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/ui/ValidationError;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.ValidationError Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationQuestionError']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Lcom/confirmit/mobilesdk/ui/ValidationError;", "")]
			get {
				const string __id = "getCode.()Lcom/confirmit/mobilesdk/ui/ValidationError;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ValidationError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='ValidationQuestionError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
