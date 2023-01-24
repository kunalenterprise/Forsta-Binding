using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Request.Defaults {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/request/defaults/e", DoNotGenerateAcw=true)]
	public sealed partial class SyncRequestDefaultsE : global::Javax.Net.Ssl.SSLSocketFactory {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/field[@name='a']"
		[Register ("a")]
		public global::Javax.Net.Ssl.SSLSocketFactory A {
			get {
				const string __id = "a.Ljavax/net/ssl/SSLSocketFactory;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljavax/net/ssl/SSLSocketFactory;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/request/defaults/e", typeof (SyncRequestDefaultsE));

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

		internal SyncRequestDefaultsE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/constructor[@name='e' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register (".ctor", "(Ljavax/net/ssl/SSLSocketFactory;)V", "")]
		public unsafe SyncRequestDefaultsE (global::Javax.Net.Ssl.SSLSocketFactory p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljavax/net/ssl/SSLSocketFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", "")]
		public override unsafe global::Java.Net.Socket CreateSocket (string p0, int p1)
		{
			const string __id = "createSocket.(Ljava/lang/String;I)Ljava/net/Socket;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", "")]
		public override unsafe global::Java.Net.Socket CreateSocket (string p0, int p1, global::Java.Net.InetAddress p2, int p3)
		{
			const string __id = "createSocket.(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", "")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.InetAddress p0, int p1)
		{
			const string __id = "createSocket.(Ljava/net/InetAddress;I)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", "")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.InetAddress p0, int p1, global::Java.Net.InetAddress p2, int p3)
		{
			const string __id = "createSocket.(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", "")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.Socket p0, string p1, int p2, bool p3)
		{
			const string __id = "createSocket.(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='getDefaultCipherSuites' and count(parameter)=0]"
		[Register ("getDefaultCipherSuites", "()[Ljava/lang/String;", "")]
		public override unsafe string[] GetDefaultCipherSuites ()
		{
			const string __id = "getDefaultCipherSuites.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request.defaults']/class[@name='e']/method[@name='getSupportedCipherSuites' and count(parameter)=0]"
		[Register ("getSupportedCipherSuites", "()[Ljava/lang/String;", "")]
		public override unsafe string[] GetSupportedCipherSuites ()
		{
			const string __id = "getSupportedCipherSuites.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
