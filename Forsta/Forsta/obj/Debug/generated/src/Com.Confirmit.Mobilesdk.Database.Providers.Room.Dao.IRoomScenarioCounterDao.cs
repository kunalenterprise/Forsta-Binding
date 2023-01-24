using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioCounterDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDaoInvoker")]
	public partial interface IRoomScenarioCounterDao : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioCounterDao']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.i']]"
		[Register ("delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/i;)V", "GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDaoInvoker, Forsta")]
		void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioCounterDao']/method[@name='get' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get", "(J)Ljava/util/List;", "GetGet_JHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDaoInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter> Get (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioCounterDao']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/i;", "GetGet_JLjava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDaoInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter Get (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomScenarioCounterDao']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.i']]"
		[Register ("replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/i;)V", "GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDaoInvoker, Forsta")]
		void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao", DoNotGenerateAcw=true)]
	internal partial class IRoomScenarioCounterDaoInvoker : global::Java.Lang.Object, IRoomScenarioCounterDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao", typeof (IRoomScenarioCounterDaoInvoker));

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

		public static IRoomScenarioCounterDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomScenarioCounterDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomScenarioCounterDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomScenarioCounterDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_Handler ()
		{
			if (cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ == null)
				cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_);
			return cb_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
		}

		static void n_Delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
		public unsafe void Delete (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter p0)
		{
			if (id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ == IntPtr.Zero)
				id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/confirmit/mobilesdk/database/providers/room/model/i;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_confirmit_mobilesdk_database_providers_room_model_i_, __args);
		}

		static Delegate cb_get_J;
#pragma warning disable 0169
		static Delegate GetGet_JHandler ()
		{
			if (cb_get_J == null)
				cb_get_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Get_J);
			return cb_get_J;
		}

		static IntPtr n_Get_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter>.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		IntPtr id_get_J;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter> Get (long p0)
		{
			if (id_get_J == IntPtr.Zero)
				id_get_J = JNIEnv.GetMethodID (class_ref, "get", "(J)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_get_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_lang_String_Handler ()
		{
			if (cb_get_JLjava_lang_String_ == null)
				cb_get_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Get_JLjava_lang_String_);
			return cb_get_JLjava_lang_String_;
		}

		static IntPtr n_Get_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_JLjava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter Get (long p0, string p1)
		{
			if (id_get_JLjava_lang_String_ == IntPtr.Zero)
				id_get_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/i;");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
#pragma warning disable 0169
		static Delegate GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_Handler ()
		{
			if (cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ == null)
				cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_);
			return cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
		}

		static void n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Replace (p0);
		}
#pragma warning restore 0169

		IntPtr id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_;
		public unsafe void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter p0)
		{
			if (id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ == IntPtr.Zero)
				id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/i;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_i_, __args);
		}

	}
}
