using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI.Questions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='QuestionAnswer']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/questions/QuestionAnswer", DoNotGenerateAcw=true)]
	public sealed partial class QuestionAnswer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/questions/QuestionAnswer", typeof (QuestionAnswer));

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

		internal QuestionAnswer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionAnswer> Answers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='QuestionAnswer']/method[@name='getAnswers' and count(parameter)=0]"
			[Register ("getAnswers", "()Ljava/util/List;", "")]
			get {
				const string __id = "getAnswers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionAnswer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='QuestionAnswer']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='QuestionAnswer']/method[@name='isHeader' and count(parameter)=0]"
			[Register ("isHeader", "()Z", "")]
			get {
				const string __id = "isHeader.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='QuestionAnswer']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;", "")]
			get {
				const string __id = "getText.()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
