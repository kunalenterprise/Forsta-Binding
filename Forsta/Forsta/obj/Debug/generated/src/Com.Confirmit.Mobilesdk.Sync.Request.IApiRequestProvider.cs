using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']"
	[Register ("com/confirmit/mobilesdk/sync/request/ApiRequestProvider", "", "Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker")]
	public partial interface IApiRequestProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='checkCfr' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("checkCfr", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCheckCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object CheckCfr (string p0, string p1, string p2, string p3, global::Kotlin.Coroutines.IContinuation p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='downloadPackage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("downloadPackage", "(Ljava/lang/String;Ljava/lang/String;ILkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDownloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object DownloadPackage (string p0, string p1, int p2, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getAuthHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("getAuthHeader", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetAuthHeader (string p0, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getAuthToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.confirmit.mobilesdk.sync.payloads.a'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("getAuthToken", "(Ljava/lang/String;Lcom/confirmit/mobilesdk/sync/payloads/a;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetAuthToken (string p0, global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsA p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("getConfig", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetConfig (string p0, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getCounters' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("getCounters", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetCounters (string p0, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getProgram' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("getProgram", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetProgram (string p0, string p1, string p2, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='getProgramLoader' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("getProgramLoader", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGetProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object GetProgramLoader (string p0, string p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequestProvider']/method[@name='uploadRespondent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.confirmit.mobilesdk.sync.payloads.e'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.ApiResponse&gt;']]"
		[Register ("uploadRespondent", "(Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/sync/payloads/e;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProviderInvoker, Forsta")]
		global::Java.Lang.Object UploadRespondent (string p0, string p1, global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsE p2, global::Kotlin.Coroutines.IContinuation p3);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/request/ApiRequestProvider", DoNotGenerateAcw=true)]
	internal partial class IApiRequestProviderInvoker : global::Java.Lang.Object, IApiRequestProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/request/ApiRequestProvider", typeof (IApiRequestProviderInvoker));

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

		public static IApiRequestProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiRequestProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.sync.request.ApiRequestProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiRequestProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetCheckCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_CheckCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_CheckCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckCfr (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object CheckCfr (string p0, string p1, string p2, string p3, global::Kotlin.Coroutines.IContinuation p4)
		{
			if (id_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "checkCfr", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetDownloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_ == null)
				cb_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_L) n_DownloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_);
			return cb_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_;
		}

		static IntPtr n_DownloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadPackage (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object DownloadPackage (string p0, string p1, int p2, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "downloadPackage", "(Ljava/lang/String;Ljava/lang/String;ILkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_downloadPackage_Ljava_lang_String_Ljava_lang_String_ILkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetAuthHeader (string p0, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getAuthHeader", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthHeader_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_ == null)
				cb_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_);
			return cb_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsA> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthToken (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetAuthToken (string p0, global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsA p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getAuthToken", "(Ljava/lang/String;Lcom/confirmit/mobilesdk/sync/payloads/a;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthToken_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_a_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfig (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetConfig (string p0, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCounters (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetCounters (string p0, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getCounters", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCounters_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProgram (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetProgram (string p0, string p1, string p2, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getProgram", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgram_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGetProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_);
			return cb_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_GetProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProgramLoader (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object GetProgramLoader (string p0, string p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "getProgramLoader", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgramLoader_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_ == null)
				cb_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_UploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_);
			return cb_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_UploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsE> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadRespondent (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object UploadRespondent (string p0, string p1, global::Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsE p2, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "uploadRespondent", "(Ljava/lang/String;Ljava/lang/String;Lcom/confirmit/mobilesdk/sync/payloads/e;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uploadRespondent_Ljava_lang_String_Ljava_lang_String_Lcom_confirmit_mobilesdk_sync_payloads_e_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
