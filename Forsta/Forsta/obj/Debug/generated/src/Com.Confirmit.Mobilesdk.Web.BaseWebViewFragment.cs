using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Web {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/BaseWebViewFragment", DoNotGenerateAcw=true)]
	public abstract partial class BaseWebViewFragment : global::AndroidX.Fragment.App.DialogFragment, global::Android.Views.View.IOnClickListener, global::Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient.IOnWebViewListener {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/field[@name='progressBar']"
		[Register ("progressBar")]
		public global::Android.Widget.ProgressBar ForstaProgressBar {
			get {
				const string __id = "progressBar.Landroid/widget/ProgressBar;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "progressBar.Landroid/widget/ProgressBar;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/field[@name='webView']"
		[Register ("webView")]
		public global::Android.Webkit.WebView ForstaWebView {
			get {
				const string __id = "webView.Landroid/webkit/WebView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "webView.Landroid/webkit/WebView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment.WhenMappings']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/BaseWebViewFragment$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/BaseWebViewFragment$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/BaseWebViewFragment", typeof (BaseWebViewFragment));

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

		protected BaseWebViewFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/constructor[@name='BaseWebViewFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseWebViewFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDialogAnimations;
#pragma warning disable 0169
		static Delegate GetGetDialogAnimationsHandler ()
		{
			if (cb_getDialogAnimations == null)
				cb_getDialogAnimations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDialogAnimations);
			return cb_getDialogAnimations;
		}

		static IntPtr n_GetDialogAnimations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DialogAnimations);
		}
#pragma warning restore 0169

		static Delegate cb_setDialogAnimations_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetDialogAnimations_Ljava_lang_Integer_Handler ()
		{
			if (cb_setDialogAnimations_Ljava_lang_Integer_ == null)
				cb_setDialogAnimations_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDialogAnimations_Ljava_lang_Integer_);
			return cb_setDialogAnimations_Ljava_lang_Integer_;
		}

		static void n_SetDialogAnimations_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DialogAnimations = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer DialogAnimations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='getDialogAnimations' and count(parameter)=0]"
			[Register ("getDialogAnimations", "()Ljava/lang/Integer;", "GetGetDialogAnimationsHandler")]
			get {
				const string __id = "getDialogAnimations.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='setDialogAnimations' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setDialogAnimations", "(Ljava/lang/Integer;)V", "GetSetDialogAnimations_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setDialogAnimations.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Widget.ProgressBar ProgressBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='getProgressBar' and count(parameter)=0]"
			[Register ("getProgressBar", "()Landroid/widget/ProgressBar;", "")]
			get {
				const string __id = "getProgressBar.()Landroid/widget/ProgressBar;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='setProgressBar' and count(parameter)=1 and parameter[1][@type='android.widget.ProgressBar']]"
			[Register ("setProgressBar", "(Landroid/widget/ProgressBar;)V", "")]
			set {
				const string __id = "setProgressBar.(Landroid/widget/ProgressBar;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Webkit.WebView WebView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='getWebView' and count(parameter)=0]"
			[Register ("getWebView", "()Landroid/webkit/WebView;", "")]
			get {
				const string __id = "getWebView.()Landroid/webkit/WebView;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='setWebView' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
			[Register ("setWebView", "(Landroid/webkit/WebView;)V", "")]
			set {
				const string __id = "setWebView.(Landroid/webkit/WebView;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe bool WebViewReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='getWebViewReady' and count(parameter)=0]"
			[Register ("getWebViewReady", "()Z", "")]
			get {
				const string __id = "getWebViewReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.DoUpdateVisitedHistory (view, url, isReload);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='doUpdateVisitedHistory' and count(parameter)=3 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", "GetDoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_ZHandler")]
		public virtual unsafe void DoUpdateVisitedHistory (global::Android.Webkit.WebView view, string url, bool isReload)
		{
			const string __id = "doUpdateVisitedHistory.(Landroid/webkit/WebView;Ljava/lang/String;Z)V";
			IntPtr native_url = JNIEnv.NewString ((string)url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue (isReload);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View v)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (v);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = (global::Android.Webkit.IWebResourceRequest)global::Java.Lang.Object.GetObject<global::Android.Webkit.IWebResourceRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::AndroidX.WebKit.WebResourceErrorCompat> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnError (request, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='android.webkit.WebResourceRequest'] and parameter[2][@type='androidx.webkit.WebResourceErrorCompat']]"
		[Register ("onError", "(Landroid/webkit/WebResourceRequest;Landroidx/webkit/WebResourceErrorCompat;)V", "GetOnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_Handler")]
		public virtual unsafe void OnError (global::Android.Webkit.IWebResourceRequest request, global::AndroidX.WebKit.WebResourceErrorCompat error)
		{
			const string __id = "onError.(Landroid/webkit/WebResourceRequest;Landroidx/webkit/WebResourceErrorCompat;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (request);
				global::System.GC.KeepAlive (error);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadResource (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='onLoadResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onLoadResource", "(Ljava/lang/String;)V", "GetOnLoadResource_Ljava_lang_String_Handler")]
		public virtual unsafe void OnLoadResource (string url)
		{
			const string __id = "onLoadResource.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString ((string)url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.OnPageFinished (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='onPageFinished' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onPageFinished", "(Ljava/lang/String;)V", "GetOnPageFinished_Ljava_lang_String_Handler")]
		public virtual unsafe void OnPageFinished (string url)
		{
			const string __id = "onPageFinished.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString ((string)url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnShouldOverrideUrlLoading (view, url);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='BaseWebViewFragment']/method[@name='onShouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onShouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url)
		{
			const string __id = "onShouldOverrideUrlLoading.(Landroid/webkit/WebView;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString ((string)url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (view);
			}
		}

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/BaseWebViewFragment", DoNotGenerateAcw=true)]
	internal partial class BaseWebViewFragmentInvoker : BaseWebViewFragment {
		public BaseWebViewFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/BaseWebViewFragment", typeof (BaseWebViewFragmentInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
