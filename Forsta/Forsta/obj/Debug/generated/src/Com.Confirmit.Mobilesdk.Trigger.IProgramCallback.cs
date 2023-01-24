using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Trigger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']"
	[Register ("com/confirmit/mobilesdk/trigger/ProgramCallback", "", "Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker")]
	public partial interface IProgramCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onAppFeedback' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.trigger.TriggerInfo'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onAppFeedback", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/util/Map;)V", "GetOnAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnAppFeedback (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::System.Collections.Generic.IDictionary<string, string> data);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onScenarioError' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.trigger.TriggerInfo'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onScenarioError", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/Exception;)V", "GetOnScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnScenarioError (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::Java.Lang.Exception exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onScenarioLoad' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.trigger.TriggerInfo'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onScenarioLoad", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/Exception;)V", "GetOnScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnScenarioLoad (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::Java.Lang.Exception exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onSurveyDownloadCompleted' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.trigger.TriggerInfo'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onSurveyDownloadCompleted", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/String;Ljava/lang/Exception;)V", "GetOnSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnSurveyDownloadCompleted (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, string surveyId, global::Java.Lang.Exception exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onSurveyStart' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyFrameConfig']]"
		[Register ("onSurveyStart", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V", "GetOnSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnSurveyStart (global::Com.Confirmit.Mobilesdk.UI.SurveyFrameConfig config);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/interface[@name='ProgramCallback']/method[@name='onWebSurveyStart' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.web.SurveyWebViewFragment']]"
		[Register ("onWebSurveyStart", "(Lcom/confirmit/mobilesdk/web/SurveyWebViewFragment;)V", "GetOnWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_Handler:Com.Confirmit.Mobilesdk.Trigger.IProgramCallbackInvoker, Forsta")]
		void OnWebSurveyStart (global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment fragment);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/trigger/ProgramCallback", DoNotGenerateAcw=true)]
	internal partial class IProgramCallbackInvoker : global::Java.Lang.Object, IProgramCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/trigger/ProgramCallback", typeof (IProgramCallbackInvoker));

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

		public static IProgramCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgramCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.trigger.ProgramCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgramCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_Handler ()
		{
			if (cb_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_ == null)
				cb_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_);
			return cb_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_;
		}

		static void n_OnAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_triggerInfo, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var triggerInfo = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo> (native_triggerInfo, JniHandleOwnership.DoNotTransfer);
			var data = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
			__this.OnAppFeedback (triggerInfo, data);
		}
#pragma warning restore 0169

		IntPtr id_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_;
		public unsafe void OnAppFeedback (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::System.Collections.Generic.IDictionary<string, string> data)
		{
			if (id_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_ == IntPtr.Zero)
				id_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onAppFeedback", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/util/Map;)V");
			IntPtr native_data = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (data);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((triggerInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) triggerInfo).Handle);
			__args [1] = new JValue (native_data);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAppFeedback_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_data);
		}

		static Delegate cb_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_Handler ()
		{
			if (cb_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ == null)
				cb_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_);
			return cb_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
		}

		static void n_OnScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_triggerInfo, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var triggerInfo = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo> (native_triggerInfo, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnScenarioError (triggerInfo, exception);
		}
#pragma warning restore 0169

		IntPtr id_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
		public unsafe void OnScenarioError (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::Java.Lang.Exception exception)
		{
			if (id_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onScenarioError", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((triggerInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) triggerInfo).Handle);
			__args [1] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScenarioError_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_Handler ()
		{
			if (cb_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ == null)
				cb_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_);
			return cb_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
		}

		static void n_OnScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_triggerInfo, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var triggerInfo = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo> (native_triggerInfo, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnScenarioLoad (triggerInfo, exception);
		}
#pragma warning restore 0169

		IntPtr id_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_;
		public unsafe void OnScenarioLoad (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, global::Java.Lang.Exception exception)
		{
			if (id_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onScenarioLoad", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((triggerInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) triggerInfo).Handle);
			__args [1] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScenarioLoad_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OnSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_triggerInfo, IntPtr native_surveyId, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var triggerInfo = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo> (native_triggerInfo, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyDownloadCompleted (triggerInfo, surveyId, exception);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_;
		public unsafe void OnSurveyDownloadCompleted (global::Com.Confirmit.Mobilesdk.Trigger.TriggerInfo triggerInfo, string surveyId, global::Java.Lang.Exception exception)
		{
			if (id_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSurveyDownloadCompleted", "(Lcom/confirmit/mobilesdk/trigger/TriggerInfo;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((triggerInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) triggerInfo).Handle);
			__args [1] = new JValue (native_surveyId);
			__args [2] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyDownloadCompleted_Lcom_confirmit_mobilesdk_trigger_TriggerInfo_Ljava_lang_String_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_surveyId);
		}

		static Delegate cb_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_Handler ()
		{
			if (cb_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_ == null)
				cb_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_);
			return cb_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_;
		}

		static void n_OnSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyFrameConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyStart (config);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_;
		public unsafe void OnSurveyStart (global::Com.Confirmit.Mobilesdk.UI.SurveyFrameConfig config)
		{
			if (id_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_ == IntPtr.Zero)
				id_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_ = JNIEnv.GetMethodID (class_ref, "onSurveyStart", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyStart_Lcom_confirmit_mobilesdk_ui_SurveyFrameConfig_, __args);
		}

		static Delegate cb_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_;
#pragma warning disable 0169
		static Delegate GetOnWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_Handler ()
		{
			if (cb_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_ == null)
				cb_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_);
			return cb_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_;
		}

		static void n_OnWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.IProgramCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fragment = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment> (native_fragment, JniHandleOwnership.DoNotTransfer);
			__this.OnWebSurveyStart (fragment);
		}
#pragma warning restore 0169

		IntPtr id_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_;
		public unsafe void OnWebSurveyStart (global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment fragment)
		{
			if (id_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_ == IntPtr.Zero)
				id_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_ = JNIEnv.GetMethodID (class_ref, "onWebSurveyStart", "(Lcom/confirmit/mobilesdk/web/SurveyWebViewFragment;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebSurveyStart_Lcom_confirmit_mobilesdk_web_SurveyWebViewFragment_, __args);
		}

	}
}
