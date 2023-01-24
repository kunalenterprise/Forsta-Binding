using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI.Questions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/questions/InfoQuestion", DoNotGenerateAcw=true)]
	public sealed partial class InfoQuestion : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.UI.Questions.IQuestion {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/questions/InfoQuestion", typeof (InfoQuestion));

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

		internal InfoQuestion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/constructor[@name='InfoQuestion' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.b']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/b;)V", "")]
		public unsafe InfoQuestion (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionB p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/b;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Instruction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/method[@name='getInstruction' and count(parameter)=0]"
			[Register ("getInstruction", "()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;", "")]
			get {
				const string __id = "getInstruction.()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.QuestionType NodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/method[@name='getNodeType' and count(parameter)=0]"
			[Register ("getNodeType", "()Lcom/confirmit/mobilesdk/ui/QuestionType;", "")]
			get {
				const string __id = "getNodeType.()Lcom/confirmit/mobilesdk/ui/QuestionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.QuestionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/method[@name='getText' and count(parameter)=0]"
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

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='InfoQuestion']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;", "")]
			get {
				const string __id = "getTitle.()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
