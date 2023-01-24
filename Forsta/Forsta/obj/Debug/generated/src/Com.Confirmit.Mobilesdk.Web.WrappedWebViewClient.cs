using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Web {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='WrappedWebViewClient']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/WrappedWebViewClient", DoNotGenerateAcw=true)]
	public sealed partial class WrappedWebViewClient : global::AndroidX.WebKit.WebViewClientCompat {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='WrappedWebViewClient']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Utils.UtilsI WrappedWebViewClientObjA {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/utils/i;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Utils.UtilsI> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/utils/i;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='WrappedWebViewClient']/field[@name='b']"
		[Register ("b")]
		public static IList<Kotlin.Reflect.IKProperty> B {
			get {
				const string __id = "b.[Lkotlin/reflect/KProperty;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Kotlin.Reflect.IKProperty>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']"
		[Register ("com/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener", "", "Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker")]
		public partial interface IOnWebViewListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']/method[@name='doUpdateVisitedHistory' and count(parameter)=3 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
			[Register ("doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", "GetDoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_ZHandler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta")]
			void DoUpdateVisitedHistory (global::Android.Webkit.WebView view, string url, bool isReload);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='android.webkit.WebResourceRequest'] and parameter[2][@type='androidx.webkit.WebResourceErrorCompat']]"
			[Register ("onError", "(Landroid/webkit/WebResourceRequest;Landroidx/webkit/WebResourceErrorCompat;)V", "GetOnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta")]
			void OnError (global::Android.Webkit.IWebResourceRequest request, global::AndroidX.WebKit.WebResourceErrorCompat error);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']/method[@name='onLoadResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onLoadResource", "(Ljava/lang/String;)V", "GetOnLoadResource_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta")]
			void OnLoadResource (string url);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']/method[@name='onPageFinished' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onPageFinished", "(Ljava/lang/String;)V", "GetOnPageFinished_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta")]
			void OnPageFinished (string url);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/interface[@name='WrappedWebViewClient.OnWebViewListener']/method[@name='onShouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
			[Register ("onShouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta")]
			bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url);

		}

		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener", DoNotGenerateAcw=true)]
		internal partial class IOnWebViewListenerInvoker : global::Java.Lang.Object, IOnWebViewListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener", typeof (IOnWebViewListenerInvoker));

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

			public static IOnWebViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnWebViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnWebViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetDoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_ZHandler ()
			{
				if (cb_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z == null)
					cb_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_DoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z);
				return cb_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z;
			}

			static void n_DoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url, bool isReload)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				__this.DoUpdateVisitedHistory (view, url, isReload);
			}
#pragma warning restore 0169

			IntPtr id_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z;
			public unsafe void DoUpdateVisitedHistory (global::Android.Webkit.WebView view, string url, bool isReload)
			{
				if (id_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z == IntPtr.Zero)
					id_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V");
				IntPtr native_url = JNIEnv.NewString ((string)url);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JValue (native_url);
				__args [2] = new JValue (isReload);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_Z, __args);
				JNIEnv.DeleteLocalRef (native_url);
			}

			static Delegate cb_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_;
#pragma warning disable 0169
			static Delegate GetOnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_Handler ()
			{
				if (cb_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_ == null)
					cb_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_);
				return cb_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_;
			}

			static void n_OnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_error)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var request = (global::Android.Webkit.IWebResourceRequest)global::Java.Lang.Object.GetObject<global::Android.Webkit.IWebResourceRequest> (native_request, JniHandleOwnership.DoNotTransfer);
				var error = global::Java.Lang.Object.GetObject<global::AndroidX.WebKit.WebResourceErrorCompat> (native_error, JniHandleOwnership.DoNotTransfer);
				__this.OnError (request, error);
			}
#pragma warning restore 0169

			IntPtr id_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_;
			public unsafe void OnError (global::Android.Webkit.IWebResourceRequest request, global::AndroidX.WebKit.WebResourceErrorCompat error)
			{
				if (id_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_ == IntPtr.Zero)
					id_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_ = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/webkit/WebResourceRequest;Landroidx/webkit/WebResourceErrorCompat;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_, __args);
			}

			static Delegate cb_onLoadResource_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLoadResource_Ljava_lang_String_Handler ()
			{
				if (cb_onLoadResource_Ljava_lang_String_ == null)
					cb_onLoadResource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnLoadResource_Ljava_lang_String_);
				return cb_onLoadResource_Ljava_lang_String_;
			}

			static void n_OnLoadResource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadResource (url);
			}
#pragma warning restore 0169

			IntPtr id_onLoadResource_Ljava_lang_String_;
			public unsafe void OnLoadResource (string url)
			{
				if (id_onLoadResource_Ljava_lang_String_ == IntPtr.Zero)
					id_onLoadResource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLoadResource", "(Ljava/lang/String;)V");
				IntPtr native_url = JNIEnv.NewString ((string)url);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadResource_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_url);
			}

			static Delegate cb_onPageFinished_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPageFinished_Ljava_lang_String_Handler ()
			{
				if (cb_onPageFinished_Ljava_lang_String_ == null)
					cb_onPageFinished_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPageFinished_Ljava_lang_String_);
				return cb_onPageFinished_Ljava_lang_String_;
			}

			static void n_OnPageFinished_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				__this.OnPageFinished (url);
			}
