using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomPrefDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomPrefDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomPrefDaoInvoker")]
	public partial interface IRoomPrefDao : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomPrefDao']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomPrefDaoInvoker, Forsta")]
		string Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomPrefDao']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.b']]"
		[Register ("replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/b;)V", "GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomPrefDaoInvoker, Forsta")]
		void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Prefs p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomPrefDao", DoNotGenerateAcw=true)]
	internal partial class IRoomPrefDaoInvoker : global::Java.Lang.Object, IRoomPrefDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomPrefDao", typeof (IRoomPrefDaoInvoker));

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

		public static IRoomPrefDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomPrefDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomPrefDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomPrefDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_;
#pragma warning disable 0169
		static Delegate GetReplace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_Handler ()
		{
			if (cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_ == null)
				cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_);
			return cb_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_;
		}

		static void n_Replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomPrefDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Prefs> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Replace (p0);
		}
#pragma warning restore 0169

		IntPtr id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_;
		public unsafe void Replace (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Prefs p0)
		{
			if (id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_ == IntPtr.Zero)
				id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_ = JNIEnv.GetMethodID (class_ref, "replace", "(Lcom/confirmit/mobilesdk/database/providers/room/model/b;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lcom_confirmit_mobilesdk_database_providers_room_model_b_, __args);
		}

	}
}
