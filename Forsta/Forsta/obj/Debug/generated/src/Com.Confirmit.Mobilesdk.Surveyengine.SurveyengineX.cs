using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/x", DoNotGenerateAcw=true)]
	public sealed partial class SurveyengineX : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='a']"
		[Register ("a")]
		public int A {
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='b']"
		[Register ("b")]
		public static IList<Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> B {
			get {
				const string __id = "b.[Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='CALLBLOCK']"
		[Register ("CALLBLOCK")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Callblock {
			get {
				const string __id = "CALLBLOCK.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='CHECK_XSS_SAFE']"
		[Register ("CHECK_XSS_SAFE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CheckXssSafe {
			get {
				const string __id = "CHECK_XSS_SAFE.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='CND']"
		[Register ("CND")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Cnd {
			get {
				const string __id = "CND.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='CONTROL_MULTI_ITEMS_SELECTED']"
		[Register ("CONTROL_MULTI_ITEMS_SELECTED")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX ControlMultiItemsSelected {
			get {
				const string __id = "CONTROL_MULTI_ITEMS_SELECTED.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='CONTROL_MULTI_SUM']"
		[Register ("CONTROL_MULTI_SUM")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX ControlMultiSum {
			get {
				const string __id = "CONTROL_MULTI_SUM.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='C_NUM']"
		[Register ("C_NUM")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CNum {
			get {
				const string __id = "C_NUM.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='C_RANK']"
		[Register ("C_RANK")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CRank {
			get {
				const string __id = "C_RANK.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='C_REQ']"
		[Register ("C_REQ")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CReq {
			get {
				const string __id = "C_REQ.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='C_RG']"
		[Register ("C_RG")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CRg {
			get {
				const string __id = "C_RG.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='C_SIZE']"
		[Register ("C_SIZE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX CSize {
			get {
				const string __id = "C_SIZE.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='DATE']"
		[Register ("DATE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Date {
			get {
				const string __id = "DATE.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='DIRECTIVE']"
		[Register ("DIRECTIVE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Directive {
			get {
				const string __id = "DIRECTIVE.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='DISPLAY']"
		[Register ("DISPLAY")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Display {
			get {
				const string __id = "DISPLAY.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='ERR_JMP']"
		[Register ("ERR_JMP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX ErrJmp {
			get {
				const string __id = "ERR_JMP.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='EXIT']"
		[Register ("EXIT")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Exit {
			get {
				const string __id = "EXIT.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='JMP']"
		[Register ("JMP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Jmp {
			get {
				const string __id = "JMP.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='LOOP']"
		[Register ("LOOP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Loop {
			get {
				const string __id = "LOOP.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='PRE_PROC']"
		[Register ("PRE_PROC")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX PreProc {
			get {
				const string __id = "PRE_PROC.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='PROC_RET']"
		[Register ("PROC_RET")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX ProcRet {
			get {
				const string __id = "PROC_RET.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='SCRIPT']"
		[Register ("SCRIPT")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Script {
			get {
				const string __id = "SCRIPT.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='START']"
		[Register ("START")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Start {
			get {
				const string __id = "START.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='STATUS']"
		[Register ("STATUS")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Status {
			get {
				const string __id = "STATUS.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='STOP']"
		[Register ("STOP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Stop {
			get {
				const string __id = "STOP.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='STORE']"
		[Register ("STORE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Store {
			get {
				const string __id = "STORE.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='S_JMP']"
		[Register ("S_JMP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX SJmp {
			get {
				const string __id = "S_JMP.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX Unknown {
			get {
				const string __id = "UNKNOWN.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/field[@name='V_SCRIPT']"
		[Register ("V_SCRIPT")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX VScript {
			get {
				const string __id = "V_SCRIPT.Lcom/confirmit/mobilesdk/surveyengine/x;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/x", typeof (SurveyengineX));

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

		internal SurveyengineX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/constructor[@name='x' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe SurveyengineX (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/x;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/x;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='x']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/surveyengine/x;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/surveyengine/x;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX));
			} finally {
			}
		}

	}
}
