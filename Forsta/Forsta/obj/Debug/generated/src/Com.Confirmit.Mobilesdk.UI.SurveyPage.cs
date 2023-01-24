using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SurveyPage", DoNotGenerateAcw=true)]
	public sealed partial class SurveyPage : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SurveyPage", typeof (SurveyPage));

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

		internal SurveyPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/constructor[@name='SurveyPage' and count(parameter)=6 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.k'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends com.confirmit.mobilesdk.surveyengine.packages.question.j&gt;'] and parameter[5][@type='com.confirmit.mobilesdk.surveyengine.o'] and parameter[6][@type='java.util.Map&lt;java.lang.String, ? extends java.util.List&lt;com.confirmit.mobilesdk.surveyengine.managers.h&gt;&gt;']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V", "")]
		public unsafe SurveyPage (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p3, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p4, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ>.ToLocalJniHandle (p3);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>>.ToLocalJniHandle (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (native_p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/constructor[@name='SurveyPage' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.m']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;)V", "")]
		public unsafe SurveyPage (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;)V";

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

		public unsafe string BackwardText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getBackwardText' and count(parameter)=0]"
			[Register ("getBackwardText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBackwardText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ForwardText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getForwardText' and count(parameter)=0]"
			[Register ("getForwardText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getForwardText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string OkText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getOkText' and count(parameter)=0]"
			[Register ("getOkText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOkText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.UI.Questions.IQuestion> Questions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getQuestions' and count(parameter)=0]"
			[Register ("getQuestions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getQuestions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.UI.Questions.IQuestion>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool ShowBackward {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getShowBackward' and count(parameter)=0]"
			[Register ("getShowBackward", "()Z", "")]
			get {
				const string __id = "getShowBackward.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool ShowForward {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getShowForward' and count(parameter)=0]"
			[Register ("getShowForward", "()Z", "")]
			get {
				const string __id = "getShowForward.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool ShowOk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getShowOk' and count(parameter)=0]"
			[Register ("getShowOk", "()Z", "")]
			get {
				const string __id = "getShowOk.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;", "")]
			get {
				const string __id = "getText.()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.questions.QuestionText']]"
			[Register ("setText", "(Lcom/confirmit/mobilesdk/ui/questions/QuestionText;)V", "")]
			set {
				const string __id = "setText.(Lcom/confirmit/mobilesdk/ui/questions/QuestionText;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;", "")]
			get {
				const string __id = "getTitle.()Lcom/confirmit/mobilesdk/ui/questions/QuestionText;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.Questions.QuestionText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyPage']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.questions.QuestionText']]"
			[Register ("setTitle", "(Lcom/confirmit/mobilesdk/ui/questions/QuestionText;)V", "")]
			set {
				const string __id = "setTitle.(Lcom/confirmit/mobilesdk/ui/questions/QuestionText;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
