using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI.Questions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/questions/NumericQuestion", DoNotGenerateAcw=true)]
	public sealed partial class NumericQuestion : global::Com.Confirmit.Mobilesdk.UI.Questions.DefaultQuestion {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion.WhenMappings']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/questions/NumericQuestion$WhenMappings", DoNotGenerateAcw=true)]
		public new sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/questions/NumericQuestion$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/questions/NumericQuestion", typeof (NumericQuestion));

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

		internal NumericQuestion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/constructor[@name='NumericQuestion' and count(parameter)=4 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.ui.b'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.packages.question.a'] and parameter[4][@type='java.util.List&lt;com.confirmit.mobilesdk.surveyengine.managers.h&gt;']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/ui/b;Lcom/confirmit/mobilesdk/surveyengine/packages/question/a;Ljava/util/List;)V", "")]
		public unsafe NumericQuestion (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.UI.UIB p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionA p2, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/ui/b;Lcom/confirmit/mobilesdk/surveyengine/packages/question/a;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.NumericAppearance Apperance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='getApperance' and count(parameter)=0]"
			[Register ("getApperance", "()Lcom/confirmit/mobilesdk/ui/NumericAppearance;", "")]
			get {
				const string __id = "getApperance.()Lcom/confirmit/mobilesdk/ui/NumericAppearance;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.NumericAppearance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Double DoubleValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='getDoubleValue' and count(parameter)=0]"
			[Register ("getDoubleValue", "()Ljava/lang/Double;", "")]
			get {
				const string __id = "getDoubleValue.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer IntValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='getIntValue' and count(parameter)=0]"
			[Register ("getIntValue", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getIntValue.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Com.Confirmit.Mobilesdk.UI.QuestionType NodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='getNodeType' and count(parameter)=0]"
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

		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setValue", "(Ljava/lang/Double;)V", "")]
		public unsafe void SetValue (global::Java.Lang.Double p0)
		{
			const string __id = "setValue.(Ljava/lang/Double;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui.questions']/class[@name='NumericQuestion']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setValue", "(Ljava/lang/Integer;)V", "")]
		public unsafe void SetValue (global::Java.Lang.Integer p0)
		{
			const string __id = "setValue.(Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
