using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='r']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/packages/actions/r", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEnginePackagesActionsR : global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/packages/actions/r", typeof (SurveyEnginePackagesActionsR));

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

		internal SurveyEnginePackagesActionsR (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='r']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()I", "")]
		public unsafe int B ()
		{
			const string __id = "b.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.actions']/class[@name='r']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()I", "")]
		public unsafe int C ()
		{
			const string __id = "c.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
