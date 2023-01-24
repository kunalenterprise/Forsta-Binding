using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stateaction {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.runner.stateaction']/interface[@name='StateActionRunner']"
	[Register ("com/confirmit/mobilesdk/surveyengine/runner/stateaction/StateActionRunner", "", "Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stateaction.IStateActionRunnerInvoker")]
	public partial interface IStateActionRunner : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine.runner.stateaction']/interface[@name='StateActionRunner']/method[@name='run' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.runner.a'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.packages.e']]"
		[Register ("run", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/runner/a;Lcom/confirmit/mobilesdk/surveyengine/packages/e;)V", "GetRun_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_Handler:Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stateaction.IStateActionRunnerInvoker, Forsta")]
		void Run (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.SurveyEngineRunnerA p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE p2);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/runner/stateaction/StateActionRunner", DoNotGenerateAcw=true)]
	internal partial class IStateActionRunnerInvoker : global::Java.Lang.Object, IStateActionRunner {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/runner/stateaction/StateActionRunner", typeof (IStateActionRunnerInvoker));

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

		public static IStateActionRunner GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStateActionRunner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.runner.stateaction.StateActionRunner'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStateActionRunnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_;
#pragma warning disable 0169
		static Delegate GetRun_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_Handler ()
		{
			if (cb_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_ == null)
				cb_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_);
			return cb_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_;
		}

		static void n_Run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stateaction.IStateActionRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.SurveyEngineRunnerA> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_;
		public unsafe void Run (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.SurveyEngineRunnerA p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE p2)
		{
			if (id_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_ == IntPtr.Zero)
				id_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_ = JNIEnv.GetMethodID (class_ref, "run", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/runner/a;Lcom/confirmit/mobilesdk/surveyengine/packages/e;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Lcom_confirmit_mobilesdk_surveyengine_i_Lcom_confirmit_mobilesdk_surveyengine_runner_a_Lcom_confirmit_mobilesdk_surveyengine_packages_e_, __args);
		}

	}
}
