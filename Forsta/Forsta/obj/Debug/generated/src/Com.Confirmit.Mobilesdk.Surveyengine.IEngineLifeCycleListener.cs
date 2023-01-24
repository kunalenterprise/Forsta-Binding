using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineLifeCycleListener']"
	[Register ("com/confirmit/mobilesdk/surveyengine/EngineLifeCycleListener", "", "Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker")]
	public partial interface IEngineLifeCycleListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineLifeCycleListener']/method[@name='onSurveyErrored' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.m'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onSurveyErrored", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;Ljava/lang/Exception;)V", "GetOnSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta")]
		void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Exception p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineLifeCycleListener']/method[@name='onSurveyFinished' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.m'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSurveyFinished", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;)V", "GetOnSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta")]
		void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineLifeCycleListener']/method[@name='onSurveyPageReady' and count(parameter)=5 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.k'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends com.confirmit.mobilesdk.surveyengine.packages.question.j&gt;'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.o'] and parameter[5][@type='java.util.Map&lt;java.lang.String, ? extends java.util.List&lt;com.confirmit.mobilesdk.surveyengine.managers.h&gt;&gt;']]"
		[Register ("onSurveyPageReady", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V", "GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta")]
		void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/interface[@name='EngineLifeCycleListener']/method[@name='onSurveyQuit' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSurveyQuit", "(Ljava/util/Map;)V", "GetOnSurveyQuit_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta")]
		void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/EngineLifeCycleListener", DoNotGenerateAcw=true)]
	internal partial class IEngineLifeCycleListenerInvoker : global::Java.Lang.Object, IEngineLifeCycleListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/EngineLifeCycleListener", typeof (IEngineLifeCycleListenerInvoker));

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

		public static IEngineLifeCycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineLifeCycleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineLifeCycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_Handler ()
		{
			if (cb_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_ == null)
				cb_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_);
			return cb_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_;
		}

		static void n_OnSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyErrored (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_;
		public unsafe void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Exception p2)
		{
			if (id_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSurveyErrored", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;Ljava/lang/Exception;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Handler ()
		{
			if (cb_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_ == null)
				cb_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_);
			return cb_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_;
		}

		static void n_OnSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyFinished (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_;
		public unsafe void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_ == IntPtr.Zero)
				id_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSurveyFinished", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_Handler ()
		{
			if (cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_ == null)
				cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_OnSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_);
			return cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_;
		}

		static void n_OnSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyPageReady (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_;
		public unsafe void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4)
		{
			if (id_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_ == IntPtr.Zero)
				id_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSurveyPageReady", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ>.ToLocalJniHandle (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_onSurveyQuit_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSurveyQuit_Ljava_util_Map_Handler ()
		{
			if (cb_onSurveyQuit_Ljava_util_Map_ == null)
				cb_onSurveyQuit_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSurveyQuit_Ljava_util_Map_);
			return cb_onSurveyQuit_Ljava_util_Map_;
		}

		static void n_OnSurveyQuit_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyQuit (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyQuit_Ljava_util_Map_;
		public unsafe void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_onSurveyQuit_Ljava_util_Map_ == IntPtr.Zero)
				id_onSurveyQuit_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSurveyQuit", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyQuit_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener.onSurveyErrored
	public partial class SurveyErroredEventArgs : global::System.EventArgs {
		public SurveyErroredEventArgs (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Exception p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0;

		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IDictionary<string, string> p1;

		public global::System.Collections.Generic.IDictionary<string, string> P1 {
			get { return p1; }
		}

		global::Java.Lang.Exception p2;

		public global::Java.Lang.Exception P2 {
			get { return p2; }
		}

	}

	// event args for com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener.onSurveyFinished
	public partial class SurveyFinishedEventArgs : global::System.EventArgs {
		public SurveyFinishedEventArgs (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0;

		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IDictionary<string, string> p1;

		public global::System.Collections.Generic.IDictionary<string, string> P1 {
			get { return p1; }
		}

	}

	// event args for com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener.onSurveyPageReady
	public partial class SurveyPageReadyEventArgs : global::System.EventArgs {
		public SurveyPageReadyEventArgs (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0;

		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;

		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2;

		public global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> P2 {
			get { return p2; }
		}

		global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3;

		public global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO P3 {
			get { return p3; }
		}

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4;

		public global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> P4 {
			get { return p4; }
		}

	}

	// event args for com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener.onSurveyQuit
	public partial class SurveyQuitEventArgs : global::System.EventArgs {
		public SurveyQuitEventArgs (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IDictionary<string, string> p0;

		public global::System.Collections.Generic.IDictionary<string, string> P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/confirmit/mobilesdk/surveyengine/EngineLifeCycleListenerImplementor")]
	internal sealed partial class IEngineLifeCycleListenerImplementor : global::Java.Lang.Object, IEngineLifeCycleListener {

		object sender;

		public IEngineLifeCycleListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/confirmit/mobilesdk/surveyengine/EngineLifeCycleListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<SurveyErroredEventArgs> OnSurveyErroredHandler;
		#pragma warning restore 0649

		public void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Exception p2)
		{
			var __h = OnSurveyErroredHandler;
			if (__h != null)
				__h (sender, new SurveyErroredEventArgs (p0, p1, p2));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyFinishedEventArgs> OnSurveyFinishedHandler;
		#pragma warning restore 0649

		public void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			var __h = OnSurveyFinishedHandler;
			if (__h != null)
				__h (sender, new SurveyFinishedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyPageReadyEventArgs> OnSurveyPageReadyHandler;
		#pragma warning restore 0649

		public void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4)
		{
			var __h = OnSurveyPageReadyHandler;
			if (__h != null)
				__h (sender, new SurveyPageReadyEventArgs (p0, p1, p2, p3, p4));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyQuitEventArgs> OnSurveyQuitHandler;
		#pragma warning restore 0649

		public void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			var __h = OnSurveyQuitHandler;
			if (__h != null)
				__h (sender, new SurveyQuitEventArgs (p0));
		}

		internal static bool __IsEmpty (IEngineLifeCycleListenerImplementor value)
		{
			return value.OnSurveyErroredHandler == null && value.OnSurveyFinishedHandler == null && value.OnSurveyPageReadyHandler == null && value.OnSurveyQuitHandler == null;
		}

	}
}
