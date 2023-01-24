using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker")]
	public partial interface IRoomProgramPrefDao : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.d']]"
		[Register ("delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V", "GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker, Forsta")]
		void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/d;", "GetGet_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref Get (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']/method[@name='getAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAll", "(Ljava/lang/String;)Ljava/util/List;", "GetGetAll_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> GetAll (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.d']]"
		[Register ("insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V", "GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker, Forsta")]
		void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomProgramPrefDao']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.d']]"
		[Register ("replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V", "GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDaoInvoker, Forsta")]
		void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao", DoNotGenerateAcw=true)]
	internal partial class IRoomProgramPrefDaoInvoker : global::Java.Lang.Object, IRoomProgramPrefDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao", typeof (IRoomProgramPrefDaoInvoker));

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

		public static IRoomProgramPrefDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomProgramPrefDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomProgramPrefDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomProgramPrefDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler ()
		{
			if (cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == null)
				cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_);
			return cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		}

		static void n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		public unsafe void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0)
		{
			if (id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == IntPtr.Zero)
				id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_d_, __args);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Get_Ljava_lang_String_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref Get (string p0, string p1)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/d;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAll_Ljava_lang_String_Handler ()
		{
			if (cb_getAll_Ljava_lang_String_ == null)
				cb_getAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAll_Ljava_lang_String_);
			return cb_getAll_Ljava_lang_String_;
		}

		static IntPtr n_GetAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref>.ToLocalJniHandle (__this.GetAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAll_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> GetAll (string p0)
		{
			if (id_getAll_Ljava_lang_String_ == IntPtr.Zero)
				id_getAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAll", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
#pragma warning disable 0169
		static Delegate GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler ()
		{
			if (cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == null)
				cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_);
			return cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		}

		static void n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		public unsafe void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0)
		{
			if (id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == IntPtr.Zero)
				id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_d_, __args);
		}

		static Delegate cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
#pragma warning disable 0169
		static Delegate GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_Handler ()
		{
			if (cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == null)
				cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_);
			return cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		}

		static void n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Replace (p0);
		}
#pragma warning restore 0169

		IntPtr id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_;
		public unsafe void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref p0)
		{
			if (id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ == IntPtr.Zero)
				id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/d;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_d_, __args);
		}

	}
}
