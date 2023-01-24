using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='f']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/f", DoNotGenerateAcw=true)]
	public partial class CommonExprobF : global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/f", typeof (CommonExprobF));

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

		protected CommonExprobF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='f']/constructor[@name='f' and count(parameter)=4 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.j'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.packages.question.domains.b'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;Ljava/util/List;)V", "")]
		public unsafe CommonExprobF (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB p2, global::System.Collections.Generic.IList<string> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
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

	}
}
