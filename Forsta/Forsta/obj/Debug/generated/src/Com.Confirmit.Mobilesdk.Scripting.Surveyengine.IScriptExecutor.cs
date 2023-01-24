using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine']/interface[@name='ScriptExecutor']"
	[Register ("com/confirmit/mobilesdk/scripting/surveyengine/ScriptExecutor", "", "Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutorInvoker")]
	public partial interface IScriptExecutor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine']/interface[@name='ScriptExecutor']/method[@name='load' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='java.lang.String']]"
		[Register ("load", "(Lcom/confirmit/mobilesdk/surveyengine/i;Ljava/lang/String;)V", "GetLoad_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutorInvoker, Forsta")]
		void Load (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine']/interface[@name='ScriptExecutor']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("run", "(Ljava/lang/String;)V", "GetRun_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutorInvoker, Forsta")]
		void Run (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine']/interface[@name='ScriptExecutor']/method[@name='runResult' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("runResult", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "GetRunResult_Ljava_lang_Class_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutorInvoker, Forsta")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object RunResult (global::Java.Lang.Class p0, string p1);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/ScriptExecutor", DoNotGenerateAcw=true)]
	internal partial class IScriptExecutorInvoker : global::Java.Lang.Object, IScriptExecutor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/ScriptExecutor", typeof (IScriptExecutorInvoker));

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

		public static IScriptExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScriptExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.scripting.surveyengine.ScriptExecutor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScriptExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_Handler ()
		{
			if (cb_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_ == null)
				cb_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_);
			return cb_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_;
		}

		static void n_Load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_;
		public unsafe void Load (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, string p1)
		{
			if (id_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Lcom/confirmit/mobilesdk/surveyengine/i;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Lcom_confirmit_mobilesdk_surveyengine_i_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_run_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRun_Ljava_lang_String_Handler ()
		{
			if (cb_run_Ljava_lang_String_ == null)
				cb_run_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Run_Ljava_lang_String_);
			return cb_run_Ljava_lang_String_;
		}

		static void n_Run_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0);
		}
#pragma warning restore 0169

		IntPtr id_run_Ljava_lang_String_;
		public unsafe void Run (string p0)
		{
			if (id_run_Ljava_lang_String_ == IntPtr.Zero)
				id_run_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_runResult_Ljava_lang_Class_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunResult_Ljava_lang_Class_Ljava_lang_String_Handler ()
		{
			if (cb_runResult_Ljava_lang_Class_Ljava_lang_String_ == null)
				cb_runResult_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_RunResult_Ljava_lang_Class_Ljava_lang_String_);
			return cb_runResult_Ljava_lang_Class_Ljava_lang_String_;
		}

		static IntPtr n_RunResult_Ljava_lang_Class_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunResult (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_runResult_Ljava_lang_Class_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object RunResult (global::Java.Lang.Class p0, string p1)
		{
			if (id_runResult_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_runResult_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "runResult", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_runResult_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
