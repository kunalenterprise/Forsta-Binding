using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ConfirmitSDK", DoNotGenerateAcw=true)]
	public sealed partial class ConfirmitSDK : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Confirmit.Mobilesdk.ConfirmitSDK Instance {
			get {
				const string __id = "INSTANCE.Lcom/confirmit/mobilesdk/ConfirmitSDK;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='ConfirmitSDK.Module']"
		[Register ("com/confirmit/mobilesdk/ConfirmitSDK$Module", "", "Com.Confirmit.Mobilesdk.ConfirmitSDK/IModuleInvoker")]
		public partial interface IModule : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='ConfirmitSDK.Module']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.confirmit.mobilesdk.ConfirmitSDK.Setup']]"
			[Register ("initialize", "(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V", "GetInitialize_Landroid_app_Application_Lcom_confirmit_mobilesdk_ConfirmitSDK_Setup_Handler:Com.Confirmit.Mobilesdk.ConfirmitSDK/IModuleInvoker, Forsta")]
			void Initialize (global::Android.App.Application application, global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup setup);

		}

		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ConfirmitSDK$Module", DoNotGenerateAcw=true)]
		internal partial class IModuleInvoker : global::Java.Lang.Object, IModule {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ConfirmitSDK$Module", typeof (IModuleInvoker));

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

			public static IModule GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IModule> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.ConfirmitSDK.Module'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.IModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ConfirmitSDK$Setup", DoNotGenerateAcw=true)]
		public sealed partial class Setup : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ConfirmitSDK$Setup", typeof (Setup));

			internal static IntPtr class_ref {
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
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal Setup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/constructor[@name='ConfirmitSDK.Setup' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
			[Register (".ctor", "(Landroid/app/Application;)V", "")]
			public unsafe Setup (global::Android.App.Application p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/app/Application;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			public unsafe global::Com.Confirmit.Mobilesdk.Core.ICoreModule CoreModule {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='getCoreModule' and count(parameter)=0]"
				[Register ("getCoreModule", "()Lcom/confirmit/mobilesdk/core/CoreModule;", "")]
				get {
					const string __id = "getCoreModule.()Lcom/confirmit/mobilesdk/core/CoreModule;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.ICoreModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='setCoreModule' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.core.CoreModule']]"
				[Register ("setCoreModule", "(Lcom/confirmit/mobilesdk/core/CoreModule;)V", "")]
				set {
					const string __id = "setCoreModule.(Lcom/confirmit/mobilesdk/core/CoreModule;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			public unsafe global::Android.Net.Uri RootPath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='getRootPath' and count(parameter)=0]"
				[Register ("getRootPath", "()Landroid/net/Uri;", "")]
				get {
					const string __id = "getRootPath.()Landroid/net/Uri;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='setRootPath' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
				[Register ("setRootPath", "(Landroid/net/Uri;)V", "")]
				set {
					const string __id = "setRootPath.(Landroid/net/Uri;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='configure' and count(parameter)=0]"
			[Register ("configure", "()V", "")]
			public unsafe void Configure ()
			{
				const string __id = "configure.()V";
				try {
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='coreModule' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.core.CoreModule']]"
			[Register ("coreModule", "(Lcom/confirmit/mobilesdk/core/CoreModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup InvokeCoreModule (global::Com.Confirmit.Mobilesdk.Core.ICoreModule module)
			{
				const string __id = "coreModule.(Lcom/confirmit/mobilesdk/core/CoreModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((module == null) ? IntPtr.Zero : ((global::Java.Lang.Object) module).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (module);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='dataModule' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.DataModule']]"
			[Register ("dataModule", "(Lcom/confirmit/mobilesdk/database/DataModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup DataModule (global::Com.Confirmit.Mobilesdk.Database.IDataModule module)
			{
				const string __id = "dataModule.(Lcom/confirmit/mobilesdk/database/DataModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((module == null) ? IntPtr.Zero : ((global::Java.Lang.Object) module).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (module);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='rootPath' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("rootPath", "(Landroid/net/Uri;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup InvokeRootPath (global::Android.Net.Uri path)
			{
				const string __id = "rootPath.(Landroid/net/Uri;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (path);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK.Setup']/method[@name='syncModule' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.sync.SyncModule']]"
			[Register ("syncModule", "(Lcom/confirmit/mobilesdk/sync/SyncModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup SyncModule (global::Com.Confirmit.Mobilesdk.Sync.ISyncModule module)
			{
				const string __id = "syncModule.(Lcom/confirmit/mobilesdk/sync/SyncModule;)Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((module == null) ? IntPtr.Zero : ((global::Java.Lang.Object) module).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (module);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ConfirmitSDK", typeof (ConfirmitSDK));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ConfirmitSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Content.Context AndroidContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']/method[@name='getAndroidContext' and count(parameter)=0]"
			[Register ("getAndroidContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getAndroidContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "")]
		public unsafe void EnableLog (bool enable)
		{
			const string __id = "enableLog.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitSDK']/method[@name='setAccessTokenProvider' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.AccessTokenProvider']]"
		[Register ("setAccessTokenProvider", "(Lcom/confirmit/mobilesdk/AccessTokenProvider;)V", "")]
		public unsafe void SetAccessTokenProvider (global::Com.Confirmit.Mobilesdk.IAccessTokenProvider provider)
		{
			const string __id = "setAccessTokenProvider.(Lcom/confirmit/mobilesdk/AccessTokenProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (provider);
			}
		}

	}
}
