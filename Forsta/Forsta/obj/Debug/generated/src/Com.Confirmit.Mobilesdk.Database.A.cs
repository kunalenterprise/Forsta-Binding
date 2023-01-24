using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/class[@name='a']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/a", DoNotGenerateAcw=true)]
	public sealed partial class A : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/class[@name='a']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Database.IDataModule ADataModule {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/database/DataModule;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.IDataModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/database/DataModule;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/class[@name='a']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Confirmit.Mobilesdk.Database.A C {
			get {
				const string __id = "c.Lcom/confirmit/mobilesdk/database/a;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.A> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/confirmit/mobilesdk/database/a;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/a", typeof (A));

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

		internal A (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database']/class[@name='a']/constructor[@name='a' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.DataModule']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/database/DataModule;)V", "")]
		public unsafe A (global::Com.Confirmit.Mobilesdk.Database.IDataModule p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/database/DataModule;)V";

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

	}
}
