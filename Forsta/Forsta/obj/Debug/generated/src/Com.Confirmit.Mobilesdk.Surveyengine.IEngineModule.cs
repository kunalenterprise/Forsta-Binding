using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineModule']"
	[Register ("com/confirmit/mobilesdk/surveyengine/EngineModule", "", "Com.Confirmit.Mobilesdk.Surveyengine.IEngineModuleInvoker")]
	public partial interface IEngineModule : global::Com.Confirmit.Mobilesdk.ConfirmitSDK.IModule {
		global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor ScriptExecutor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineModule']/method[@name='getScriptExecutor' and count(parameter)=0]"
			[Register ("getScriptExecutor", "()Lcom/confirmit/mobilesdk/scripting/surveyengine/ScriptExecutor;", "GetGetScriptExecutorHandler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider SurveyDataProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineModule']/method[@name='getSurveyDataProvider' and count(parameter)=0]"
			[Register ("getSurveyDataProvider", "()Lcom/confirmit/mobilesdk/surveyengine/data/SurveyDataProvider;", "GetGetSurveyDataProviderHandler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineModuleInvoker, Forsta")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/EngineModule", DoNotGenerateAcw=true)]
	internal partial class IEngineModuleInvoker : global::Java.Lang.Object, IEngineModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/EngineModule", typeof (IEngineModuleInvoker));

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

		public static IEngineModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.EngineModule'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getScriptExecutor;
#pragma warning disable 0169
		static Delegate GetGetScriptExecutorHandler ()
		{
			if (cb_getScriptExecutor == null)
				cb_getScriptExecutor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScriptExecutor);
			return cb_getScriptExecutor;
		}

		static IntPtr n_GetScriptExecutor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScriptExecutor);
		}
#pragma warning restore 0169

		IntPtr id_getScriptExecutor;
		public unsafe global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor ScriptExecutor {
			get {
				if (id_getScriptExecutor == IntPtr.Zero)
					id_getScriptExecutor = JNIEnv.GetMethodID (class_ref, "getScriptExecutor", "()Lcom/confirmit/mobilesdk/scripting/surveyengine/ScriptExecutor;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScriptExecutor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSurveyDataProvider;
#pragma warning disable 0169
		static Delegate GetGetSurveyDataProviderHandler ()
		{
			if (cb_getSurveyDataProvider == null)
				cb_getSurveyDataProvider = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurveyDataProvider);
			return cb_getSurveyDataProvider;
		}

		static IntPtr n_GetSurveyDataProvider (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurveyDataProvider);
		}
#pragma warning restore 0169

		IntPtr id_getSurveyDataProvider;
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider SurveyDataProvider {
			get {
				if (id_getSurveyDataProvider == IntPtr.Zero)
					id_getSurveyDataProvider = JNIEnv.GetMethodID (class_ref, "getSurveyDataProvider", "()Lcom/confirmit/mobilesdk/surveyengine/data/SurveyDataProvider;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Data.ISurveyDataProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurveyDataProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_Handler ()
		{
			if (cb_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_ == null)
				cb_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_);
			return cb_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_;
		}

		static void n_Initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application, IntPtr native_setup)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var application = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_application, JniHandleOwnership.DoNotTransfer);
			var setup = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup> (native_setup, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (application, setup);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_;
		public unsafe void Initialize (global::Android.App.Application application, global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup setup)
		{
			if (id_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_ == IntPtr.Zero)
				id_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
			__args [1] = new JValue ((setup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) setup).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_, __args);
		}

	}
}
