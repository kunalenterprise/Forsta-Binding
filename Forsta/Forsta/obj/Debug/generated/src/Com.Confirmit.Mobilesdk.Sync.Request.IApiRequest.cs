using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Sync.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']"
	[Register ("com/confirmit/mobilesdk/sync/request/ApiRequest", "", "Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker")]
	public partial interface IApiRequest : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.defaults.d&gt;']]"
		[Register ("delete", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDelete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker, Forsta")]
		global::Java.Lang.Object Delete (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']/method[@name='download' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.defaults.d&gt;']]"
		[Register ("download", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDownload_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker, Forsta")]
		global::Java.Lang.Object Download (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.defaults.d&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker, Forsta")]
		global::Java.Lang.Object Get (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']/method[@name='post' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.defaults.d&gt;']]"
		[Register ("post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetPost_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker, Forsta")]
		global::Java.Lang.Object Post (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Object p2, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.sync.request']/interface[@name='ApiRequest']/method[@name='put' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super com.confirmit.mobilesdk.sync.request.defaults.d&gt;']]"
		[Register ("put", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetPut_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Com.Confirmit.Mobilesdk.Sync.Request.IApiRequestInvoker, Forsta")]
		global::Java.Lang.Object Put (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Object p2, global::Kotlin.Coroutines.IContinuation p3);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/sync/request/ApiRequest", DoNotGenerateAcw=true)]
	internal partial class IApiRequestInvoker : global::Java.Lang.Object, IApiRequest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/sync/request/ApiRequest", typeof (IApiRequestInvoker));

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

		public static IApiRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.sync.request.ApiRequest'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == null)
				cb_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_);
			return cb_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object Delete (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == null)
				cb_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_);
			return cb_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Download (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object Download (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_download_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == null)
				cb_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_);
			return cb_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object Get (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_util_Map_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
				cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_Post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_);
			return cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object Post (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Object p2, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
				cb_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_Put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_);
			return cb_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Sync.Request.IApiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object Put (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Object p2, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
