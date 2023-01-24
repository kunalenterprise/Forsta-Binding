using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj", DoNotGenerateAcw=true)]
	public sealed partial class RhinoExprObj : global::Org.Mozilla.Javascript.ScriptableObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj", typeof (RhinoExprObj));

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

		internal RhinoExprObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/constructor[@name='RhinoExprObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RhinoExprObj () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/constructor[@name='RhinoExprObj' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe RhinoExprObj (global::Java.Lang.Object p0, global::Java.Lang.Object p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		public override unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsNearBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='isNearBy' and count(parameter)=0]"
			[Register ("isNearBy", "()Z", "")]
			get {
				const string __id = "isNearBy.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='between' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("between", "(DD)Z", "")]
		public unsafe bool Between (double p0, double p1)
		{
			const string __id = "between.(DD)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='bool' and count(parameter)=0]"
		[Register ("bool", "()Z", "")]
		public unsafe bool Bool ()
		{
			const string __id = "bool.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='coded' and count(parameter)=0]"
		[Register ("coded", "()Z", "")]
		public unsafe bool Coded ()
		{
			const string __id = "coded.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='compound' and count(parameter)=0]"
		[Register ("compound", "()Z", "")]
		public unsafe bool Compound ()
		{
			const string __id = "compound.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='date' and count(parameter)=0]"
		[Register ("date", "()Z", "")]
		public unsafe bool Date ()
		{
			const string __id = "date.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='datestring' and count(parameter)=0]"
		[Register ("datestring", "()Ljava/lang/String;", "")]
		public unsafe string Datestring ()
		{
			const string __id = "datestring.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='day' and count(parameter)=0]"
		[Register ("day", "()I", "")]
		public unsafe int Day ()
		{
			const string __id = "day.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='dichotomy' and count(parameter)=0]"
		[Register ("dichotomy", "()Z", "")]
		public unsafe bool Dichotomy ()
		{
			const string __id = "dichotomy.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='diff' and count(parameter)=0]"
		[Register ("diff", "()Ljava/lang/String;", "")]
		public unsafe string Diff ()
		{
			const string __id = "diff.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjAll' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjAll", "(Lorg/mozilla/javascript/NativeArray;)Z", "")]
		public unsafe bool ExprObjAll (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjAll.(Lorg/mozilla/javascript/NativeArray;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjAny' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjAny", "(Lorg/mozilla/javascript/NativeArray;)Z", "")]
		public unsafe bool ExprObjAny (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjAny.(Lorg/mozilla/javascript/NativeArray;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjCategories' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjCategories", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjCategories (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjCategories.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjCategoryLabels' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjCategoryLabels", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjCategoryLabels (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjCategoryLabels.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjDomainLabels' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjDomainLabels", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjDomainLabels (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjDomainLabels.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjDomainValues' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjDomainValues", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjDomainValues (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjDomainValues.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjMembers' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjMembers", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjMembers (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjMembers.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjNone' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjNone", "(Lorg/mozilla/javascript/NativeArray;)Z", "")]
		public unsafe bool ExprObjNone (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjNone.(Lorg/mozilla/javascript/NativeArray;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjToString' and count(parameter)=0]"
		[Register ("exprObjToString", "()Ljava/lang/String;", "")]
		public unsafe string ExprObjToString ()
		{
			const string __id = "exprObjToString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='exprObjValues' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
		[Register ("exprObjValues", "(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;", "")]
		public unsafe global::Org.Mozilla.Javascript.NativeArray ExprObjValues (global::Org.Mozilla.Javascript.NativeArray p0)
		{
			const string __id = "exprObjValues.(Lorg/mozilla/javascript/NativeArray;)Lorg/mozilla/javascript/NativeArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.NativeArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='external' and count(parameter)=0]"
		[Register ("external", "()Z", "")]
		public unsafe bool External ()
		{
			const string __id = "external.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='geo' and count(parameter)=0]"
		[Register ("geo", "()Z", "")]
		public unsafe bool Geo ()
		{
			const string __id = "geo.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/String;", "")]
		public unsafe string Get ()
		{
			const string __id = "get.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='inc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inc", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Inc (string p0)
		{
			const string __id = "inc.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='instruction' and count(parameter)=0]"
		[Register ("instruction", "()Ljava/lang/String;", "")]
		public unsafe string Instruction ()
		{
			const string __id = "instruction.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='isect' and count(parameter)=0]"
		[Register ("isect", "()Ljava/lang/String;", "")]
		public unsafe string Isect ()
		{
			const string __id = "isect.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='item' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("item", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects.RhinoExprObj Item (string p0)
		{
			const string __id = "item.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects.RhinoExprObj> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='label' and count(parameter)=0]"
		[Register ("label", "()Ljava/lang/String;", "")]
		public unsafe string Label ()
		{
			const string __id = "label.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='latitude' and count(parameter)=0]"
		[Register ("latitude", "()D", "")]
		public unsafe double Latitude ()
		{
			const string __id = "latitude.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "")]
		public unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='longitude' and count(parameter)=0]"
		[Register ("longitude", "()D", "")]
		public unsafe double Longitude ()
		{
			const string __id = "longitude.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='month' and count(parameter)=0]"
		[Register ("month", "()I", "")]
		public unsafe int Month ()
		{
			const string __id = "month.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='numeric' and count(parameter)=0]"
		[Register ("numeric", "()Z", "")]
		public unsafe bool Numeric ()
		{
			const string __id = "numeric.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "")]
		public unsafe bool Open ()
		{
			const string __id = "open.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string Set (global::Java.Lang.Object p0)
		{
			const string __id = "set.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='text' and count(parameter)=0]"
		[Register ("text", "()Ljava/lang/String;", "")]
		public unsafe string Text ()
		{
			const string __id = "text.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='toBoolean' and count(parameter)=0]"
		[Register ("toBoolean", "()Z", "")]
		public unsafe bool ToBoolean ()
		{
			const string __id = "toBoolean.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='toDate' and count(parameter)=0]"
		[Register ("toDate", "()Ljava/util/Date;", "")]
		public unsafe global::Java.Util.Date ToDate ()
		{
			const string __id = "toDate.()Ljava/util/Date;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='toDecimal' and count(parameter)=0]"
		[Register ("toDecimal", "()D", "")]
		public unsafe double ToDecimal ()
		{
			const string __id = "toDecimal.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='toInt' and count(parameter)=0]"
		[Register ("toInt", "()I", "")]
		public unsafe int ToInt ()
		{
			const string __id = "toInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='toNumber' and count(parameter)=0]"
		[Register ("toNumber", "()D", "")]
		public unsafe double ToNumber ()
		{
			const string __id = "toNumber.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='union' and count(parameter)=0]"
		[Register ("union", "()Ljava/lang/String;", "")]
		public unsafe string Union ()
		{
			const string __id = "union.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "")]
		public unsafe string Value ()
		{
			const string __id = "value.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='valueLabel' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("valueLabel", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ValueLabel (global::Java.Lang.Object p0)
		{
			const string __id = "valueLabel.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino.objects']/class[@name='RhinoExprObj']/method[@name='year' and count(parameter)=0]"
		[Register ("year", "()I", "")]
		public unsafe int Year ()
		{
			const string __id = "year.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
