using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/RespondentDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker")]
	public partial interface IRespondentDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='cleanupRespondent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("cleanupRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void CleanupRespondent (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void CreateOrUpdate (string p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='deleteRespondent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("deleteRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void DeleteRespondent (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='getDeletedRespondents' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDeletedRespondents", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetDeletedRespondents_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent> GetDeletedRespondents (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='getPendingRespondents' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPendingRespondents", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetPendingRespondents_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent> GetPendingRespondents (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='getRespondent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/SurveyRespondent;", "GetGetRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent GetRespondent (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='resetInProgressToUpload' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("resetInProgressToUpload", "(Ljava/lang/String;Ljava/lang/String;)V", "GetResetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void ResetInProgressToUpload (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='setUpdateError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUpdateError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void SetUpdateError (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='setUpdatePending' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUpdatePending", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void SetUpdatePending (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='setUpdateProgress' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUpdateProgress", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void SetUpdateProgress (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='setUpdateSuccess' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUpdateSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void SetUpdateSuccess (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='RespondentDb']/method[@name='updateStatus' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.u']]"
		[Register ("updateStatus", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/surveyengine/u;)V", "GetUpdateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDbInvoker, Forsta")]
		void UpdateStatus (string p0, string p1, string p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU p3);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/RespondentDb", DoNotGenerateAcw=true)]
	internal partial class IRespondentDbInvoker : global::Java.Lang.Object, IRespondentDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/RespondentDb", typeof (IRespondentDbInvoker));

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

		public static IRespondentDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRespondentDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.RespondentDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRespondentDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_CleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CleanupRespondent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CleanupRespondent (string p0, string p1, string p2)
		{
			if (id_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cleanupRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanupRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdate (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CreateOrUpdate (string p0, string p1, string p2, string p3)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DeleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeleteRespondent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeleteRespondent (string p0, string p1, string p2)
		{
			if (id_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeletedRespondents_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeletedRespondents_Ljava_lang_String_Ljava_lang_String_);
			return cb_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetDeletedRespondents_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent>.ToLocalJniHandle (__this.GetDeletedRespondents (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent> GetDeletedRespondents (string p0, string p1)
		{
			if (id_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDeletedRespondents", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeletedRespondents_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPendingRespondents_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPendingRespondents_Ljava_lang_String_Ljava_lang_String_);
			return cb_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPendingRespondents_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent>.ToLocalJniHandle (__this.GetPendingRespondents (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent> GetPendingRespondents (string p0, string p1)
		{
			if (id_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPendingRespondents", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingRespondents_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRespondent (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent GetRespondent (string p0, string p1, string p2)
		{
			if (id_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRespondent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/SurveyRespondent;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyRespondent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRespondent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ResetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_);
			return cb_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ResetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ResetInProgressToUpload (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void ResetInProgressToUpload (string p0, string p1)
		{
			if (id_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resetInProgressToUpload", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetInProgressToUpload_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdateError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetUpdateError (string p0, string p1, string p2)
		{
			if (id_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdatePending (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetUpdatePending (string p0, string p1, string p2)
		{
			if (id_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdatePending", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdatePending_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdateProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetUpdateProgress (string p0, string p1, string p2)
		{
			if (id_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateProgress", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateProgress_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdateSuccess (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetUpdateSuccess (string p0, string p1, string p2)
		{
			if (id_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_;
#pragma warning disable 0169
		static Delegate GetUpdateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_Handler ()
		{
			if (cb_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_ == null)
				cb_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_UpdateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_);
			return cb_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_;
		}

		static void n_UpdateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_;
		public unsafe void UpdateStatus (string p0, string p1, string p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU p3)
		{
			if (id_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_ == IntPtr.Zero)
				id_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/surveyengine/u;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_surveyengine_u_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
