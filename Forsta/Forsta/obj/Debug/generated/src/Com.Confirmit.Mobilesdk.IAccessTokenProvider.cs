using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='AccessTokenProvider']"
	[Register ("com/confirmit/mobilesdk/AccessTokenProvider", "", "Com.Confirmit.Mobilesdk.IAccessTokenProviderInvoker")]
	public partial interface IAccessTokenProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/interface[@name='AccessTokenProvider']/method[@name='getAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccessToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAccessToken_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.IAccessTokenProviderInvoker, Forsta")]
		string GetAccessToken (string serverId);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/AccessTokenProvider", DoNotGenerateAcw=true)]
	internal partial class IAccessTokenProviderInvoker : global::Java.Lang.Object, IAccessTokenProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/AccessTokenProvider", typeof (IAccessTokenProviderInvoker));

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

		public static IAccessTokenProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccessTokenProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.AccessTokenProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccessTokenProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_getAccessToken_Ljava_lang_String_ == null)
				cb_getAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAccessToken_Ljava_lang_String_);
			return cb_getAccessToken_Ljava_lang_String_;
		}

		static IntPtr n_GetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.IAccessTokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAccessToken (serverId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccessToken_Ljava_lang_String_;
		public unsafe string GetAccessToken (string serverId)
		{
			if (id_getAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccessToken", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_serverId);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			return __ret;
		}

	}
}
