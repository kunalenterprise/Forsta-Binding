using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/class[@name='a']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/a", DoNotGenerateAcw=true)]
	public sealed partial class SyncA : global::Com.Confirmit.Mobilesdk.Utils.ServiceLocator, global::Com.Confirmit.Mobilesdk.Sync.ISyncModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/a", typeof (SyncA));

		internal static new IntPtr class_ref {
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

		internal SyncA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/class[@name='a']/constructor[@name='a' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/class[@name='a']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/confirmit/mobilesdk/sync/request/ApiRequestProvider;", "")]
			get {
				const string __id = "getRequest.()Lcom/confirmit/mobilesdk/sync/request/ApiRequestProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/class[@name='a']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.confirmit.mobilesdk.ConfirmitSDK.Setup']]"
		[Register ("initialize", "(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V", "")]
		public unsafe void Initialize (global::Android.App.Application p0, global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup p1)
		{
			const string __id = "initialize.(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
