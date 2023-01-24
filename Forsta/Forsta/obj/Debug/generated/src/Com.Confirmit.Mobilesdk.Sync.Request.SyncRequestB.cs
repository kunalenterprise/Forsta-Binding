using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/class[@name='b']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/request/b", DoNotGenerateAcw=true)]
	public sealed partial class SyncRequestB : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/request/b", typeof (SyncRequestB));

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

		internal SyncRequestB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/class[@name='b']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.sync.request.ApiResponse']]"
		[Register ("a", "(Lcom/confirmit/mobilesdk/sync/request/ApiResponse;)V", "")]
		public static unsafe void A (global::Com.Confirmit.Mobilesdk.Sync.Request.IApiResponse p0)
		{
			const string __id = "a.(Lcom/confirmit/mobilesdk/sync/request/ApiResponse;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
