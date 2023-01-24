using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/ResponseDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker")]
	public partial interface IResponseDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='getCustomData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "GetGetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> GetCustomData (string serverId, string surveyId, string respondentGuid);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='getCustomData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		string GetCustomData (string serverId, string surveyId, string respondentGuid, string key);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='getRespondentValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getRespondentValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "GetGetRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> GetRespondentValue (string serverId, string surveyId, string respondentGuid);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='getResponse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> GetResponse (string serverId, string surveyId, string respondentGuid);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='getResponseControl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResponseControl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "GetGetResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		global::System.Collections.Generic.IDictionary<string, string> GetResponseControl (string serverId, string surveyId, string respondentGuid);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='updateCustomData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetUpdateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		void UpdateCustomData (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> customData);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='updateRespondentValue' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateRespondentValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetUpdateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		void UpdateRespondentValue (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> respondentValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ResponseDb']/method[@name='updateResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", "GetUpdateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IResponseDbInvoker, Forsta")]
		void UpdateResponse (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> responseControl, global::System.Collections.Generic.IDictionary<string, string> response);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/ResponseDb", DoNotGenerateAcw=true)]
	internal partial class IResponseDbInvoker : global::Java.Lang.Object, IResponseDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/ResponseDb", typeof (IResponseDbInvoker));

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

		public static IResponseDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.ResponseDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetCustomData (serverId, surveyId, respondentGuid));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> GetCustomData (string serverId, string surveyId, string respondentGuid)
		{
			if (id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			return __ret;
		}

		static Delegate cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetCustomData (serverId, surveyId, respondentGuid, key));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string GetCustomData (string serverId, string surveyId, string respondentGuid, string key)
		{
			if (id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			__args [3] = new JValue (native_key);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			JNIEnv.DeleteLocalRef (native_key);
			return __ret;
		}

		static Delegate cb_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetRespondentValue (serverId, surveyId, respondentGuid));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> GetRespondentValue (string serverId, string surveyId, string respondentGuid)
		{
			if (id_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRespondentValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			return __ret;
		}

		static Delegate cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetResponse (serverId, surveyId, respondentGuid));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> GetResponse (string serverId, string surveyId, string respondentGuid)
		{
			if (id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			return __ret;
		}

		static Delegate cb_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetResponseControl (serverId, surveyId, respondentGuid));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> GetResponseControl (string serverId, string surveyId, string respondentGuid)
		{
			if (id_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResponseControl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseControl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			return __ret;
		}

		static Delegate cb_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_UpdateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_UpdateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid, IntPtr native_customData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			var customData = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_customData, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCustomData (serverId, surveyId, respondentGuid, customData);
		}
#pragma warning restore 0169

		IntPtr id_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void UpdateCustomData (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> customData)
		{
			if (id_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updateCustomData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			IntPtr native_customData = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (customData);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			__args [3] = new JValue (native_customData);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCustomData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			JNIEnv.DeleteLocalRef (native_customData);
		}

		static Delegate cb_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_UpdateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_UpdateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid, IntPtr native_respondentValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			var respondentValue = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_respondentValue, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRespondentValue (serverId, surveyId, respondentGuid, respondentValue);
		}
#pragma warning restore 0169

		IntPtr id_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void UpdateRespondentValue (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> respondentValue)
		{
			if (id_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updateRespondentValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			IntPtr native_respondentValue = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (respondentValue);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			__args [3] = new JValue (native_respondentValue);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateRespondentValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			JNIEnv.DeleteLocalRef (native_respondentValue);
		}

		static Delegate cb_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_UpdateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_);
			return cb_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_UpdateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_surveyId, IntPtr native_respondentGuid, IntPtr native_responseControl, IntPtr native_response)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var respondentGuid = JNIEnv.GetString (native_respondentGuid, JniHandleOwnership.DoNotTransfer);
			var responseControl = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_responseControl, JniHandleOwnership.DoNotTransfer);
			var response = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_response, JniHandleOwnership.DoNotTransfer);
			__this.UpdateResponse (serverId, surveyId, respondentGuid, responseControl, response);
		}
#pragma warning restore 0169

		IntPtr id_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		public unsafe void UpdateResponse (string serverId, string surveyId, string respondentGuid, global::System.Collections.Generic.IDictionary<string, string> responseControl, global::System.Collections.Generic.IDictionary<string, string> response)
		{
			if (id_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updateResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			IntPtr native_respondentGuid = JNIEnv.NewString ((string)respondentGuid);
			IntPtr native_responseControl = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (responseControl);
			IntPtr native_response = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (response);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue (native_respondentGuid);
			__args [3] = new JValue (native_responseControl);
			__args [4] = new JValue (native_response);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			JNIEnv.DeleteLocalRef (native_respondentGuid);
			JNIEnv.DeleteLocalRef (native_responseControl);
			JNIEnv.DeleteLocalRef (native_response);
		}

	}
}
