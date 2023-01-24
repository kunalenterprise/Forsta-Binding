using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Core.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/core/framework/b", DoNotGenerateAcw=true)]
	public sealed partial class CoreFrameworkB : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']/field[@name='a']"
		[Register ("a")]
		public static global::Com.Confirmit.Mobilesdk.Core.Framework.CoreFrameworkB A {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/core/framework/b;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Core.Framework.CoreFrameworkB> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']/field[@name='b']"
		[Register ("b")]
		public static IList<Kotlin.Reflect.IKProperty> B {
			get {
				const string __id = "b.[Lkotlin/reflect/KProperty;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Kotlin.Reflect.IKProperty>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Confirmit.Mobilesdk.Utils.UtilsI C {
			get {
				const string __id = "c.Lcom/confirmit/mobilesdk/utils/i;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Utils.UtilsI> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']/field[@name='d']"
		[Register ("d")]
		public static global::GoogleGson.Gson D {
			get {
				const string __id = "d.Lcom/google/gson/Gson;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::GoogleGson.Gson> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/core/framework/b", typeof (CoreFrameworkB));

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

		internal CoreFrameworkB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.core.framework']/class[@name='b']/constructor[@name='b' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoreFrameworkB () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
