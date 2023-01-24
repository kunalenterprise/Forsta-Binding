using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Externals {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='ProgramUrl']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/externals/ProgramUrl", DoNotGenerateAcw=true)]
	public sealed partial class ProgramUrl : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/externals/ProgramUrl", typeof (ProgramUrl));

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

		internal ProgramUrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string CfrUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='ProgramUrl']/method[@name='getCfrUrl' and count(parameter)=0]"
			[Register ("getCfrUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCfrUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CounterUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='ProgramUrl']/method[@name='getCounterUrl' and count(parameter)=0]"
			[Register ("getCounterUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCounterUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
