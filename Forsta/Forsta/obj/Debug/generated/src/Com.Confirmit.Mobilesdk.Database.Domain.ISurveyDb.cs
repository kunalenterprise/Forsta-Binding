using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/SurveyDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker")]
	public partial interface ISurveyDb : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> DeletedSurveyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='getDeletedSurveyList' and count(parameter)=0]"
			[Register ("getDeletedSurveyList", "()Ljava/util/List;", "GetGetDeletedSurveyListHandler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> SurveyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='getSurveyList' and count(parameter)=0]"
			[Register ("getSurveyList", "()Ljava/util/List;", "GetGetSurveyListHandler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='cleanupSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("cleanupSurvey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCleanupSurvey_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
		void CleanupSurvey (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='createOrUpdate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.packages.a'] and parameter[5][@type='boolean']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;ILcom/confirmit/mobilesdk/surveyengine/packages/a;Z)V", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_ZHandler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
		void CreateOrUpdate (string p0, string p1, int p2, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='deleteSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteSurvey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteSurvey_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
		void DeleteSurvey (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='SurveyDb']/method[@name='getSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSurvey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;", "GetGetSurvey_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.Survey GetSurvey (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/SurveyDb", DoNotGenerateAcw=true)]
	internal partial class ISurveyDbInvoker : global::Java.Lang.Object, ISurveyDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/SurveyDb", typeof (ISurveyDbInvoker));

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

		public static ISurveyDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.SurveyDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeletedSurveyList;
#pragma warning disable 0169
		static Delegate GetGetDeletedSurveyListHandler ()
		{
			if (cb_getDeletedSurveyList == null)
				cb_getDeletedSurveyList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeletedSurveyList);
			return cb_getDeletedSurveyList;
		}

		static IntPtr n_GetDeletedSurveyList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.ToLocalJniHandle (__this.DeletedSurveyList);
		}
#pragma warning restore 0169

		IntPtr id_getDeletedSurveyList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> DeletedSurveyList {
			get {
				if (id_getDeletedSurveyList == IntPtr.Zero)
					id_getDeletedSurveyList = JNIEnv.GetMethodID (class_ref, "getDeletedSurveyList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeletedSurveyList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSurveyList;
#pragma warning disable 0169
		static Delegate GetGetSurveyListHandler ()
		{
			if (cb_getSurveyList == null)
				cb_getSurveyList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurveyList);
			return cb_getSurveyList;
		}

		static IntPtr n_GetSurveyList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.ToLocalJniHandle (__this.SurveyList);
		}
#pragma warning restore 0169

		IntPtr id_getSurveyList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> SurveyList {
			get {
				if (id_getSurveyList == IntPtr.Zero)
					id_getSurveyList = JNIEnv.GetMethodID (class_ref, "getSurveyList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurveyList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCleanupSurvey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CleanupSurvey_Ljava_lang_String_Ljava_lang_String_);
			return cb_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CleanupSurvey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CleanupSurvey (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CleanupSurvey (string p0, string p1)
		{
			if (id_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cleanupSurvey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanupSurvey_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_ZHandler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLILZ_V) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z;
		}

		static void n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdate (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z;
		public unsafe void CreateOrUpdate (string p0, string p1, int p2, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA p3, bool p4)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;ILcom/confirmit/mobilesdk/surveyengine/packages/a;Z)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_ILcom_confirmit_mobilesdk_surveyengine_packages_a_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_deleteSurvey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteSurvey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteSurvey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteSurvey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeleteSurvey_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteSurvey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteSurvey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSurvey (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_deleteSurvey_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeleteSurvey (string p0, string p1)
		{
			if (id_deleteSurvey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteSurvey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteSurvey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteSurvey_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getSurvey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSurvey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getSurvey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getSurvey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetSurvey_Ljava_lang_String_Ljava_lang_String_);
			return cb_getSurvey_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetSurvey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSurvey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSurvey_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Survey GetSurvey (string p0, string p1)
		{
			if (id_getSurvey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getSurvey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSurvey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurvey_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
