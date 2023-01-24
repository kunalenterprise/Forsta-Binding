using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']"
	[Register ("com/confirmit/mobilesdk/surveyengine/data/SurveyDataProvider", "", "Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker")]
	public partial interface ISurveyDataProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='createRespondent' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.data.b']]"
		[Register ("createRespondent", "(Lcom/confirmit/mobilesdk/surveyengine/data/b;)V", "GetCreateRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		void CreateRespondent (global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='load' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;Ljava/lang/String;)V", "GetLoad_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		void Load (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='readCustomData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readCustomData", "(Ljava/lang/String;)Ljava/util/Map;", "GetReadCustomData_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> ReadCustomData (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='readRespondent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readRespondent", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/data/b;", "GetReadRespondent_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB ReadRespondent (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='readRespondentValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readRespondentValue", "(Ljava/lang/String;)Ljava/util/Map;", "GetReadRespondentValue_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> ReadRespondentValue (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='readResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readResponse", "(Ljava/lang/String;)Ljava/util/Map;", "GetReadResponse_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> ReadResponse (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='readResponseControl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readResponseControl", "(Ljava/lang/String;)Ljava/util/Map;", "GetReadResponseControl_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> ReadResponseControl (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.data']/interface[@name='SurveyDataProvider']/method[@name='writeCustomData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("writeCustomData", "(Ljava/lang/String;Ljava/util/Map;)V", "GetWriteCustomData_Ljava_lang_String_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProviderInvoker, Forsta")]
		void WriteCustomData (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/data/SurveyDataProvider", DoNotGenerateAcw=true)]
	internal partial class ISurveyDataProviderInvoker : global::Java.Lang.Object, ISurveyDataProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/data/SurveyDataProvider", typeof (ISurveyDataProviderInvoker));

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

		public static ISurveyDataProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyDataProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.data.SurveyDataProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyDataProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_;
#pragma warning disable 0169
		static Delegate GetCreateRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_Handler ()
		{
			if (cb_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_ == null)
				cb_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CreateRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_);
			return cb_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_;
		}

		static void n_CreateRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateRespondent (p0);
		}
#pragma warning restore 0169

		IntPtr id_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_;
		public unsafe void CreateRespondent (global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB p0)
		{
			if (id_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_ == IntPtr.Zero)
				id_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_ = JNIEnv.GetMethodID (class_ref, "createRespondent", "(Lcom/confirmit/mobilesdk/surveyengine/data/b;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createRespondent_Lcom_confirmit_mobilesdk_surveyengine_data_b_, __args);
		}

		static Delegate cb_load_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Load_Ljava_lang_String_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Load_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_load_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Load (string p0, string p1)
		{
			if (id_load_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_readCustomData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadCustomData_Ljava_lang_String_Handler ()
		{
			if (cb_readCustomData_Ljava_lang_String_ == null)
				cb_readCustomData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadCustomData_Ljava_lang_String_);
			return cb_readCustomData_Ljava_lang_String_;
		}

		static IntPtr n_ReadCustomData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ReadCustomData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readCustomData_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ReadCustomData (string p0)
		{
			if (id_readCustomData_Ljava_lang_String_ == IntPtr.Zero)
				id_readCustomData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readCustomData", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readCustomData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readRespondent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadRespondent_Ljava_lang_String_Handler ()
		{
			if (cb_readRespondent_Ljava_lang_String_ == null)
				cb_readRespondent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadRespondent_Ljava_lang_String_);
			return cb_readRespondent_Ljava_lang_String_;
		}

		static IntPtr n_ReadRespondent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadRespondent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readRespondent_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB ReadRespondent (string p0)
		{
			if (id_readRespondent_Ljava_lang_String_ == IntPtr.Zero)
				id_readRespondent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRespondent", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/data/b;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readRespondent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readRespondentValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadRespondentValue_Ljava_lang_String_Handler ()
		{
			if (cb_readRespondentValue_Ljava_lang_String_ == null)
				cb_readRespondentValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadRespondentValue_Ljava_lang_String_);
			return cb_readRespondentValue_Ljava_lang_String_;
		}

		static IntPtr n_ReadRespondentValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ReadRespondentValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readRespondentValue_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ReadRespondentValue (string p0)
		{
			if (id_readRespondentValue_Ljava_lang_String_ == IntPtr.Zero)
				id_readRespondentValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRespondentValue", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readRespondentValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadResponse_Ljava_lang_String_Handler ()
		{
			if (cb_readResponse_Ljava_lang_String_ == null)
				cb_readResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadResponse_Ljava_lang_String_);
			return cb_readResponse_Ljava_lang_String_;
		}

		static IntPtr n_ReadResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ReadResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readResponse_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ReadResponse (string p0)
		{
			if (id_readResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_readResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readResponse", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readResponse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readResponseControl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadResponseControl_Ljava_lang_String_Handler ()
		{
			if (cb_readResponseControl_Ljava_lang_String_ == null)
				cb_readResponseControl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadResponseControl_Ljava_lang_String_);
			return cb_readResponseControl_Ljava_lang_String_;
		}

		static IntPtr n_ReadResponseControl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ReadResponseControl (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readResponseControl_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ReadResponseControl (string p0)
		{
			if (id_readResponseControl_Ljava_lang_String_ == IntPtr.Zero)
				id_readResponseControl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readResponseControl", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readResponseControl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeCustomData_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetWriteCustomData_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_writeCustomData_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_writeCustomData_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WriteCustomData_Ljava_lang_String_Ljava_util_Map_);
			return cb_writeCustomData_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_WriteCustomData_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteCustomData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_writeCustomData_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void WriteCustomData (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_writeCustomData_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_writeCustomData_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "writeCustomData", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCustomData_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
