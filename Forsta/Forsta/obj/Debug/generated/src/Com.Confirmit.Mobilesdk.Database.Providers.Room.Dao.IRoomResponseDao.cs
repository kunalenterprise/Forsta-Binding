using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']"
	[Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao", "", "Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker")]
	public partial interface IRoomResponseDao : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues> RespondentValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='getRespondentValue' and count(parameter)=0]"
			[Register ("getRespondentValue", "()Ljava/util/List;", "GetGetRespondentValueHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses> Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/util/List;", "GetGetResponseHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls> ResponseControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='getResponseControl' and count(parameter)=0]"
			[Register ("getResponseControl", "()Ljava/util/List;", "GetGetResponseControlHandler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='deleteRespondentValue' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteRespondentValue", "(Ljava/util/List;)V", "GetDeleteRespondentValue_Ljava_util_List_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void DeleteRespondentValue (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='deleteResponseControls' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteResponseControls", "(Ljava/util/List;)V", "GetDeleteResponseControls_Ljava_util_List_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void DeleteResponseControls (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='deleteResponses' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteResponses", "(Ljava/util/List;)V", "GetDeleteResponses_Ljava_util_List_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void DeleteResponses (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='insertRespondentValue' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.f']]"
		[Register ("insertRespondentValue", "(Lcom/confirmit/mobilesdk/database/providers/room/model/f;)V", "GetInsertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void InsertRespondentValue (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='insertResponse' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.h']]"
		[Register ("insertResponse", "(Lcom/confirmit/mobilesdk/database/providers/room/model/h;)V", "GetInsertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void InsertResponse (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/interface[@name='RoomResponseDao']/method[@name='insertResponseControl' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.g']]"
		[Register ("insertResponseControl", "(Lcom/confirmit/mobilesdk/database/providers/room/model/g;)V", "GetInsertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_Handler:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDaoInvoker, Forsta")]
		void InsertResponseControl (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao", DoNotGenerateAcw=true)]
	internal partial class IRoomResponseDaoInvoker : global::Java.Lang.Object, IRoomResponseDao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao", typeof (IRoomResponseDaoInvoker));

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

		public static IRoomResponseDao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomResponseDao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.providers.room.dao.RoomResponseDao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomResponseDaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRespondentValue;
#pragma warning disable 0169
		static Delegate GetGetRespondentValueHandler ()
		{
			if (cb_getRespondentValue == null)
				cb_getRespondentValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRespondentValue);
			return cb_getRespondentValue;
		}

		static IntPtr n_GetRespondentValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues>.ToLocalJniHandle (__this.RespondentValue);
		}
#pragma warning restore 0169

		IntPtr id_getRespondentValue;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues> RespondentValue {
			get {
				if (id_getRespondentValue == IntPtr.Zero)
					id_getRespondentValue = JNIEnv.GetMethodID (class_ref, "getRespondentValue", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRespondentValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses>.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses> Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponseControl;
#pragma warning disable 0169
		static Delegate GetGetResponseControlHandler ()
		{
			if (cb_getResponseControl == null)
				cb_getResponseControl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseControl);
			return cb_getResponseControl;
		}

		static IntPtr n_GetResponseControl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls>.ToLocalJniHandle (__this.ResponseControl);
		}
#pragma warning restore 0169

		IntPtr id_getResponseControl;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls> ResponseControl {
			get {
				if (id_getResponseControl == IntPtr.Zero)
					id_getResponseControl = JNIEnv.GetMethodID (class_ref, "getResponseControl", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseControl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_deleteRespondentValue_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDeleteRespondentValue_Ljava_util_List_Handler ()
		{
			if (cb_deleteRespondentValue_Ljava_util_List_ == null)
				cb_deleteRespondentValue_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteRespondentValue_Ljava_util_List_);
			return cb_deleteRespondentValue_Ljava_util_List_;
		}

		static void n_DeleteRespondentValue_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteRespondentValue (p0);
		}
#pragma warning restore 0169

		IntPtr id_deleteRespondentValue_Ljava_util_List_;
		public unsafe void DeleteRespondentValue (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_deleteRespondentValue_Ljava_util_List_ == IntPtr.Zero)
				id_deleteRespondentValue_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "deleteRespondentValue", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteRespondentValue_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_deleteResponseControls_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDeleteResponseControls_Ljava_util_List_Handler ()
		{
			if (cb_deleteResponseControls_Ljava_util_List_ == null)
				cb_deleteResponseControls_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteResponseControls_Ljava_util_List_);
			return cb_deleteResponseControls_Ljava_util_List_;
		}

		static void n_DeleteResponseControls_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteResponseControls (p0);
		}
#pragma warning restore 0169

		IntPtr id_deleteResponseControls_Ljava_util_List_;
		public unsafe void DeleteResponseControls (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_deleteResponseControls_Ljava_util_List_ == IntPtr.Zero)
				id_deleteResponseControls_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "deleteResponseControls", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteResponseControls_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_deleteResponses_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDeleteResponses_Ljava_util_List_Handler ()
		{
			if (cb_deleteResponses_Ljava_util_List_ == null)
				cb_deleteResponses_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteResponses_Ljava_util_List_);
			return cb_deleteResponses_Ljava_util_List_;
		}

		static void n_DeleteResponses_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteResponses (p0);
		}
#pragma warning restore 0169

		IntPtr id_deleteResponses_Ljava_util_List_;
		public unsafe void DeleteResponses (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_deleteResponses_Ljava_util_List_ == IntPtr.Zero)
				id_deleteResponses_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "deleteResponses", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteResponses_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_;
#pragma warning disable 0169
		static Delegate GetInsertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_Handler ()
		{
			if (cb_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_ == null)
				cb_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InsertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_);
			return cb_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_;
		}

		static void n_InsertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InsertRespondentValue (p0);
		}
#pragma warning restore 0169

		IntPtr id_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_;
		public unsafe void InsertRespondentValue (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues p0)
		{
			if (id_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_ == IntPtr.Zero)
				id_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_ = JNIEnv.GetMethodID (class_ref, "insertRespondentValue", "(Lcom/confirmit/mobilesdk/database/providers/room/model/f;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertRespondentValue_Lcom_confirmit_mobilesdk_database_providers_room_model_f_, __args);
		}

		static Delegate cb_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_;
#pragma warning disable 0169
		static Delegate GetInsertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_Handler ()
		{
			if (cb_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_ == null)
				cb_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InsertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_);
			return cb_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_;
		}

		static void n_InsertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InsertResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_;
		public unsafe void InsertResponse (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses p0)
		{
			if (id_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_ == IntPtr.Zero)
				id_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_ = JNIEnv.GetMethodID (class_ref, "insertResponse", "(Lcom/confirmit/mobilesdk/database/providers/room/model/h;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertResponse_Lcom_confirmit_mobilesdk_database_providers_room_model_h_, __args);
		}

		static Delegate cb_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_;
#pragma warning disable 0169
		static Delegate GetInsertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_Handler ()
		{
			if (cb_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_ == null)
				cb_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InsertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_);
			return cb_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_;
		}

		static void n_InsertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InsertResponseControl (p0);
		}
#pragma warning restore 0169

		IntPtr id_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_;
		public unsafe void InsertResponseControl (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls p0)
		{
			if (id_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_ == IntPtr.Zero)
				id_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_ = JNIEnv.GetMethodID (class_ref, "insertResponseControl", "(Lcom/confirmit/mobilesdk/database/providers/room/model/g;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertResponseControl_Lcom_confirmit_mobilesdk_database_providers_room_model_g_, __args);
		}

	}
}
