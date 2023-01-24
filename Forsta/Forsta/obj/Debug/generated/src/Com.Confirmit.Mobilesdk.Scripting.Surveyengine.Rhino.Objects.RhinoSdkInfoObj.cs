using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoSdkInfoObj']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoSdkInfoObj", DoNotGenerateAcw=true)]
	public sealed partial class RhinoSdkInfoObj : global::Org.Mozilla.Javascript.ScriptableObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoSdkInfoObj", typeof (RhinoSdkInfoObj));

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

		internal RhinoSdkInfoObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoSdkInfoObj']/constructor[@name='RhinoSdkInfoObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RhinoSdkInfoObj () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoSdkInfoObj']/method[@name='getClassName' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoSdkInfoObj']/method[@name='hostAppVersion' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoSdkInfoObj']/method[@name='sdkVersion' and count(parameter)=0]"
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
