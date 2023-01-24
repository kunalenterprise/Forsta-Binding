using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramPrefDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/ProgramPrefDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDbInvoker")]
	public partial interface IProgramPrefDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramPrefDb']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDbInvoker, Forsta")]
		void CreateOrUpdate (string serverId, string programKey, string key, string value);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramPrefDb']/method[@name='deletePrefs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deletePrefs", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDeletePrefs_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDbInvoker, Forsta")]
		void DeletePrefs (string serverId, string programKey);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramPrefDb']/method[@name='getPref' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getPref", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDbInvoker, Forsta")]
		string GetPref (string serverId, string programKey, string key, string defaultValue);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/ProgramPrefDb", DoNotGenerateAcw=true)]
	internal partial class IProgramPrefDbInvoker : global::Java.Lang.Object, IProgramPrefDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/ProgramPrefDb", typeof (IProgramPrefDbInvoker));

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

		public static IProgramPrefDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgramPrefDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.ProgramPrefDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgramPrefDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdate (serverId, programKey, key, value);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CreateOrUpdate (string serverId, string programKey, string key, string value)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			__args [2] = new JValue (native_key);
			__args [3] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_value);
		}

		static Delegate cb_deletePrefs_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeletePrefs_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deletePrefs_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deletePrefs_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeletePrefs_Ljava_lang_String_Ljava_lang_String_);
			return cb_deletePrefs_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeletePrefs_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			__this.DeletePrefs (serverId, programKey);
		}
#pragma warning restore 0169

		IntPtr id_deletePrefs_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeletePrefs (string serverId, string programKey)
		{
			if (id_deletePrefs_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deletePrefs_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deletePrefs", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deletePrefs_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
		}

		static Delegate cb_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey, IntPtr native_key, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPref (serverId, programKey, key, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string GetPref (string serverId, string programKey, string key, string defaultValue)
		{
			if (id_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPref", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_defaultValue = JNIEnv.NewString ((string)defaultValue);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			__args [2] = new JValue (native_key);
			__args [3] = new JValue (native_defaultValue);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPref_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_defaultValue);
			return __ret;
		}

	}
}
