using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/domain/k", DoNotGenerateAcw=true)]
	public sealed partial class ProvidersRoomDomainK : global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainA, global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/domain/k", typeof (ProvidersRoomDomainK));

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

		internal ProvidersRoomDomainK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']/constructor[@name='k' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.b']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/database/providers/room/b;)V", "")]
		public unsafe ProvidersRoomDomainK (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.ProvidersRoomB p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/database/providers/room/b;)V";

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

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> ServerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']/method[@name='getServerList' and count(parameter)=0]"
			[Register ("getServerList", "()Ljava/util/List;", "")]
			get {
				const string __id = "getServerList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server CreateOrUpdate (string p0, string p1, string p2, string p3)
		{
			const string __id = "createOrUpdate.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']/method[@name='getServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServer", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string p0)
		{
			const string __id = "getServer.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='k']/method[@name='getServer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getServer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string p0, string p1, string p2)
		{
			const string __id = "getServer.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
