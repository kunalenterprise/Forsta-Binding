using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Payloads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.payloads']/class[@name='e']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/payloads/e", DoNotGenerateAcw=true)]
	public sealed partial class SyncPayloadsE : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/payloads/e", typeof (SyncPayloadsE));

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

		internal SyncPayloadsE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.payloads']/class[@name='e']/constructor[@name='e' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[6][@type='com.confirmit.mobilesdk.sync.payloads.c'] and parameter[7][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[8][@type='int']]"
		[Register (".ctor", "(IILjava/util/Map;Ljava/util/Map;Ljava/util/Map;Lcom/confirmit/mobilesdk/sync/payloads/c;Ljava/util/List;I)V", "")]
		public unsafe SyncPayloadsE (int p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2, global::System.Collections.Generic.IDictionary<string, string> p3, global::System.Collections.Generic.IDictionary<string, string> p4, global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsC p5, global::System.Collections.Generic.IList<string> p6, int p7) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/util/Map;Ljava/util/Map;Ljava/util/Map;Lcom/confirmit/mobilesdk/sync/payloads/c;Ljava/util/List;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			IntPtr native_p6 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (p7);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p6);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
				global::System.GC.KeepAlive (p6);
			}
		}

	}
}
