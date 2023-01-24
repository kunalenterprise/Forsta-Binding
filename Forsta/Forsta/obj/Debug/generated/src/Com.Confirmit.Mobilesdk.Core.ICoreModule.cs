using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.core']/interface[@name='CoreModule']"
	[Register ("com/confirmit/mobilesdk/core/CoreModule", "", "Com.Confirmit.Mobilesdk.Core.ICoreModuleInvoker")]
	public partial interface ICoreModule : global::Com.Confirmit.Mobilesdk.ConfirmitSDK.IModule {
		global::Com.Confirmit.Mobilesdk.Core.CoreD Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core']/interface[@name='CoreModule']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lcom/confirmit/mobilesdk/core/d;", "GetGetDeviceHandler:Com.Confirmit.Mobilesdk.Core.ICoreModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Core.CoreE File {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core']/interface[@name='CoreModule']/method[@name='getFile' and count(parameter)=0]"
			[Register ("getFile", "()Lcom/confirmit/mobilesdk/core/e;", "GetGetFileHandler:Com.Confirmit.Mobilesdk.Core.ICoreModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Core.CoreG Packages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core']/interface[@name='CoreModule']/method[@name='getPackages' and count(parameter)=0]"
			[Register ("getPackages", "()Lcom/confirmit/mobilesdk/core/g;", "GetGetPackagesHandler:Com.Confirmit.Mobilesdk.Core.ICoreModuleInvoker, Forsta")]
			get; 
		}

		global::Com.Confirmit.Mobilesdk.Core.CoreI Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core']/interface[@name='CoreModule']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Lcom/confirmit/mobilesdk/core/i;", "GetGetPathHandler:Com.Confirmit.Mobilesdk.Core.ICoreModuleInvoker, Forsta")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/core/CoreModule", DoNotGenerateAcw=true)]
	internal partial class ICoreModuleInvoker : global::Java.Lang.Object, ICoreModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/core/CoreModule", typeof (ICoreModuleInvoker));

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

		public static ICoreModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICoreModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.core.CoreModule'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICoreModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		IntPtr id_getDevice;
		public unsafe global::Com.Confirmit.Mobilesdk.Core.CoreD Device {
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Lcom/confirmit/mobilesdk/core/d;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.CoreD> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFile;
#pragma warning disable 0169
		static Delegate GetGetFileHandler ()
		{
			if (cb_getFile == null)
				cb_getFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFile);
			return cb_getFile;
		}

		static IntPtr n_GetFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.File);
		}
#pragma warning restore 0169

		IntPtr id_getFile;
		public unsafe global::Com.Confirmit.Mobilesdk.Core.CoreE File {
			get {
				if (id_getFile == IntPtr.Zero)
					id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/confirmit/mobilesdk/core/e;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.CoreE> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPackages;
#pragma warning disable 0169
		static Delegate GetGetPackagesHandler ()
		{
			if (cb_getPackages == null)
				cb_getPackages = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackages);
			return cb_getPackages;
		}

		static IntPtr n_GetPackages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Packages);
		}
#pragma warning restore 0169

		IntPtr id_getPackages;
		public unsafe global::Com.Confirmit.Mobilesdk.Core.CoreG Packages {
			get {
				if (id_getPackages == IntPtr.Zero)
					id_getPackages = JNIEnv.GetMethodID (class_ref, "getPackages", "()Lcom/confirmit/mobilesdk/core/g;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.CoreG> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackages), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Path);
		}
#pragma warning restore 0169

		IntPtr id_getPath;
		public unsafe global::Com.Confirmit.Mobilesdk.Core.CoreI Path {
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Lcom/confirmit/mobilesdk/core/i;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.CoreI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
