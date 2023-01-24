using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Web {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/SurveyWebViewFragment", DoNotGenerateAcw=true)]
	public sealed partial class SurveyWebViewFragment : global::Com.Confirmit.Mobilesdk.Web.BaseWebViewFragment {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/field[@name='BTN_MARGIN']"
		[Register ("BTN_MARGIN")]
		public const float BtnMargin = (float) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/field[@name='BUTTON_CLOSE_COLOR']"
		[Register ("BUTTON_CLOSE_COLOR")]
		public const string ButtonCloseColor = (string) "#99121821";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/field[@name='Companion']"
		[Register ("Companion")]
		public static global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment.Companion ForstaCompanion {
			get {
				const string __id = "Companion.Lcom/confirmit/mobilesdk/web/SurveyWebViewFragment$Companion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment.Companion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/field[@name='PROGRESS_BAR_HEIGHT']"
		[Register ("PROGRESS_BAR_HEIGHT")]
		public const float ProgressBarHeight = (float) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/field[@name='TABLET_SCREEN_RATIO']"
		[Register ("TABLET_SCREEN_RATIO")]
		public const float TabletScreenRatio = (float) 0.800000012;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment.Companion']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/web/SurveyWebViewFragment$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/SurveyWebViewFragment$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment.Companion']/constructor[@name='SurveyWebViewFragment.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment.Companion']/method[@name='newInstance' and count(parameter)=0]"
			[Register ("newInstance", "()Lcom/confirmit/mobilesdk/web/SurveyWebViewFragment;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment NewInstance ()
			{
				const string __id = "newInstance.()Lcom/confirmit/mobilesdk/web/SurveyWebViewFragment;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/web/SurveyWebViewFragment", typeof (SurveyWebViewFragment));

		internal static new IntPtr class_ref {
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

		internal SurveyWebViewFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/constructor[@name='SurveyWebViewFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveyWebViewFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::System.Collections.Generic.IDictionary<string, string> CustomData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/method[@name='getCustomData' and count(parameter)=0]"
			[Register ("getCustomData", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getCustomData.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewUrl SurveyUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/method[@name='getSurveyUrl' and count(parameter)=0]"
			[Register ("getSurveyUrl", "()Lcom/confirmit/mobilesdk/web/SurveyWebViewUrl;", "")]
			get {
				const string __id = "getSurveyUrl.()Lcom/confirmit/mobilesdk/web/SurveyWebViewUrl;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Web.SurveyWebViewUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Webkit.WebView Webview {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/method[@name='getWebview' and count(parameter)=0]"
			[Register ("getWebview", "()Landroid/webkit/WebView;", "")]
			get {
				const string __id = "getWebview.()Landroid/webkit/WebView;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.web.SurveyWebViewFragmentCallback']]"
		[Register ("setCallback", "(Lcom/confirmit/mobilesdk/web/SurveyWebViewFragmentCallback;)V", "")]
		public unsafe void SetCallback (global::Com.Confirmit.Mobilesdk.Web.ISurveyWebViewFragmentCallback p0)
		{
			const string __id = "setCallback.(Lcom/confirmit/mobilesdk/web/SurveyWebViewFragmentCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.web']/class[@name='SurveyWebViewFragment']/method[@name='setupWebView' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setupWebView", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe void SetupWebView (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			const string __id = "setupWebView.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
