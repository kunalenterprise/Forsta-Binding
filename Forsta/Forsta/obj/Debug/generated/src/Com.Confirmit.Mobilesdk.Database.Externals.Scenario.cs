using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Externals {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Scenario']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/externals/Scenario", DoNotGenerateAcw=true)]
	public sealed partial class Scenario : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/externals/Scenario", typeof (Scenario));

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

		internal Scenario (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe long ScenarioId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Scenario']/method[@name='getScenarioId' and count(parameter)=0]"
			[Register ("getScenarioId", "()J", "")]
			get {
				const string __id = "getScenarioId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Script {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Scenario']/method[@name='getScript' and count(parameter)=0]"
			[Register ("getScript", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getScript.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
