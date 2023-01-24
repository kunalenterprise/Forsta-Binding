using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/packages/actions/o", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEnginePackagesActionsO : global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/packages/actions/o", typeof (SurveyEnginePackagesActionsO));

		internal static new IntPtr class_ref {
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

		internal SurveyEnginePackagesActionsO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR B ()
		{
			const string __id = "b.()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR C ()
		{
			const string __id = "c.()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR D ()
		{
			const string __id = "d.()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR E ()
		{
			const string __id = "e.()Lcom/confirmit/mobilesdk/surveyengine/packages/actions/r;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='o']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public unsafe string F ()
		{
			const string __id = "f.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
