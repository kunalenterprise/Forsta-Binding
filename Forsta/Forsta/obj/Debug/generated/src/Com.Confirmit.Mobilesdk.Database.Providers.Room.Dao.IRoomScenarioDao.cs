using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker")]
	public partial interface IRoomScenarioDao : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/List;", "GetGetAllHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.j']]"
		[Register ("delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V", "GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
		void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='getAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAll", "(Ljava/lang/String;)Ljava/util/List;", "GetGetAll_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> GetAll (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.j']]"
		[Register ("insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V", "GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
		void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.j']]"
		[Register ("replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V", "GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
		void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioDao']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.j']]"
		[Register ("update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V", "GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDaoInvoker, Forsta")]
		void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao", DoNotGenerateAcw=true)]
	internal partial class IRoomScenarioDaoInvoker : global::Java.Lang.Object, IRoomScenarioDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao", typeof (IRoomScenarioDaoInvoker));

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

		public static IRoomScenarioDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomScenarioDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomScenarioDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomScenarioDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		IntPtr id_getAll;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> All {
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler ()
		{
			if (cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == null)
				cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_);
			return cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		}

		static void n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		public unsafe void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0)
		{
			if (id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == IntPtr.Zero)
				id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_j_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario>.ToLocalJniHandle (__this.GetAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAll_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> GetAll (string p0)
		{
			if (id_getAll_Ljava_lang_String_ == IntPtr.Zero)
				id_getAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAll", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
#pragma warning disable 0169
		static Delegate GetInsert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler ()
		{
			if (cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == null)
				cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_);
			return cb_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		}

		static void n_Insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		public unsafe void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0)
		{
			if (id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == IntPtr.Zero)
				id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lcom_confirmit_mobilesdk_database_providers_room_model_j_, __args);
		}

		static Delegate cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
#pragma warning disable 0169
		static Delegate GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler ()
		{
			if (cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == null)
				cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_);
			return cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		}

		static void n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Replace (p0);
		}
#pragma warning restore 0169

		IntPtr id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		public unsafe void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0)
		{
			if (id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == IntPtr.Zero)
				id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_j_, __args);
		}

		static Delegate cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_confirmit_mobilesdk_database_providers_room_model_j_Handler ()
		{
			if (cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == null)
				cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_);
			return cb_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		}

		static void n_Update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		IntPtr id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_;
		public unsafe void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario p0)
		{
			if (id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ == IntPtr.Zero)
				id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/j;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_confirmit_mobilesdk_database_providers_room_model_j_, __args);
		}

	}
}
