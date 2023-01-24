using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/interface[@name='SurveyFrameLifecycleListener']"
	[Register ("com/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener", "", "Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker")]
	public partial interface ISurveyFrameLifecycleListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/interface[@name='SurveyFrameLifecycleListener']/method[@name='onSurveyErrored' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyPage'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onSurveyErrored", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;Ljava/lang/Exception;)V", "GetOnSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta")]
		void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values, global::Java.Lang.Exception exception);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/interface[@name='SurveyFrameLifecycleListener']/method[@name='onSurveyFinished' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyPage'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSurveyFinished", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;)V", "GetOnSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta")]
		void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/interface[@name='SurveyFrameLifecycleListener']/method[@name='onSurveyPageReady' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyPage']]"
		[Register ("onSurveyPageReady", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;)V", "GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta")]
		void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/interface[@name='SurveyFrameLifecycleListener']/method[@name='onSurveyQuit' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSurveyQuit", "(Ljava/util/Map;)V", "GetOnSurveyQuit_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta")]
		void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> values);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener", DoNotGenerateAcw=true)]
	internal partial class ISurveyFrameLifecycleListenerInvoker : global::Java.Lang.Object, ISurveyFrameLifecycleListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener", typeof (ISurveyFrameLifecycleListenerInvoker));

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

		public static ISurveyFrameLifecycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyFrameLifecycleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyFrameLifecycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_Handler ()
		{
			if (cb_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_ == null)
				cb_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_);
			return cb_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_;
		}

		static void n_OnSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_page, IntPtr native_values, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var page = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyPage> (native_page, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyErrored (page, values, exception);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_;
		public unsafe void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values, global::Java.Lang.Exception exception)
		{
			if (id_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSurveyErrored", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;Ljava/lang/Exception;)V");
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (values);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((page == null) ? IntPtr.Zero : ((global::Java.Lang.Object) page).Handle);
			__args [1] = new JValue (native_values);
			__args [2] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_values);
		}

		static Delegate cb_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Handler ()
		{
			if (cb_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_ == null)
				cb_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_);
			return cb_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_;
		}

		static void n_OnSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_page, IntPtr native_values)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var page = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyPage> (native_page, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyFinished (page, values);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_;
		public unsafe void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values)
		{
			if (id_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_ == IntPtr.Zero)
				id_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSurveyFinished", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;)V");
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (values);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((page == null) ? IntPtr.Zero : ((global::Java.Lang.Object) page).Handle);
			__args [1] = new JValue (native_values);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_values);
		}

		static Delegate cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_;
#pragma warning disable 0169
		static Delegate GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_Handler ()
		{
			if (cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_ == null)
				cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_);
			return cb_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_;
		}

		static void n_OnSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_page)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var page = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyPage> (native_page, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyPageReady (page);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_;
		public unsafe void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page)
		{
			if (id_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_ == IntPtr.Zero)
				id_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_ = JNIEnv.GetMethodID (class_ref, "onSurveyPageReady", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((page == null) ? IntPtr.Zero : ((global::Java.Lang.Object) page).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_, __args);
		}

		static Delegate cb_onSurveyQuit_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSurveyQuit_Ljava_util_Map_Handler ()
		{
			if (cb_onSurveyQuit_Ljava_util_Map_ == null)
				cb_onSurveyQuit_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSurveyQuit_Ljava_util_Map_);
			return cb_onSurveyQuit_Ljava_util_Map_;
		}

		static void n_OnSurveyQuit_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveyQuit (values);
		}
