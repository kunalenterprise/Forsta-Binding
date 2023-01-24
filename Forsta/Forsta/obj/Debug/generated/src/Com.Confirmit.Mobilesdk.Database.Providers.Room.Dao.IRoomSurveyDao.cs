using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomSurveyDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker")]
	public partial interface IRoomSurveyDao : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.l']]"
		[Register ("delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V", "GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='get' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("get", "(Z)Ljava/util/List;", "GetGet_ZHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> Get (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/l;", "GetGet_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys Get (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;Z)Lcom/confirmit/mobilesdk/database/providers/room/model/l;", "GetGet_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys Get (string p0, string p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.l']]"
		[Register ("insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V", "GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomSurveyDao']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.l']]"
		[Register ("update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V", "GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDaoInvoker, Forsta")]
		void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomSurveyDao", DoNotGenerateAcw=true)]
	internal partial class IRoomSurveyDaoInvoker : global::Java.Lang.Object, IRoomSurveyDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomSurveyDao", typeof (IRoomSurveyDaoInvoker));

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

		public static IRoomSurveyDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomSurveyDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomSurveyDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomSurveyDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler ()
		{
			if (cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == null)
				cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_);
			return cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		}

		static void n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		public unsafe void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0)
		{
			if (id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == IntPtr.Zero)
				id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_l_, __args);
		}

		static Delegate cb_get_Z;
#pragma warning disable 0169
		static Delegate GetGet_ZHandler ()
		{
			if (cb_get_Z == null)
				cb_get_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Get_Z);
			return cb_get_Z;
		}

		static IntPtr n_Get_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys>.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		IntPtr id_get_Z;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> Get (bool p0)
		{
			if (id_get_Z == IntPtr.Zero)
				id_get_Z = JNIEnv.GetMethodID (class_ref, "get", "(Z)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Z, __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys Get (string p0, string p1)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/l;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Get_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_get_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys Get (string p0, string p1, bool p2)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;Z)Lcom/confirmit/mobilesdk/database/providers/room/model/l;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
#pragma warning disable 0169
		static Delegate GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler ()
		{
			if (cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == null)
				cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_);
			return cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		}

		static void n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		public unsafe void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0)
		{
			if (id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == IntPtr.Zero)
				id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_l_, __args);
		}

		static Delegate cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_l_Handler ()
		{
			if (cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == null)
				cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_);
			return cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		}

		static void n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomSurveyDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		IntPtr id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_;
		public unsafe void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p0)
		{
			if (id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ == IntPtr.Zero)
				id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/l;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_l_, __args);
		}

	}
}
