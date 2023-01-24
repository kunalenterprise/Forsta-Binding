using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ServerDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/ServerDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IServerDbInvoker")]
	public partial interface IServerDb : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> ServerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ServerDb']/method[@name='getServerList' and count(parameter)=0]"
			[Register ("getServerList", "()Ljava/util/List;", "GetGetServerListHandler:Com.Confirmit.Mobilesdk.Database.Domain.IServerDbInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ServerDb']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IServerDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.Server CreateOrUpdate (string name, string host, string clientId, string clientSecret);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ServerDb']/method[@name='getServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServer", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "GetGetServer_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IServerDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string serverId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ServerDb']/method[@name='getServer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getServer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "GetGetServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IServerDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string host, string clientId, string clientSecret);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/ServerDb", DoNotGenerateAcw=true)]
	internal partial class IServerDbInvoker : global::Java.Lang.Object, IServerDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/ServerDb", typeof (IServerDbInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IServerDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServerDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.ServerDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServerDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getServerList;
#pragma warning disable 0169
		static Delegate GetGetServerListHandler ()
		{
			if (cb_getServerList == null)
				cb_getServerList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServerList);
			return cb_getServerList;
		}

		static IntPtr n_GetServerList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server>.ToLocalJniHandle (__this.ServerList);
		}
#pragma warning restore 0169

		IntPtr id_getServerList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> ServerList {
			get {
				if (id_getServerList == IntPtr.Zero)
					id_getServerList = JNIEnv.GetMethodID (class_ref, "getServerList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_host, IntPtr native_clientId, IntPtr native_clientSecret)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			var clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOrUpdate (name, host, clientId, clientSecret));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server CreateOrUpdate (string name, string host, string clientId, string clientSecret)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_host = JNIEnv.NewString ((string)host);
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_name);
			__args [1] = new JValue (native_host);
			__args [2] = new JValue (native_clientId);
			__args [3] = new JValue (native_clientSecret);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_host);
			JNIEnv.DeleteLocalRef (native_clientId);
			JNIEnv.DeleteLocalRef (native_clientSecret);
			return __ret;
		}

		static Delegate cb_getServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServer_Ljava_lang_String_Handler ()
		{
			if (cb_getServer_Ljava_lang_String_ == null)
				cb_getServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetServer_Ljava_lang_String_);
			return cb_getServer_Ljava_lang_String_;
		}

		static IntPtr n_GetServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetServer (serverId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getServer_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string serverId)
		{
			if (id_getServer_Ljava_lang_String_ == IntPtr.Zero)
				id_getServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServer", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_serverId);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			return __ret;
		}

		static Delegate cb_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_clientId, IntPtr native_clientSecret)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			var clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			var clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetServer (host, clientId, clientSecret));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string host, string clientId, string clientSecret)
		{
			if (id_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;");
			IntPtr native_host = JNIEnv.NewString ((string)host);
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_host);
			__args [1] = new JValue (native_clientId);
			__args [2] = new JValue (native_clientSecret);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_host);
			JNIEnv.DeleteLocalRef (native_clientId);
			JNIEnv.DeleteLocalRef (native_clientSecret);
			return __ret;
		}

	}
}