#pragma warning restore 0169

			IntPtr id_onPageFinished_Ljava_lang_String_;
			public unsafe void OnPageFinished (string url)
			{
				if (id_onPageFinished_Ljava_lang_String_ == IntPtr.Zero)
					id_onPageFinished_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPageFinished", "(Ljava/lang/String;)V");
				IntPtr native_url = JNIEnv.NewString ((string)url);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageFinished_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_url);
			}

			static Delegate cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler ()
			{
				if (cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ == null)
					cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_);
				return cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
			}

			static bool n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShouldOverrideUrlLoading (view, url);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
			public unsafe bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url)
			{
				if (id_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
					id_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onShouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z");
				IntPtr native_url = JNIEnv.NewString ((string)url);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JValue (native_url);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_url);
				return __ret;
			}

		}

		// event args for com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener.doUpdateVisitedHistory
		public partial class DoUpdateVisitedHistoryEventArgs : global::System.EventArgs {
			public DoUpdateVisitedHistoryEventArgs (global::Android.Webkit.WebView view, string url, bool isReload)
			{
				this.view = view;
				this.url = url;
				this.isReload = isReload;
			}

			global::Android.Webkit.WebView view;

			public global::Android.Webkit.WebView View {
				get { return view; }
			}

			string url;

			public string Url {
				get { return url; }
			}

			bool isReload;

			public bool IsReload {
				get { return isReload; }
			}

		}

		// event args for com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener.onError
		public partial class ErrorEventArgs : global::System.EventArgs {
			public ErrorEventArgs (global::Android.Webkit.IWebResourceRequest request, global::AndroidX.WebKit.WebResourceErrorCompat error)
			{
				this.request = request;
				this.error = error;
			}

			global::Android.Webkit.IWebResourceRequest request;

			public global::Android.Webkit.IWebResourceRequest Request {
				get { return request; }
			}

			global::AndroidX.WebKit.WebResourceErrorCompat error;

			public global::AndroidX.WebKit.WebResourceErrorCompat Error {
				get { return error; }
			}

		}

		// event args for com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener.onLoadResource
		public partial class LoadResourceEventArgs : global::System.EventArgs {
			public LoadResourceEventArgs (string url)
			{
				this.url = url;
			}

			string url;

			public string Url {
				get { return url; }
			}

		}

		// event args for com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener.onPageFinished
		public partial class PageFinishedEventArgs : global::System.EventArgs {
			public PageFinishedEventArgs (string url)
			{
				this.url = url;
			}

			string url;

			public string Url {
				get { return url; }
			}

		}

		// event args for com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener.onShouldOverrideUrlLoading
		public partial class ShouldOverrideUrlLoadingEventArgs : global::System.EventArgs {
			bool handled;

			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			public ShouldOverrideUrlLoadingEventArgs (bool handled, global::Android.Webkit.WebView view, string url)
			{
				this.handled = handled;
				this.view = view;
				this.url = url;
			}

			global::Android.Webkit.WebView view;

			public global::Android.Webkit.WebView View {
				get { return view; }
			}

			string url;

			public string Url {
				get { return url; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/confirmit/mobilesdk/web/WrappedWebViewClient_OnWebViewListenerImplementor")]
		internal sealed partial class IOnWebViewListenerImplementor : global::Java.Lang.Object, IOnWebViewListener {

			object sender;

			public IOnWebViewListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/confirmit/mobilesdk/web/WrappedWebViewClient_OnWebViewListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<DoUpdateVisitedHistoryEventArgs> DoUpdateVisitedHistoryHandler;
			#pragma warning restore 0649

			public void DoUpdateVisitedHistory (global::Android.Webkit.WebView view, string url, bool isReload)
			{
				var __h = DoUpdateVisitedHistoryHandler;
				if (__h != null)
					__h (sender, new DoUpdateVisitedHistoryEventArgs (view, url, isReload));
			}

			#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
			#pragma warning restore 0649

			public void OnError (global::Android.Webkit.IWebResourceRequest request, global::AndroidX.WebKit.WebResourceErrorCompat error)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (request, error));
			}

			#pragma warning disable 0649
			public EventHandler<LoadResourceEventArgs> OnLoadResourceHandler;
			#pragma warning restore 0649

			public void OnLoadResource (string url)
			{
				var __h = OnLoadResourceHandler;
				if (__h != null)
					__h (sender, new LoadResourceEventArgs (url));
			}

			#pragma warning disable 0649
			public EventHandler<PageFinishedEventArgs> OnPageFinishedHandler;
			#pragma warning restore 0649

			public void OnPageFinished (string url)
			{
				var __h = OnPageFinishedHandler;
				if (__h != null)
					__h (sender, new PageFinishedEventArgs (url));
			}

			#pragma warning disable 0649
			public EventHandler<ShouldOverrideUrlLoadingEventArgs> OnShouldOverrideUrlLoadingHandler;
			#pragma warning restore 0649

			public bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url)
			{
				var __h = OnShouldOverrideUrlLoadingHandler;
				if (__h == null)
					return false;
				var __e = new ShouldOverrideUrlLoadingEventArgs (true, view, url);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnWebViewListenerImplementor value)
			{
				return value.DoUpdateVisitedHistoryHandler == null && value.OnErrorHandler == null && value.OnLoadResourceHandler == null && value.OnPageFinishedHandler == null && value.OnShouldOverrideUrlLoadingHandler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/WrappedWebViewClient", typeof (WrappedWebViewClient));

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

		internal WrappedWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='WrappedWebViewClient']/constructor[@name='WrappedWebViewClient' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener;)V", "")]
		public unsafe WrappedWebViewClient (global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='WrappedWebViewClient']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener A ()
		{
			const string __id = "a.()Lcom/confirmit/mobilesdk/web/WrappedWebViewClient$OnWebViewListener;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
