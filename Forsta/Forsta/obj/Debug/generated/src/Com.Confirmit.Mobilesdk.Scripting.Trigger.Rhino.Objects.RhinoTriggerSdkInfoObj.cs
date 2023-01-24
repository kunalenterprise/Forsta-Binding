using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Trigger.Rhino.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/trigger/rhino/objects/RhinoTriggerSdkInfoObj", DoNotGenerateAcw=true)]
	public sealed partial class RhinoTriggerSdkInfoObj : global::Org.Mozilla.Javascript.ScriptableObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/trigger/rhino/objects/RhinoTriggerSdkInfoObj", typeof (RhinoTriggerSdkInfoObj));

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

		internal RhinoTriggerSdkInfoObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']/constructor[@name='RhinoTriggerSdkInfoObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RhinoTriggerSdkInfoObj () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public override unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']/method[@name='hostAppVersion' and count(parameter)=0]"
		[Register ("hostAppVersion", "()Ljava/lang/String;", "")]
		public unsafe string HostAppVersion ()
		{
			const string __id = "hostAppVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']/method[@name='load' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.Scriptable']]"
		[Register ("load", "(Lorg/mozilla/javascript/Scriptable;)V", "")]
		public unsafe void Load (global::Org.Mozilla.Javascript.IScriptable p0)
		{
			const string __id = "load.(Lorg/mozilla/javascript/Scriptable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerSdkInfoObj']/method[@name='sdkVersion' and count(parameter)=0]"
		[Register ("sdkVersion", "()Ljava/lang/String;", "")]
		public unsafe string SdkVersion ()
		{
			const string __id = "sdkVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
