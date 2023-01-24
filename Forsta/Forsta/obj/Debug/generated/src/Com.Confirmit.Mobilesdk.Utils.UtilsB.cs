using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/utils/b", DoNotGenerateAcw=true)]
	public sealed partial class UtilsB : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.Style.ILeadingMarginSpan {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/field[@name='a']"
		[Register ("a")]
		public int UtilsBObjA {
			get {
				const string __id = "a.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "a.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/field[@name='b']"
		[Register ("b")]
		public float B {
			get {
				const string __id = "b.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "b.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/field[@name='c']"
		[Register ("c")]
		public float C {
			get {
				const string __id = "c.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "c.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/field[@name='d']"
		[Register ("d")]
		public float D {
			get {
				const string __id = "d.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "d.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/field[@name='e']"
		[Register ("e")]
		public float E {
			get {
				const string __id = "e.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "e.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/utils/b", typeof (UtilsB));

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

		internal UtilsB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/constructor[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe UtilsB (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/method[@name='a' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("a", "(C)Z", "")]
		public unsafe bool A (char p0)
		{
			const string __id = "a.(C)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/method[@name='drawLeadingMargin' and count(parameter)=12 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.CharSequence'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='boolean'] and parameter[12][@type='android.text.Layout']]"
		[Register ("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V", "")]
		public unsafe void DrawLeadingMargin (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, int p2, int p3, int p4, int p5, int p6, global::Java.Lang.ICharSequence p7, int p8, int p9, bool p10, global::Android.Text.Layout p11)
		{
			const string __id = "drawLeadingMargin.(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V";
			IntPtr native_p7 = CharSequence.ToLocalJniHandle (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (p8);
				__args [9] = new JniArgumentValue (p9);
				__args [10] = new JniArgumentValue (p10);
				__args [11] = new JniArgumentValue ((p11 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p11).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p7);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p7);
				global::System.GC.KeepAlive (p11);
			}
		}

		public void DrawLeadingMargin (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, int p2, int p3, int p4, int p5, int p6, string p7, int p8, int p9, bool p10, global::Android.Text.Layout p11)
		{
			var jls_p7 = p7 == null ? null : new global::Java.Lang.String (p7);
			DrawLeadingMargin (p0, p1, p2, p3, p4, p5, p6, jls_p7, p8, p9, p10, p11);
			jls_p7?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/method[@name='getLeadingMargin' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getLeadingMargin", "(Z)I", "")]
		public unsafe int GetLeadingMargin (bool p0)
		{
			const string __id = "getLeadingMargin.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/method[@name='updateDrawState' and count(parameter)=1 and parameter[1][@type='android.text.TextPaint']]"
		[Register ("updateDrawState", "(Landroid/text/TextPaint;)V", "")]
		public override unsafe void UpdateDrawState (global::Android.Text.TextPaint p0)
		{
			const string __id = "updateDrawState.(Landroid/text/TextPaint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.utils']/class[@name='b']/method[@name='updateMeasureState' and count(parameter)=1 and parameter[1][@type='android.text.TextPaint']]"
		[Register ("updateMeasureState", "(Landroid/text/TextPaint;)V", "")]
		public override unsafe void UpdateMeasureState (global::Android.Text.TextPaint p0)
		{
			const string __id = "updateMeasureState.(Landroid/text/TextPaint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
