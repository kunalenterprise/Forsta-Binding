using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/d", DoNotGenerateAcw=true)]
	public partial class CommonExprobD : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI ExProbjsDObjA {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/i;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/i;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='b']"
		[Register ("b")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ ExProbjsDObjB {
			get {
				const string __id = "b.Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='c']"
		[Register ("c")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB ExProbjsDObjC {
			get {
				const string __id = "c.Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='d']"
		[Register ("d")]
		public global::System.Collections.IList ExProbjsDObjD {
			get {
				const string __id = "d.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='e']"
		[Register ("e")]
		public string ExProbjsDObjE {
			get {
				const string __id = "e.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/field[@name='f']"
		[Register ("f")]
		public bool ExProbjsDObjF {
			get {
				const string __id = "f.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "f.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/d", typeof (CommonExprobD));

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

		protected CommonExprobD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/constructor[@name='d' and count(parameter)=4 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='com.confirmit.mobilesdk.surveyengine.packages.question.j'] and parameter[3][@type='com.confirmit.mobilesdk.surveyengine.packages.question.domains.b'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;Ljava/util/List;)V", "")]
		public unsafe CommonExprobD (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ p1, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB p2, global::System.Collections.Generic.IList<string> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/surveyengine/i;Lcom/confirmit/mobilesdk/surveyengine/packages/question/j;Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/List;", "GetAHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> A ()
		{
			const string __id = "a.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_confirmit_mobilesdk_surveyengine_w_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_confirmit_mobilesdk_surveyengine_w_Handler ()
		{
			if (cb_a_Lcom_confirmit_mobilesdk_surveyengine_w_ == null)
				cb_a_Lcom_confirmit_mobilesdk_surveyengine_w_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_A_Lcom_confirmit_mobilesdk_surveyengine_w_);
			return cb_a_Lcom_confirmit_mobilesdk_surveyengine_w_;
		}

		static bool n_A_Lcom_confirmit_mobilesdk_surveyengine_w_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineW> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.w']]"
		[Register ("a", "(Lcom/confirmit/mobilesdk/surveyengine/w;)Z", "GetA_Lcom_confirmit_mobilesdk_surveyengine_w_Handler")]
		public virtual unsafe bool A (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineW p0)
		{
			const string __id = "a.(Lcom/confirmit/mobilesdk/surveyengine/w;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_a_DD;
#pragma warning disable 0169
		static Delegate GetA_DDHandler ()
		{
			if (cb_a_DD == null)
				cb_a_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_Z) n_A_DD);
			return cb_a_DD;
		}

		static bool n_A_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("a", "(DD)Z", "GetA_DDHandler")]
		public virtual unsafe bool A (double p0, double p1)
		{
			const string __id = "a.(DD)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_A_I);
			return cb_a_I;
		}

		static IntPtr n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Ljava/lang/String;", "GetA_IHandler")]
		public virtual unsafe string A (int p0)
		{
			const string __id = "a.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Ljava_lang_Class_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Class_Ljava_lang_Object_Handler ()
		{
			if (cb_a_Ljava_lang_Class_Ljava_lang_Object_ == null)
				cb_a_Ljava_lang_Class_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_A_Ljava_lang_Class_Ljava_lang_Object_);
			return cb_a_Ljava_lang_Class_Ljava_lang_Object_;
		}

		static IntPtr n_A_Ljava_lang_Class_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.A (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='T']]"
		[Register ("a", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/String;", "GetA_Ljava_lang_Class_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe string A (global::Java.Lang.Class p0, global::Java.Lang.Object p1)
		{
			const string __id = "a.(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static bool n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "GetA_Ljava_lang_String_Handler")]
		public virtual unsafe bool A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_a_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_List_Handler ()
		{
			if (cb_a_Ljava_util_List_ == null)
				cb_a_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_A_Ljava_util_List_);
			return cb_a_Ljava_util_List_;
		}

		static bool n_A_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("a", "(Ljava/util/List;)Z", "GetA_Ljava_util_List_Handler")]
		public virtual unsafe bool A (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "a.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/List;", "GetBHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> B ()
		{
			const string __id = "b.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_b_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_B_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_;
		}

		static IntPtr n_B_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.B (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/d;", "GetB_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD B (string p0)
		{
			const string __id = "b.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/d;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_b_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_util_List_Handler ()
		{
			if (cb_b_Ljava_util_List_ == null)
				cb_b_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_B_Ljava_util_List_);
			return cb_b_Ljava_util_List_;
		}

		static bool n_B_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.B (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("b", "(Ljava/util/List;)Z", "GetB_Ljava_util_List_Handler")]
		public virtual unsafe bool B (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			const string __id = "b.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/util/List;", "GetCHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> C ()
		{
			const string __id = "c.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_c_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_util_List_Handler ()
		{
			if (cb_c_Ljava_util_List_ == null)
				cb_c_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_C_Ljava_util_List_);
			return cb_c_Ljava_util_List_;
		}

		static bool n_C_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.C (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("c", "(Ljava/util/List;)Z", "GetC_Ljava_util_List_Handler")]
		public virtual unsafe bool C (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "c.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.D ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/util/List;", "GetDHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> D ()
		{
			const string __id = "d.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_d_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_util_List_Handler ()
		{
			if (cb_d_Ljava_util_List_ == null)
				cb_d_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_D_Ljava_util_List_);
			return cb_d_Ljava_util_List_;
		}

		static bool n_D_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.D (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("d", "(Ljava/util/List;)Z", "GetD_Ljava_util_List_Handler")]
		public virtual unsafe bool D (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			const string __id = "d.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_E);
			return cb_e;
		}

		static IntPtr n_E (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.E ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "GetEHandler")]
		public virtual unsafe string E ()
		{
			const string __id = "e.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_e_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_util_List_Handler ()
		{
			if (cb_e_Ljava_util_List_ == null)
				cb_e_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_E_Ljava_util_List_);
			return cb_e_Ljava_util_List_;
		}

		static bool n_E_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.E (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("e", "(Ljava/util/List;)Z", "GetE_Ljava_util_List_Handler")]
		public virtual unsafe bool E (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "e.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_F);
			return cb_f;
		}

		static IntPtr n_F (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.F ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "GetFHandler")]
		public virtual unsafe string F ()
		{
			const string __id = "f.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_f_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetF_Ljava_util_List_Handler ()
		{
			if (cb_f_Ljava_util_List_ == null)
				cb_f_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_F_Ljava_util_List_);
			return cb_f_Ljava_util_List_;
		}

		static void n_F_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.F (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='f' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("f", "(Ljava/util/List;)V", "GetF_Ljava_util_List_Handler")]
		public virtual unsafe void F (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "f.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB G ()
		{
			const string __id = "g.()Lcom/confirmit/mobilesdk/surveyengine/packages/question/domains/b;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_H);
			return cb_h;
		}

		static IntPtr n_H (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "GetHHandler")]
		public virtual unsafe string H ()
		{
			const string __id = "h.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "")]
		public unsafe string I ()
		{
			const string __id = "i.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_J);
			return cb_j;
		}

		static IntPtr n_J (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.J ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/util/List;", "GetJHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> J ()
		{
			const string __id = "j.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()V", "")]
		public unsafe void K ()
		{
			const string __id = "k.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()V", "")]
		public unsafe void L ()
		{
			const string __id = "l.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_m;
#pragma warning disable 0169
		static Delegate GetMHandler ()
		{
			if (cb_m == null)
				cb_m = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_M);
			return cb_m;
		}

		static int n_M (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.M ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()I", "GetMHandler")]
		public virtual unsafe int M ()
		{
			const string __id = "m.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_n;
#pragma warning disable 0169
		static Delegate GetNHandler ()
		{
			if (cb_n == null)
				cb_n = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_N);
			return cb_n;
		}

		static bool n_N (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.N ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()Z", "GetNHandler")]
		public virtual unsafe bool N ()
		{
			const string __id = "n.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_o;
#pragma warning disable 0169
		static Delegate GetOHandler ()
		{
			if (cb_o == null)
				cb_o = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_O);
			return cb_o;
		}

		static double n_O (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.O ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='o' and count(parameter)=0]"
		[Register ("o", "()D", "GetOHandler")]
		public virtual unsafe double O ()
		{
			const string __id = "o.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_p;
#pragma warning disable 0169
		static Delegate GetPHandler ()
		{
			if (cb_p == null)
				cb_p = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_P);
			return cb_p;
		}

		static IntPtr n_P (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.P ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='p' and count(parameter)=0]"
		[Register ("p", "()Ljava/lang/String;", "GetPHandler")]
		public virtual unsafe string P ()
		{
			const string __id = "p.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_q;
#pragma warning disable 0169
		static Delegate GetQHandler ()
		{
			if (cb_q == null)
				cb_q = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Q);
			return cb_q;
		}

		static IntPtr n_Q (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Q ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='q' and count(parameter)=0]"
		[Register ("q", "()Ljava/lang/String;", "GetQHandler")]
		public virtual unsafe string Q ()
		{
			const string __id = "q.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_r;
#pragma warning disable 0169
		static Delegate GetRHandler ()
		{
			if (cb_r == null)
				cb_r = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_R);
			return cb_r;
		}

		static IntPtr n_R (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD>.ToLocalJniHandle (__this.R ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.common.exprobjs']/class[@name='d']/method[@name='r' and count(parameter)=0]"
		[Register ("r", "()Ljava/util/List;", "GetRHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD> R ()
		{
			const string __id = "r.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