#pragma warning restore 0169

		IntPtr id_onSurveyQuit_Ljava_util_Map_;
		public unsafe void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> values)
		{
			if (id_onSurveyQuit_Ljava_util_Map_ == IntPtr.Zero)
				id_onSurveyQuit_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSurveyQuit", "(Ljava/util/Map;)V");
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (values);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_values);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveyQuit_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_values);
		}

	}

	// event args for com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener.onSurveyErrored
	public partial class SurveyErroredEventArgs : global::System.EventArgs {
		public SurveyErroredEventArgs (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values, global::Java.Lang.Exception exception)
		{
			this.page = page;
			this.values = values;
			this.exception = exception;
		}

		global::Com.Confirmit.Mobilesdk.UI.SurveyPage page;

		public global::Com.Confirmit.Mobilesdk.UI.SurveyPage Page {
			get { return page; }
		}

		global::System.Collections.Generic.IDictionary<string, string> values;

		public global::System.Collections.Generic.IDictionary<string, string> Values {
			get { return values; }
		}

		global::Java.Lang.Exception exception;

		public global::Java.Lang.Exception Exception {
			get { return exception; }
		}

	}

	// event args for com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener.onSurveyFinished
	public partial class SurveyFinishedEventArgs : global::System.EventArgs {
		public SurveyFinishedEventArgs (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values)
		{
			this.page = page;
			this.values = values;
		}

		global::Com.Confirmit.Mobilesdk.UI.SurveyPage page;

		public global::Com.Confirmit.Mobilesdk.UI.SurveyPage Page {
			get { return page; }
		}

		global::System.Collections.Generic.IDictionary<string, string> values;

		public global::System.Collections.Generic.IDictionary<string, string> Values {
			get { return values; }
		}

	}

	// event args for com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener.onSurveyPageReady
	public partial class SurveyPageReadyEventArgs : global::System.EventArgs {
		public SurveyPageReadyEventArgs (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page)
		{
			this.page = page;
		}

		global::Com.Confirmit.Mobilesdk.UI.SurveyPage page;

		public global::Com.Confirmit.Mobilesdk.UI.SurveyPage Page {
			get { return page; }
		}

	}

	// event args for com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener.onSurveyQuit
	public partial class SurveyQuitEventArgs : global::System.EventArgs {
		public SurveyQuitEventArgs (global::System.Collections.Generic.IDictionary<string, string> values)
		{
			this.values = values;
		}

		global::System.Collections.Generic.IDictionary<string, string> values;

		public global::System.Collections.Generic.IDictionary<string, string> Values {
			get { return values; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/confirmit/mobilesdk/ui/SurveyFrameLifecycleListenerImplementor")]
	internal sealed partial class ISurveyFrameLifecycleListenerImplementor : global::Java.Lang.Object, ISurveyFrameLifecycleListener {

		object sender;

		public ISurveyFrameLifecycleListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/confirmit/mobilesdk/ui/SurveyFrameLifecycleListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<SurveyErroredEventArgs> OnSurveyErroredHandler;
		#pragma warning restore 0649

		public void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values, global::Java.Lang.Exception exception)
		{
			var __h = OnSurveyErroredHandler;
			if (__h != null)
				__h (sender, new SurveyErroredEventArgs (page, values, exception));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyFinishedEventArgs> OnSurveyFinishedHandler;
		#pragma warning restore 0649

		public void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page, global::System.Collections.Generic.IDictionary<string, string> values)
		{
			var __h = OnSurveyFinishedHandler;
			if (__h != null)
				__h (sender, new SurveyFinishedEventArgs (page, values));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyPageReadyEventArgs> OnSurveyPageReadyHandler;
		#pragma warning restore 0649

		public void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.UI.SurveyPage page)
		{
			var __h = OnSurveyPageReadyHandler;
			if (__h != null)
				__h (sender, new SurveyPageReadyEventArgs (page));
		}

		#pragma warning disable 0649
		public EventHandler<SurveyQuitEventArgs> OnSurveyQuitHandler;
		#pragma warning restore 0649

		public void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> values)
		{
			var __h = OnSurveyQuitHandler;
			if (__h != null)
				__h (sender, new SurveyQuitEventArgs (values));
		}

		internal static bool __IsEmpty (ISurveyFrameLifecycleListenerImplementor value)
		{
			return value.OnSurveyErroredHandler == null && value.OnSurveyFinishedHandler == null && value.OnSurveyPageReadyHandler == null && value.OnSurveyQuitHandler == null;
		}

	}
}
