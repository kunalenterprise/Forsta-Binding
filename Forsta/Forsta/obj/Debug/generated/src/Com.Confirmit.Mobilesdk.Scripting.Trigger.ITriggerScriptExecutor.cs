using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Trigger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']"
	[Register ("com/confirmit/mobilesdk/scripting/trigger/TriggerScriptExecutor", "", "Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker")]
	public partial interface ITriggerScriptExecutor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']/method[@name='loadScript' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("loadScript", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "GetLoadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler:Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker, Forsta")]
		void LoadScript (string p0, string p1, string p2, long p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']/method[@name='notifyCfr' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Exception'] and parameter[8][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("notifyCfr", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/Exception;Ljava/util/Map;)V", "GetNotifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker, Forsta")]
		void NotifyCfr (string p0, string p1, string p2, long p3, string p4, string p5, global::Java.Lang.Exception p6, global::System.Collections.Generic.IDictionary<string, string> p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']/method[@name='notifyEvent' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[6][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("notifyEvent", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", "GetNotifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker, Forsta")]
		void NotifyEvent (string p0, string p1, long p2, string p3, global::System.Collections.Generic.IDictionary<string, string> p4, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']/method[@name='triggerOnStartEvent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("triggerOnStartEvent", "(Ljava/lang/String;Ljava/lang/String;J)V", "GetTriggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_JHandler:Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker, Forsta")]
		void TriggerOnStartEvent (string p0, string p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.trigger']/interface[@name='TriggerScriptExecutor']/method[@name='unloadScript' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("unloadScript", "(Ljava/lang/String;Ljava/lang/String;J)V", "GetUnloadScript_Ljava_lang_String_Ljava_lang_String_JHandler:Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutorInvoker, Forsta")]
		void UnloadScript (string p0, string p1, long p2);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/trigger/TriggerScriptExecutor", DoNotGenerateAcw=true)]
	internal partial class ITriggerScriptExecutorInvoker : global::Java.Lang.Object, ITriggerScriptExecutor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/trigger/TriggerScriptExecutor", typeof (ITriggerScriptExecutorInvoker));

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

		public static ITriggerScriptExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITriggerScriptExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.scripting.trigger.TriggerScriptExecutor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITriggerScriptExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetLoadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLJ_V) n_LoadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_LoadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadScript (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe void LoadScript (string p0, string p1, string p2, long p3)
		{
			if (id_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "loadScript", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadScript_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetNotifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_Handler ()
		{
			if (cb_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_ == null)
				cb_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLJLLLL_V) n_NotifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_);
			return cb_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_;
		}

		static void n_NotifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p6, JniHandleOwnership.DoNotTransfer);
			var p7 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCfr (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		IntPtr id_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_;
		public unsafe void NotifyCfr (string p0, string p1, string p2, long p3, string p4, string p5, global::Java.Lang.Exception p6, global::System.Collections.Generic.IDictionary<string, string> p7)
		{
			if (id_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_ == IntPtr.Zero)
				id_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "notifyCfr", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/Exception;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p4 = JNIEnv.NewString ((string)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string)p5);
			IntPtr native_p7 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p6).Handle);
			__args [7] = new JValue (native_p7);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyCfr_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p7);
		}

		static Delegate cb_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetNotifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJLLL_V) n_NotifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_);
			return cb_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_NotifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.NotifyEvent (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		public unsafe void NotifyEvent (string p0, string p1, long p2, string p3, global::System.Collections.Generic.IDictionary<string, string> p4, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p5)
		{
			if (id_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "notifyEvent", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyEvent_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_util_Map_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetTriggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_TriggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J);
			return cb_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_TriggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TriggerOnStartEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe void TriggerOnStartEvent (string p0, string p1, long p2)
		{
			if (id_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "triggerOnStartEvent", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_triggerOnStartEvent_Ljava_lang_String_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unloadScript_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetUnloadScript_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_unloadScript_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_unloadScript_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_UnloadScript_Ljava_lang_String_Ljava_lang_String_J);
			return cb_unloadScript_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_UnloadScript_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Trigger.ITriggerScriptExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnloadScript (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_unloadScript_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe void UnloadScript (string p0, string p1, long p2)
		{
			if (id_unloadScript_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_unloadScript_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "unloadScript", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unloadScript_Ljava_lang_String_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
