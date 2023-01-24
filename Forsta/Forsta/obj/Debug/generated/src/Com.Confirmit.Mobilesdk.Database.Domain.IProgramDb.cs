using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/ProgramDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker")]
	public partial interface IProgramDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']/method[@name='createOrUpdate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='long'] and parameter[5][@type='com.confirmit.mobilesdk.database.externals.ProgramUrl']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;ZJLcom/confirmit/mobilesdk/database/externals/ProgramUrl;)V", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker, Forsta")]
		void CreateOrUpdate (string serverId, string programKey, bool started, long publishedVersion, global::Com.Confirmit.Mobilesdk.Database.Externals.ProgramUrl programUrl);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']/method[@name='deleteProgram' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteProgram", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteProgram_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker, Forsta")]
		void DeleteProgram (string serverId, string programKey);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']/method[@name='getProgram' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getProgram", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Program;", "GetGetProgram_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.Program GetProgram (string serverId, string programKey);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']/method[@name='getPrograms' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPrograms", "(Ljava/lang/String;)Ljava/util/List;", "GetGetPrograms_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Program> GetPrograms (string serverId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ProgramDb']/method[@name='updateProgram' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("updateProgram", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetUpdateProgram_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.Confirmit.Mobilesdk.Database.Domain.IProgramDbInvoker, Forsta")]
		void UpdateProgram (string serverId, string programKey, bool started);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/ProgramDb", DoNotGenerateAcw=true)]
	internal partial class IProgramDbInvoker : global::Java.Lang.Object, IProgramDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/ProgramDb", typeof (IProgramDbInvoker));

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

		public static IProgramDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgramDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.ProgramDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgramDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_Handler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_ == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZJL_V) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_;
		}

		static void n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey, bool started, long publishedVersion, IntPtr native_programUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			var programUrl = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.ProgramUrl> (native_programUrl, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdate (serverId, programKey, started, publishedVersion, programUrl);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_;
		public unsafe void CreateOrUpdate (string serverId, string programKey, bool started, long publishedVersion, global::Com.Confirmit.Mobilesdk.Database.Externals.ProgramUrl programUrl)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_ == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_ = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;ZJLcom/confirmit/mobilesdk/database/externals/ProgramUrl;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			__args [2] = new JValue (started);
			__args [3] = new JValue (publishedVersion);
			__args [4] = new JValue ((programUrl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) programUrl).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ZJLcom_confirmit_mobilesdk_database_externals_ProgramUrl_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
		}

		static Delegate cb_deleteProgram_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteProgram_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteProgram_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteProgram_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeleteProgram_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteProgram_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteProgram_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			__this.DeleteProgram (serverId, programKey);
		}
#pragma warning restore 0169

		IntPtr id_deleteProgram_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeleteProgram (string serverId, string programKey)
		{
			if (id_deleteProgram_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteProgram_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteProgram", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteProgram_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
		}

		static Delegate cb_getProgram_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProgram_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getProgram_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getProgram_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetProgram_Ljava_lang_String_Ljava_lang_String_);
			return cb_getProgram_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetProgram_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProgram (serverId, programKey));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProgram_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Program GetProgram (string serverId, string programKey)
		{
			if (id_getProgram_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getProgram_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProgram", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Program;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Program> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgram_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
			return __ret;
		}

		static Delegate cb_getPrograms_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPrograms_Ljava_lang_String_Handler ()
		{
			if (cb_getPrograms_Ljava_lang_String_ == null)
				cb_getPrograms_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPrograms_Ljava_lang_String_);
			return cb_getPrograms_Ljava_lang_String_;
		}

		static IntPtr n_GetPrograms_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Program>.ToLocalJniHandle (__this.GetPrograms (serverId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPrograms_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Program> GetPrograms (string serverId)
		{
			if (id_getPrograms_Ljava_lang_String_ == IntPtr.Zero)
				id_getPrograms_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPrograms", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_serverId);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Program>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrograms_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			return __ret;
		}

		static Delegate cb_updateProgram_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateProgram_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateProgram_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_updateProgram_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_UpdateProgram_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_updateProgram_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_UpdateProgram_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey, bool started)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			__this.UpdateProgram (serverId, programKey, started);
		}
#pragma warning restore 0169

		IntPtr id_updateProgram_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void UpdateProgram (string serverId, string programKey, bool started)
		{
			if (id_updateProgram_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateProgram_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateProgram", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			__args [2] = new JValue (started);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateProgram_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
		}

	}
}
