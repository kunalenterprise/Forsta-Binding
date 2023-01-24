using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveyDownloadResult']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/SurveyDownloadResult", DoNotGenerateAcw=true)]
	public sealed partial class SurveyDownloadResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/SurveyDownloadResult", typeof (SurveyDownloadResult));

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

		internal SurveyDownloadResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveyDownloadResult']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "")]
			get {
				const string __id = "getException.()Ljava/lang/Exception;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='SurveyDownloadResult']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Z", "")]
			get {
				const string __id = "getResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
