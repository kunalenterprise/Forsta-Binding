using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Trigger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/class[@name='d']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/trigger/d", DoNotGenerateAcw=true)]
	public sealed partial class TriggerD : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/class[@name='d']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Trigger.ITriggerModule A {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/trigger/TriggerModule;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.ITriggerModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/trigger/TriggerModule;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/class[@name='d']/field[@name='b']"
		[Register ("b")]
		public static global::Com.Confirmit.Mobilesdk.Trigger.TriggerD B {
			get {
				const string __id = "b.Lcom/confirmit/mobilesdk/trigger/d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Trigger.TriggerD> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/confirmit/mobilesdk/trigger/d;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/trigger/d", typeof (TriggerD));

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

		internal TriggerD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.trigger']/class[@name='d']/constructor[@name='d' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.trigger.TriggerModule']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/trigger/TriggerModule;)V", "")]
		public unsafe TriggerD (global::Com.Confirmit.Mobilesdk.Trigger.ITriggerModule p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/trigger/TriggerModule;)V";

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
