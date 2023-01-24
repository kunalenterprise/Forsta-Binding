using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomRespondentDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker")]
	public partial interface IRoomRespondentDao : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.e']]"
		[Register ("delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V", "GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/e;", "GetGet_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("get", "(Ljava/lang/String;Z)Lcom/confirmit/mobilesdk/database/providers/room/model/e;", "GetGet_Ljava_lang_String_ZHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents Get (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='getAll' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getAll", "(Z)Ljava/util/List;", "GetGetAll_ZHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetAll (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='getPending' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Date']]"
		[Register ("getPending", "(ZIIILjava/util/Date;)Ljava/util/List;", "GetGetPending_ZIIILjava_util_Date_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetPending (bool p0, int p1, int p2, int p3, global::Java.Util.Date p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='getResetInProgressEligible' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Date']]"
		[Register ("getResetInProgressEligible", "(ILjava/util/Date;)Ljava/util/List;", "GetGetResetInProgressEligible_ILjava_util_Date_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetResetInProgressEligible (int p0, global::Java.Util.Date p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.e']]"
		[Register ("insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V", "GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomRespondentDao']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.e']]"
		[Register ("update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V", "GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDaoInvoker, Forsta")]
		void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomRespondentDao", DoNotGenerateAcw=true)]
	internal partial class IRoomRespondentDaoInvoker : global::Java.Lang.Object, IRoomRespondentDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomRespondentDao", typeof (IRoomRespondentDaoInvoker));

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

		public static IRoomRespondentDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomRespondentDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomRespondentDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomRespondentDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler ()
		{
			if (cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == null)
				cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_);
			return cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		}

		static void n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		public unsafe void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0)
		{
			if (id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == IntPtr.Zero)
				id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_e_, __args);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/e;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_ZHandler ()
		{
			if (cb_get_Ljava_lang_String_Z == null)
				cb_get_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_Get_Ljava_lang_String_Z);
			return cb_get_Ljava_lang_String_Z;
		}

		static IntPtr n_Get_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Z;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents Get (string p0, bool p1)
		{
			if (id_get_Ljava_lang_String_Z == IntPtr.Zero)
				id_get_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Z)Lcom/confirmit/mobilesdk/database/providers/room/model/e;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAll_Z;
#pragma warning disable 0169
		static Delegate GetGetAll_ZHandler ()
		{
			if (cb_getAll_Z == null)
				cb_getAll_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_GetAll_Z);
			return cb_getAll_Z;
		}

		static IntPtr n_GetAll_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.ToLocalJniHandle (__this.GetAll (p0));
		}
#pragma warning restore 0169

		IntPtr id_getAll_Z;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetAll (bool p0)
		{
			if (id_getAll_Z == IntPtr.Zero)
				id_getAll_Z = JNIEnv.GetMethodID (class_ref, "getAll", "(Z)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getPending_ZIIILjava_util_Date_;
#pragma warning disable 0169
		static Delegate GetGetPending_ZIIILjava_util_Date_Handler ()
		{
			if (cb_getPending_ZIIILjava_util_Date_ == null)
				cb_getPending_ZIIILjava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIIIL_L) n_GetPending_ZIIILjava_util_Date_);
			return cb_getPending_ZIIILjava_util_Date_;
		}

		static IntPtr n_GetPending_ZIIILjava_util_Date_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.ToLocalJniHandle (__this.GetPending (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPending_ZIIILjava_util_Date_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetPending (bool p0, int p1, int p2, int p3, global::Java.Util.Date p4)
		{
			if (id_getPending_ZIIILjava_util_Date_ == IntPtr.Zero)
				id_getPending_ZIIILjava_util_Date_ = JNIEnv.GetMethodID (class_ref, "getPending", "(ZIIILjava/util/Date;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPending_ZIIILjava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getResetInProgressEligible_ILjava_util_Date_;
#pragma warning disable 0169
		static Delegate GetGetResetInProgressEligible_ILjava_util_Date_Handler ()
		{
			if (cb_getResetInProgressEligible_ILjava_util_Date_ == null)
				cb_getResetInProgressEligible_ILjava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_GetResetInProgressEligible_ILjava_util_Date_);
			return cb_getResetInProgressEligible_ILjava_util_Date_;
		}

		static IntPtr n_GetResetInProgressEligible_ILjava_util_Date_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.ToLocalJniHandle (__this.GetResetInProgressEligible (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResetInProgressEligible_ILjava_util_Date_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> GetResetInProgressEligible (int p0, global::Java.Util.Date p1)
		{
			if (id_getResetInProgressEligible_ILjava_util_Date_ == IntPtr.Zero)
				id_getResetInProgressEligible_ILjava_util_Date_ = JNIEnv.GetMethodID (class_ref, "getResetInProgressEligible", "(ILjava/util/Date;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResetInProgressEligible_ILjava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
#pragma warning disable 0169
		static Delegate GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler ()
		{
			if (cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == null)
				cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_);
			return cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		}

		static void n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		public unsafe void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0)
		{
			if (id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == IntPtr.Zero)
				id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_e_, __args);
		}

		static Delegate cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_e_Handler ()
		{
			if (cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == null)
				cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_);
			return cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		}

		static void n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomRespondentDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		IntPtr id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_;
		public unsafe void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents p0)
		{
			if (id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ == IntPtr.Zero)
				id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/e;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_e_, __args);
		}

	}
}
