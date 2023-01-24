using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/t", DoNotGenerateAcw=true)]
	public sealed partial class SurveyengineT : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='a']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='AUDIO_CAPTURE']"
		[Register ("AUDIO_CAPTURE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT AudioCapture {
			get {
				const string __id = "AUDIO_CAPTURE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='b']"
		[Register ("b")]
		public static IList<Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> B {
			get {
				const string __id = "b.[Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='BLOCK']"
		[Register ("BLOCK")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Block {
			get {
				const string __id = "BLOCK.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='BLOCK_TO_CALL']"
		[Register ("BLOCK_TO_CALL")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT BlockToCall {
			get {
				const string __id = "BLOCK_TO_CALL.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='CHART']"
		[Register ("CHART")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Chart {
			get {
				const string __id = "CHART.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='CONDITION']"
		[Register ("CONDITION")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Condition {
			get {
				const string __id = "CONDITION.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='DATE']"
		[Register ("DATE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Date {
			get {
				const string __id = "DATE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='DIRECTIVE']"
		[Register ("DIRECTIVE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Directive {
			get {
				const string __id = "DIRECTIVE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Email {
			get {
				const string __id = "EMAIL.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='FOLDER']"
		[Register ("FOLDER")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Folder {
			get {
				const string __id = "FOLDER.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='GEO_LOCATION']"
		[Register ("GEO_LOCATION")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT GeoLocation {
			get {
				const string __id = "GEO_LOCATION.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='GRID']"
		[Register ("GRID")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Grid {
			get {
				const string __id = "GRID.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='GRID_3D']"
		[Register ("GRID_3D")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Grid3d {
			get {
				const string __id = "GRID_3D.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='IMAGE_UPLOADER']"
		[Register ("IMAGE_UPLOADER")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT ImageUploader {
			get {
				const string __id = "IMAGE_UPLOADER.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Info {
			get {
				const string __id = "INFO.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='LOOP']"
		[Register ("LOOP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Loop {
			get {
				const string __id = "LOOP.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='MULTI']"
		[Register ("MULTI")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Multi {
			get {
				const string __id = "MULTI.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='MULTI_GRID']"
		[Register ("MULTI_GRID")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT MultiGrid {
			get {
				const string __id = "MULTI_GRID.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Numeric {
			get {
				const string __id = "NUMERIC.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='NUMERIC_LIST']"
		[Register ("NUMERIC_LIST")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT NumericList {
			get {
				const string __id = "NUMERIC_LIST.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='OPEN_TEXT']"
		[Register ("OPEN_TEXT")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT OpenText {
			get {
				const string __id = "OPEN_TEXT.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='OPEN_TEXT_LIST']"
		[Register ("OPEN_TEXT_LIST")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT OpenTextList {
			get {
				const string __id = "OPEN_TEXT_LIST.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='PAGE']"
		[Register ("PAGE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Page {
			get {
				const string __id = "PAGE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='RANKING']"
		[Register ("RANKING")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Ranking {
			get {
				const string __id = "RANKING.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='SCRIPT']"
		[Register ("SCRIPT")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Script {
			get {
				const string __id = "SCRIPT.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='SINGLE']"
		[Register ("SINGLE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Single {
			get {
				const string __id = "SINGLE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='STOP']"
		[Register ("STOP")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Stop {
			get {
				const string __id = "STOP.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='TELEPHONE']"
		[Register ("TELEPHONE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Telephone {
			get {
				const string __id = "TELEPHONE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='UNDEFIEND']"
		[Register ("UNDEFIEND")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT Undefiend {
			get {
				const string __id = "UNDEFIEND.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/field[@name='VIDEO_CAPTURE']"
		[Register ("VIDEO_CAPTURE")]
		public static global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT VideoCapture {
			get {
				const string __id = "VIDEO_CAPTURE.Lcom/confirmit/mobilesdk/surveyengine/t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/t", typeof (SurveyengineT));

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

		internal SurveyengineT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/constructor[@name='t' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe SurveyengineT (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/t;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/surveyengine/t;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='t']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/confirmit/mobilesdk/surveyengine/t;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT[] Values ()
		{
			const string __id = "values.()[Lcom/confirmit/mobilesdk/surveyengine/t;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT));
			} finally {
			}
		}

	}
}
