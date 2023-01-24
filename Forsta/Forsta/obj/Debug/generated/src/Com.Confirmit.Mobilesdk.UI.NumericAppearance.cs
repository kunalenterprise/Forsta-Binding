using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/NumericAppearance", DoNotGenerateAcw=true)]
	public sealed partial class NumericAppearance : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']/field[@name='NUMERIC_FIELD']"
		[Register ("NUMERIC_FIELD")]
		public static global::Com.Confirmit.Mobilesdk.UI.NumericAppearance NumericField {
			get {
				const string __id = "NUMERIC_FIELD.Lcom/confirmit/mobilesdk/ui/NumericAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.NumericAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']/field[@name='NUMERIC_SLIDER']"
		[Register ("NUMERIC_SLIDER")]
		public static global::Com.Confirmit.Mobilesdk.UI.NumericAppearance NumericSlider {
			get {
				const string __id = "NUMERIC_SLIDER.Lcom/confirmit/mobilesdk/ui/NumericAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.NumericAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/NumericAppearance", typeof (NumericAppearance));

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

		internal NumericAppearance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/NumericAppearance;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.NumericAppearance ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/NumericAppearance;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.NumericAppearance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='NumericAppearance']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/ui/NumericAppearance;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.NumericAppearance[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/ui/NumericAppearance;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.UI.NumericAppearance[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.UI.NumericAppearance));
			} finally {
			}
		}

	}
}
