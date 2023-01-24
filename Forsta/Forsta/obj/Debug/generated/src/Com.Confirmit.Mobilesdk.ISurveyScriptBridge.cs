using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='SurveyScriptBridge']"
	[Register ("com/confirmit/mobilesdk/SurveyScriptBridge", "", "Com.Confirmit.Mobilesdk.ISurveyScriptBridgeInvoker")]
	public partial interface ISurveyScriptBridge : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='SurveyScriptBridge']/method[@name='consoleLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("consoleLog", "(Ljava/lang/String;)V", "GetConsoleLog_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.ISurveyScriptBridgeInvoker, Forsta")]
		void ConsoleLog (string text);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/SurveyScriptBridge", DoNotGenerateAcw=true)]
	internal partial class ISurveyScriptBridgeInvoker : global::Java.Lang.Object, ISurveyScriptBridge {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/SurveyScriptBridge", typeof (ISurveyScriptBridgeInvoker));

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

		public static ISurveyScriptBridge GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyScriptBridge> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.SurveyScriptBridge'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyScriptBridgeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_consoleLog_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConsoleLog_Ljava_lang_String_Handler ()
		{
			if (cb_consoleLog_Ljava_lang_String_ == null)
				cb_consoleLog_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConsoleLog_Ljava_lang_String_);
			return cb_consoleLog_Ljava_lang_String_;
		}

		static void n_ConsoleLog_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ISurveyScriptBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.ConsoleLog (text);
		}
#pragma warning restore 0169

		IntPtr id_consoleLog_Ljava_lang_String_;
		public unsafe void ConsoleLog (string text)
		{
			if (id_consoleLog_Ljava_lang_String_ == IntPtr.Zero)
				id_consoleLog_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "consoleLog", "(Ljava/lang/String;)V");
			IntPtr native_text = JNIEnv.NewString ((string)text);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_text);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consoleLog_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_text);
		}

	}
}
