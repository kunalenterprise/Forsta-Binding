using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']"
	[Register ("com/confirmit/mobilesdk/database/DataModule", "", "Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker")]
	public partial interface IDataModule : global::Com.Confirmit.Mobilesdk.ConfirmitSDK.IModule {
		global::Com.Confirmit.Mobilesdk.Database.Domain.IPrefDb Pref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getPref' and count(parameter)=0]"
			[Register ("getPref", "()Lcom/confirmit/mobilesdk/database/domain/PrefDb;", "GetGetPrefHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb Program {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getProgram' and count(parameter)=0]"
			[Register ("getProgram", "()Lcom/confirmit/mobilesdk/database/domain/ProgramDb;", "GetGetProgramHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb ProgramPref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getProgramPref' and count(parameter)=0]"
			[Register ("getProgramPref", "()Lcom/confirmit/mobilesdk/database/domain/ProgramPrefDb;", "GetGetProgramPrefHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb Respondent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getRespondent' and count(parameter)=0]"
			[Register ("getRespondent", "()Lcom/confirmit/mobilesdk/database/domain/RespondentDb;", "GetGetRespondentHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/confirmit/mobilesdk/database/domain/ResponseDb;", "GetGetResponseHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb Scenario {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getScenario' and count(parameter)=0]"
			[Register ("getScenario", "()Lcom/confirmit/mobilesdk/database/domain/ScenarioDb;", "GetGetScenarioHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/confirmit/mobilesdk/database/domain/ServerDb;", "GetGetServerHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb Survey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/interface[@name='DataModule']/method[@name='getSurvey' and count(parameter)=0]"
			[Register ("getSurvey", "()Lcom/confirmit/mobilesdk/database/domain/SurveyDb;", "GetGetSurveyHandler:Com.Confirmit.Mobilesdk.Database.IDataModuleInvoker, Forsta")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/DataModule", DoNotGenerateAcw=true)]
	internal partial class IDataModuleInvoker : global::Java.Lang.Object, IDataModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/DataModule", typeof (IDataModuleInvoker));

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

		public static IDataModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.DataModule'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPref;
#pragma warning disable 0169
		static Delegate GetGetPrefHandler ()
		{
			if (cb_getPref == null)
				cb_getPref = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPref);
			return cb_getPref;
		}

		static IntPtr n_GetPref (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pref);
		}
#pragma warning restore 0169

		IntPtr id_getPref;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IPrefDb Pref {
			get {
				if (id_getPref == IntPtr.Zero)
					id_getPref = JNIEnv.GetMethodID (class_ref, "getPref", "()Lcom/confirmit/mobilesdk/database/domain/PrefDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IPrefDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPref), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProgram;
#pragma warning disable 0169
		static Delegate GetGetProgramHandler ()
		{
			if (cb_getProgram == null)
				cb_getProgram = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProgram);
			return cb_getProgram;
		}

		static IntPtr n_GetProgram (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Program);
		}
#pragma warning restore 0169

		IntPtr id_getProgram;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb Program {
			get {
				if (id_getProgram == IntPtr.Zero)
					id_getProgram = JNIEnv.GetMethodID (class_ref, "getProgram", "()Lcom/confirmit/mobilesdk/database/domain/ProgramDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgram), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProgramPref;
#pragma warning disable 0169
		static Delegate GetGetProgramPrefHandler ()
		{
			if (cb_getProgramPref == null)
				cb_getProgramPref = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProgramPref);
			return cb_getProgramPref;
		}

		static IntPtr n_GetProgramPref (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgramPref);
		}
#pragma warning restore 0169

		IntPtr id_getProgramPref;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb ProgramPref {
			get {
				if (id_getProgramPref == IntPtr.Zero)
					id_getProgramPref = JNIEnv.GetMethodID (class_ref, "getProgramPref", "()Lcom/confirmit/mobilesdk/database/domain/ProgramPrefDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgramPref), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRespondent;
#pragma warning disable 0169
		static Delegate GetGetRespondentHandler ()
		{
			if (cb_getRespondent == null)
				cb_getRespondent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRespondent);
			return cb_getRespondent;
		}

		static IntPtr n_GetRespondent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Respondent);
		}
#pragma warning restore 0169

		IntPtr id_getRespondent;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb Respondent {
			get {
				if (id_getRespondent == IntPtr.Zero)
					id_getRespondent = JNIEnv.GetMethodID (class_ref, "getRespondent", "()Lcom/confirmit/mobilesdk/database/domain/RespondentDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRespondent), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lcom/confirmit/mobilesdk/database/domain/ResponseDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScenario;
#pragma warning disable 0169
		static Delegate GetGetScenarioHandler ()
		{
			if (cb_getScenario == null)
				cb_getScenario = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScenario);
			return cb_getScenario;
		}

		static IntPtr n_GetScenario (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Scenario);
		}
#pragma warning restore 0169

		IntPtr id_getScenario;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb Scenario {
			get {
				if (id_getScenario == IntPtr.Zero)
					id_getScenario = JNIEnv.GetMethodID (class_ref, "getScenario", "()Lcom/confirmit/mobilesdk/database/domain/ScenarioDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScenario), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServer;
#pragma warning disable 0169
		static Delegate GetGetServerHandler ()
		{
			if (cb_getServer == null)
				cb_getServer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServer);
			return cb_getServer;
		}

		static IntPtr n_GetServer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		IntPtr id_getServer;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb Server {
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/confirmit/mobilesdk/database/domain/ServerDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSurvey;
#pragma warning disable 0169
		static Delegate GetGetSurveyHandler ()
		{
			if (cb_getSurvey == null)
				cb_getSurvey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurvey);
			return cb_getSurvey;
		}

		static IntPtr n_GetSurvey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Survey);
		}
#pragma warning restore 0169

		IntPtr id_getSurvey;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb Survey {
			get {
				if (id_getSurvey == IntPtr.Zero)
					id_getSurvey = JNIEnv.GetMethodID (class_ref, "getSurvey", "()Lcom/confirmit/mobilesdk/database/domain/SurveyDb;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurvey), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
