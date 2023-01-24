using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Trigger.Rhino.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/trigger/rhino/objects/RhinoTriggerDeviceInfoObj", DoNotGenerateAcw=true)]
	public sealed partial class RhinoTriggerDeviceInfoObj : global::Org.Mozilla.Javascript.ScriptableObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/trigger/rhino/objects/RhinoTriggerDeviceInfoObj", typeof (RhinoTriggerDeviceInfoObj));

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

		internal RhinoTriggerDeviceInfoObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/constructor[@name='RhinoTriggerDeviceInfoObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RhinoTriggerDeviceInfoObj () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='getClassName' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='load' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.Scriptable']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='model' and count(parameter)=0]"
		[Register ("model", "()Ljava/lang/String;", "")]
		public unsafe string Model ()
		{
			const string __id = "model.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='os' and count(parameter)=0]"
		[Register ("os", "()Ljava/lang/String;", "")]
		public unsafe string Os ()
		{
			const string __id = "os.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='platform' and count(parameter)=0]"
		[Register ("platform", "()Ljava/lang/String;", "")]
		public unsafe string Platform ()
		{
			const string __id = "platform.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger.rhino.objects']/class[@name='RhinoTriggerDeviceInfoObj']/method[@name='uniqueId' and count(parameter)=0]"
		[Register ("uniqueId", "()Ljava/lang/String;", "")]
		public unsafe string UniqueId ()
		{
			const string __id = "uniqueId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
