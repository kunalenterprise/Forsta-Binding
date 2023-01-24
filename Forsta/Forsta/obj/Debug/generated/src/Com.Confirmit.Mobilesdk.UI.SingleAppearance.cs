using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SingleAppearance", DoNotGenerateAcw=true)]
	public sealed partial class SingleAppearance : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='ANSWER_BUTTONS']"
		[Register ("ANSWER_BUTTONS")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance AnswerButtons {
			get {
				const string __id = "ANSWER_BUTTONS.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='DROP_DOWN']"
		[Register ("DROP_DOWN")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance DropDown {
			get {
				const string __id = "DROP_DOWN.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='GRID_BARS']"
		[Register ("GRID_BARS")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance GridBars {
			get {
				const string __id = "GRID_BARS.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='HORIZONTAL_RATING_SCALE']"
		[Register ("HORIZONTAL_RATING_SCALE")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance HorizontalRatingScale {
			get {
				const string __id = "HORIZONTAL_RATING_SCALE.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='RADIO_BUTTON']"
		[Register ("RADIO_BUTTON")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance RadioButton {
			get {
				const string __id = "RADIO_BUTTON.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='SLIDER']"
		[Register ("SLIDER")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance Slider {
			get {
				const string __id = "SLIDER.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/field[@name='STAR_RATING']"
		[Register ("STAR_RATING")]
		public static global::Com.Confirmit.Mobilesdk.UI.SingleAppearance StarRating {
			get {
				const string __id = "STAR_RATING.Lcom/confirmit/mobilesdk/ui/SingleAppearance;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SingleAppearance", typeof (SingleAppearance));

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

		internal SingleAppearance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/SingleAppearance;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.SingleAppearance ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/ui/SingleAppearance;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SingleAppearance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SingleAppearance']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/ui/SingleAppearance;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.UI.SingleAppearance[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/ui/SingleAppearance;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.UI.SingleAppearance[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.UI.SingleAppearance));
			} finally {
			}
		}

	}
}
