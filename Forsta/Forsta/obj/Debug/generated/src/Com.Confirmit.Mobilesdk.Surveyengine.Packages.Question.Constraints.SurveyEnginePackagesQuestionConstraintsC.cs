using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/packages/question/constraints/c", DoNotGenerateAcw=true)]
	public sealed partial class SurveyEnginePackagesQuestionConstraintsC : global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/packages/question/constraints/c", typeof (SurveyEnginePackagesQuestionConstraintsC));

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

		internal SurveyEnginePackagesQuestionConstraintsC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='b' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public unsafe bool C ()
		{
			const string __id = "c.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "")]
		public unsafe bool D ()
		{
			const string __id = "d.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public unsafe bool E ()
		{
			const string __id = "e.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()I", "")]
		public unsafe int F ()
		{
			const string __id = "f.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()I", "")]
		public unsafe int G ()
		{
			const string __id = "g.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.packages.question.constraints']/class[@name='c']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Lcom/confirmit/mobilesdk/surveyengine/b;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineB H ()
		{
			const string __id = "h.()Lcom/confirmit/mobilesdk/surveyengine/b;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineB> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
