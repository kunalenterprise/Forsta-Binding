using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='QuestionPageData']"
	[Register ("com/confirmit/mobilesdk/surveyengine/QuestionPageData", "", "Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageDataInvoker")]
	public partial interface IQuestionPageData : IJavaObject, IJavaPeerable {
		global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB Declarator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='QuestionPageData']/method[@name='getDeclarator' and count(parameter)=0]"
			[Register ("getDeclarator", "()Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;", "GetGetDeclaratorHandler:Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageDataInvoker, Forsta")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='QuestionPageData']/method[@name='setDeclarator' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.domains.b']]"
			[Register ("setDeclarator", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;)V", "GetSetDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageDataInvoker, Forsta")]
			set; 
		}

		string UpdatedValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='QuestionPageData']/method[@name='getUpdatedValue' and count(parameter)=0]"
			[Register ("getUpdatedValue", "()Ljava/lang/String;", "GetGetUpdatedValueHandler:Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageDataInvoker, Forsta")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/QuestionPageData", DoNotGenerateAcw=true)]
	internal partial class IQuestionPageDataInvoker : global::Java.Lang.Object, IQuestionPageData {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/QuestionPageData", typeof (IQuestionPageDataInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IQuestionPageData GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQuestionPageData> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.QuestionPageData'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQuestionPageDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeclarator;
#pragma warning disable 0169
		static Delegate GetGetDeclaratorHandler ()
		{
			if (cb_getDeclarator == null)
				cb_getDeclarator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclarator);
			return cb_getDeclarator;
		}

		static IntPtr n_GetDeclarator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Declarator);
		}
#pragma warning restore 0169

		static Delegate cb_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_;
#pragma warning disable 0169
		static Delegate GetSetDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_Handler ()
		{
			if (cb_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_ == null)
				cb_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_);
			return cb_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_;
		}

		static void n_SetDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Declarator = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDeclarator;
		IntPtr id_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_;
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB Declarator {
			get {
				if (id_getDeclarator == IntPtr.Zero)
					id_getDeclarator = JNIEnv.GetMethodID (class_ref, "getDeclarator", "()Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclarator), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_ == IntPtr.Zero)
					id_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_ = JNIEnv.GetMethodID (class_ref, "setDeclarator", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeclarator_Lcom_confirmit_mobilesdk_surveyengine_packages_question_domains_b_, __args);
			}
		}

		static Delegate cb_getUpdatedValue;
#pragma warning disable 0169
		static Delegate GetGetUpdatedValueHandler ()
		{
			if (cb_getUpdatedValue == null)
				cb_getUpdatedValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUpdatedValue);
			return cb_getUpdatedValue;
		}

		static IntPtr n_GetUpdatedValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IQuestionPageData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdatedValue);
		}
#pragma warning restore 0169

		IntPtr id_getUpdatedValue;
		public unsafe string UpdatedValue {
			get {
				if (id_getUpdatedValue == IntPtr.Zero)
					id_getUpdatedValue = JNIEnv.GetMethodID (class_ref, "getUpdatedValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatedValue), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
