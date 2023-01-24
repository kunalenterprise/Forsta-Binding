using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/interface[@name='SyncModule']"
	[Register ("com/confirmit/mobilesdk/sync/SyncModule", "", "Com.Confirmit.Mobilesdk.Sync.ISyncModuleInvoker")]
	public partial interface ISyncModule : global::Com.Confirmit.Mobilesdk.ConfirmitSDK.IModule {
		global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync']/interface[@name='SyncModule']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/confirmit/mobilesdk/sync/request/ApiRequestProvider;", "GetGetRequestHandler:Com.Confirmit.Mobilesdk.Sync.ISyncModuleInvoker, Forsta")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/SyncModule", DoNotGenerateAcw=true)]
	internal partial class ISyncModuleInvoker : global::Java.Lang.Object, ISyncModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/SyncModule", typeof (ISyncModuleInvoker));

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

		public static ISyncModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.sync.SyncModule'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.ISyncModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		IntPtr id_getRequest;
		public unsafe global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider Request {
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/confirmit/mobilesdk/sync/request/ApiRequestProvider;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.ISyncModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
