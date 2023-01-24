using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiResponse']"
	[Register ("com/confirmit/mobilesdk/sync/request/ApiResponse", "", "Com.Confirmit.Mobilesdk.Sync.Request.IApiResponseInvoker")]
	public partial interface IApiResponse : IJavaObject, IJavaPeerable {
		global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestC StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()Lcom/confirmit/mobilesdk/sync/request/c;", "GetGetStatusCodeHandler:Com.Confirmit.Mobilesdk.Sync.Request.IApiResponseInvoker, Forsta")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiResponse']/method[@name='toDownloadFileInfo' and count(parameter)=0]"
		[Register ("toDownloadFileInfo", "()Lcom/confirmit/mobilesdk/sync/request/a;", "GetToDownloadFileInfoHandler:Com.Confirmit.Mobilesdk.Sync.Request.IApiResponseInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestA ToDownloadFileInfo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiResponse']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("toJson", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetToJson_Ljava_lang_Class_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiResponseInvoker, Forsta")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object ToJson (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiResponse']/method[@name='toText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toText", "(Z)Ljava/lang/String;", "GetToText_ZHandler:Com.Confirmit.Mobilesdk.Sync.Request.IApiResponseInvoker, Forsta")]
		string ToText (bool p0);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/request/ApiResponse", DoNotGenerateAcw=true)]
	internal partial class IApiResponseInvoker : global::Java.Lang.Object, IApiResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/request/ApiResponse", typeof (IApiResponseInvoker));

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

		public static IApiResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.sync.request.ApiResponse'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static IntPtr n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatusCode);
		}
#pragma warning restore 0169

		IntPtr id_getStatusCode;
		public unsafe global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestC StatusCode {
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()Lcom/confirmit/mobilesdk/sync/request/c;");
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestC> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_toDownloadFileInfo;
#pragma warning disable 0169
		static Delegate GetToDownloadFileInfoHandler ()
		{
			if (cb_toDownloadFileInfo == null)
				cb_toDownloadFileInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToDownloadFileInfo);
			return cb_toDownloadFileInfo;
		}

		static IntPtr n_ToDownloadFileInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToDownloadFileInfo ());
		}
#pragma warning restore 0169

		IntPtr id_toDownloadFileInfo;
		public unsafe global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestA ToDownloadFileInfo ()
		{
			if (id_toDownloadFileInfo == IntPtr.Zero)
				id_toDownloadFileInfo = JNIEnv.GetMethodID (class_ref, "toDownloadFileInfo", "()Lcom/confirmit/mobilesdk/sync/request/a;");
			return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toDownloadFileInfo), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toJson_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetToJson_Ljava_lang_Class_Handler ()
		{
			if (cb_toJson_Ljava_lang_Class_ == null)
				cb_toJson_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ToJson_Ljava_lang_Class_);
			return cb_toJson_Ljava_lang_Class_;
		}

		static IntPtr n_ToJson_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToJson (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toJson_Ljava_lang_Class_;
		public unsafe global::Java.Lang.Object ToJson (global::Java.Lang.Class p0)
		{
			if (id_toJson_Ljava_lang_Class_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Class;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toText_Z;
#pragma warning disable 0169
		static Delegate GetToText_ZHandler ()
		{
			if (cb_toText_Z == null)
				cb_toText_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ToText_Z);
			return cb_toText_Z;
		}

		static IntPtr n_ToText_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToText (p0));
		}
#pragma warning restore 0169

		IntPtr id_toText_Z;
		public unsafe string ToText (bool p0)
		{
			if (id_toText_Z == IntPtr.Zero)
				id_toText_Z = JNIEnv.GetMethodID (class_ref, "toText", "(Z)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toText_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
