using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Web {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='SurveyWebViewFragmentCallback']"
	[Register ("com/confirmit/mobilesdk/web/SurveyWebViewFragmentCallback", "", "Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallbackInvoker")]
	public partial interface ISurveyWebViewFragmentCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='SurveyWebViewFragmentCallback']/method[@name='onWebViewSurveyError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onWebViewSurveyError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "GetOnWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallbackInvoker, Forsta")]
		void OnWebViewSurveyError (string serverId, string projectId, global::Java.Lang.Exception exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='SurveyWebViewFragmentCallback']/method[@name='onWebViewSurveyFinished' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebViewSurveyFinished", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallbackInvoker, Forsta")]
		void OnWebViewSurveyFinished (string serverId, string projectId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='SurveyWebViewFragmentCallback']/method[@name='onWebViewSurveyQuit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebViewSurveyQuit", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallbackInvoker, Forsta")]
		void OnWebViewSurveyQuit (string serverId, string projectId);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/SurveyWebViewFragmentCallback", DoNotGenerateAcw=true)]
	internal partial class ISurveyWebViewFragmentCallbackInvoker : global::Java.Lang.Object, ISurveyWebViewFragmentCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/SurveyWebViewFragmentCallback", typeof (ISurveyWebViewFragmentCallbackInvoker));

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

		public static ISurveyWebViewFragmentCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyWebViewFragmentCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.web.SurveyWebViewFragmentCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyWebViewFragmentCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OnWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_projectId, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var projectId = JNIEnv.GetString (native_projectId, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnWebViewSurveyError (serverId, projectId, exception);
		}
#pragma warning restore 0169

		IntPtr id_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		public unsafe void OnWebViewSurveyError (string serverId, string projectId, global::Java.Lang.Exception exception)
		{
			if (id_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onWebViewSurveyError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_projectId = JNIEnv.NewString ((string)projectId);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_projectId);
			__args [2] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebViewSurveyError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_projectId);
		}

		static Delegate cb_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_);
			return cb_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_projectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var projectId = JNIEnv.GetString (native_projectId, JniHandleOwnership.DoNotTransfer);
			__this.OnWebViewSurveyFinished (serverId, projectId);
		}
#pragma warning restore 0169

		IntPtr id_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnWebViewSurveyFinished (string serverId, string projectId)
		{
			if (id_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebViewSurveyFinished", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_projectId = JNIEnv.NewString ((string)projectId);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_projectId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebViewSurveyFinished_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_projectId);
		}

		static Delegate cb_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_);
			return cb_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_projectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var projectId = JNIEnv.GetString (native_projectId, JniHandleOwnership.DoNotTransfer);
			__this.OnWebViewSurveyQuit (serverId, projectId);
		}
#pragma warning restore 0169

		IntPtr id_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnWebViewSurveyQuit (string serverId, string projectId)
		{
			if (id_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebViewSurveyQuit", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_projectId = JNIEnv.NewString ((string)projectId);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_projectId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebViewSurveyQuit_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_projectId);
		}

	}
}
