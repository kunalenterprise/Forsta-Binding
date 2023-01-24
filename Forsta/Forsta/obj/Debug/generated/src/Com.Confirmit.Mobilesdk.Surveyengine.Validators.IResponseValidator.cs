using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Validators {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.validators']/interface[@name='ResponseValidator']"
	[Register ("com/confirmit/mobilesdk/surveyengine/validators/ResponseValidator", "", "Com.Confirmit.Mobilesdk.Surveyengine.Validators.IResponseValidatorInvoker")]
	public partial interface IResponseValidator : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.validators']/interface[@name='ResponseValidator']/method[@name='validate' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.constraints.a'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.packages.question.a']]"
		[Register ("validate", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/constraints/a;Lcom/confirmit/mobilesdk/surveyengine/packages/question/a;)Lcom/confirmit/mobilesdk/surveyengine/managers/h;", "GetValidate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Validators.IResponseValidatorInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH Validate (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionA p2);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/validators/ResponseValidator", DoNotGenerateAcw=true)]
	internal partial class IResponseValidatorInvoker : global::Java.Lang.Object, IResponseValidator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/validators/ResponseValidator", typeof (IResponseValidatorInvoker));

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

		public static IResponseValidator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseValidator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.validators.ResponseValidator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseValidatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_;
#pragma warning disable 0169
		static Delegate GetValidate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_Handler ()
		{
			if (cb_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_ == null)
				cb_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_);
			return cb_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_;
		}

		static IntPtr n_Validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Validators.IResponseValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionA> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Validate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_;
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH Validate (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionA p2)
		{
			if (id_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_ == IntPtr.Zero)
				id_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/constraints/a;Lcom/confirmit/mobilesdk/surveyengine/packages/question/a;)Lcom/confirmit/mobilesdk/surveyengine/managers/h;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_packages_question_constraints_a_Lcom_confirmit_mobilesdk_surveyengine_packages_question_a_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
