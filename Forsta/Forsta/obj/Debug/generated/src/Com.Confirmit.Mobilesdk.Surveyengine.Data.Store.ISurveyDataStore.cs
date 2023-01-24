using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Data.Store {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']"
	[Register ("com/confirmit/mobilesdk/surveyengine/data/store/SurveyDataStore", "", "Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker")]
	public partial interface ISurveyDataStore : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IDictionary<string, string> ChangeMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='getChangeMap' and count(parameter)=0]"
			[Register ("getChangeMap", "()Ljava/util/Map;", "GetGetChangeMapHandler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='clearChangeMap' and count(parameter)=0]"
		[Register ("clearChangeMap", "()V", "GetClearChangeMapHandler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		void ClearChangeMap ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_Class_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object Get (global::Java.Lang.Class p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("load", "(Ljava/util/Map;)V", "GetLoad_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		void Load (global::System.Collections.Generic.IDictionary<string, string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='removeChange' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeChange", "(Ljava/lang/String;)V", "GetRemoveChange_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		void RemoveChange (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='revert' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("revert", "(Ljava/lang/String;)V", "GetRevert_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		void Revert (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data.store']/interface[@name='SurveyDataStore']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStoreInvoker, Forsta")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		void Set (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/data/store/SurveyDataStore", DoNotGenerateAcw=true)]
	internal partial class ISurveyDataStoreInvoker : global::Java.Lang.Object, ISurveyDataStore {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/data/store/SurveyDataStore", typeof (ISurveyDataStoreInvoker));

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

		public static ISurveyDataStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyDataStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.data.store.SurveyDataStore'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyDataStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getChangeMap;
#pragma warning disable 0169
		static Delegate GetGetChangeMapHandler ()
		{
			if (cb_getChangeMap == null)
				cb_getChangeMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChangeMap);
			return cb_getChangeMap;
		}

		static IntPtr n_GetChangeMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ChangeMap);
		}
#pragma warning restore 0169

		IntPtr id_getChangeMap;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ChangeMap {
			get {
				if (id_getChangeMap == IntPtr.Zero)
					id_getChangeMap = JNIEnv.GetMethodID (class_ref, "getChangeMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChangeMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clearChangeMap;
#pragma warning disable 0169
		static Delegate GetClearChangeMapHandler ()
		{
			if (cb_clearChangeMap == null)
				cb_clearChangeMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearChangeMap);
			return cb_clearChangeMap;
		}

		static void n_ClearChangeMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearChangeMap ();
		}
#pragma warning restore 0169

		IntPtr id_clearChangeMap;
		public unsafe void ClearChangeMap ()
		{
			if (id_clearChangeMap == IntPtr.Zero)
				id_clearChangeMap = JNIEnv.GetMethodID (class_ref, "clearChangeMap", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearChangeMap);
		}

		static Delegate cb_get_Ljava_lang_Class_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Class_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_Class_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Get_Ljava_lang_Class_Ljava_lang_String_);
			return cb_get_Ljava_lang_Class_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_Class_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_Class_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object Get (global::Java.Lang.Class p0, string p1)
		{
			if (id_get_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_load_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_util_Map_Handler ()
		{
			if (cb_load_Ljava_util_Map_ == null)
				cb_load_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Load_Ljava_util_Map_);
			return cb_load_Ljava_util_Map_;
		}

		static void n_Load_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0);
		}
#pragma warning restore 0169

		IntPtr id_load_Ljava_util_Map_;
		public unsafe void Load (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_load_Ljava_util_Map_ == IntPtr.Zero)
				id_load_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeChange_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveChange_Ljava_lang_String_Handler ()
		{
			if (cb_removeChange_Ljava_lang_String_ == null)
				cb_removeChange_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveChange_Ljava_lang_String_);
			return cb_removeChange_Ljava_lang_String_;
		}

		static void n_RemoveChange_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeChange_Ljava_lang_String_;
		public unsafe void RemoveChange (string p0)
		{
			if (id_removeChange_Ljava_lang_String_ == IntPtr.Zero)
				id_removeChange_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeChange", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeChange_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_revert_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRevert_Ljava_lang_String_Handler ()
		{
			if (cb_revert_Ljava_lang_String_ == null)
				cb_revert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Revert_Ljava_lang_String_);
			return cb_revert_Ljava_lang_String_;
		}

		static void n_Revert_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Revert (p0);
		}
#pragma warning restore 0169

		IntPtr id_revert_Ljava_lang_String_;
		public unsafe void Revert (string p0)
		{
			if (id_revert_Ljava_lang_String_ == IntPtr.Zero)
				id_revert_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "revert", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_revert_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Set_Ljava_lang_String_Ljava_lang_Object_);
			return cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.ISurveyDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Set (string p0, global::Java.Lang.Object p1)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
