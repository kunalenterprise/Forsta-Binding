using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/RhinoExecutor", DoNotGenerateAcw=true)]
	public sealed partial class RhinoExecutor : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.IScriptExecutor {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/field[@name='Companion']"
		[Register ("Companion")]
		public static global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.RhinoExecutor.Companion RhinoCompanion {
			get {
				const string __id = "Companion.Lcom/confirmit/mobilesdk/scripting/surveyengine/rhino/RhinoExecutor$Companion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.RhinoExecutor.Companion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/field[@name='scope']"
		[Register ("scope")]
		public static global::Org.Mozilla.Javascript.IScriptable Scope {
			get {
				const string __id = "scope.Lorg/mozilla/javascript/Scriptable;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.IScriptable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "scope.Lorg/mozilla/javascript/Scriptable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/RhinoExecutor$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/RhinoExecutor$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/constructor[@name='RhinoExecutor.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI EngineContext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getEngineContext' and count(parameter)=0]"
				[Register ("getEngineContext", "()Lcom/confirmit/mobilesdk/surveyengine/i;", "")]
				get {
					const string __id = "getEngineContext.()Lcom/confirmit/mobilesdk/surveyengine/i;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='setEngineContext' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i']]"
				[Register ("setEngineContext", "(Lcom/confirmit/mobilesdk/surveyengine/i;)V", "")]
				set {
					const string __id = "setEngineContext.(Lcom/confirmit/mobilesdk/surveyengine/i;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			public unsafe global::Org.Mozilla.Javascript.IScriptable Scope {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getScope' and count(parameter)=0]"
				[Register ("getScope", "()Lorg/mozilla/javascript/Scriptable;", "")]
				get {
					const string __id = "getScope.()Lorg/mozilla/javascript/Scriptable;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Mozilla.Javascript.IScriptable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.Scriptable']]"
				[Register ("setScope", "(Lorg/mozilla/javascript/Scriptable;)V", "")]
				set {
					const string __id = "setScope.(Lorg/mozilla/javascript/Scriptable;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			public unsafe string Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getStatus.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string SurveyChannel {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getSurveyChannel' and count(parameter)=0]"
				[Register ("getSurveyChannel", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getSurveyChannel.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='consoleLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("consoleLog", "(Ljava/lang/String;)V", "")]
			public unsafe void ConsoleLog (string p0)
			{
				const string __id = "consoleLog.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getCustomData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getCustomData", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string GetCustomData (string p0)
			{
				const string __id = "getCustomData.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getForm' and count(parameter)=1 and parameter[1][@type='org.mozilla.javascript.NativeArray']]"
			[Register ("getForm", "(Lorg/mozilla/javascript/NativeArray;)Lcom/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj;", "")]
			public unsafe global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects.RhinoExprObj GetForm (global::Org.Mozilla.Javascript.NativeArray p0)
			{
				const string __id = "getForm.(Lorg/mozilla/javascript/NativeArray;)Lcom/confirmit/mobilesdk/scripting/surveyengine/rhino/objects/RhinoExprObj;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Rhino.Objects.RhinoExprObj> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='getRespondentValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getRespondentValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string GetRespondentValue (string p0)
			{
				const string __id = "getRespondentValue.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='notifyAppFeedback' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("notifyAppFeedback", "(Ljava/lang/Object;)V", "")]
			public unsafe void NotifyAppFeedback (global::Java.Lang.Object p0)
			{
				const string __id = "notifyAppFeedback.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='notifyEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("notifyEvent", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
			public unsafe void NotifyEvent (string p0, global::Java.Lang.Object p1)
			{
				const string __id = "notifyEvent.(Ljava/lang/String;Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor.Companion']/method[@name='setRespondentValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setRespondentValue", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe void SetRespondentValue (string p0, string p1)
			{
				const string __id = "setRespondentValue.(Ljava/lang/String;Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				IntPtr native_p1 = JNIEnv.NewString ((string)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/scripting/surveyengine/rhino/RhinoExecutor", typeof (RhinoExecutor));

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

		internal RhinoExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/constructor[@name='RhinoExecutor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RhinoExecutor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/method[@name='load' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.i'] and parameter[2][@type='java.lang.String']]"
		[Register ("load", "(Lcom/confirmit/mobilesdk/surveyengine/i;Ljava/lang/String;)V", "")]
		public unsafe void Load (global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI p0, string p1)
		{
			const string __id = "load.(Lcom/confirmit/mobilesdk/surveyengine/i;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("run", "(Ljava/lang/String;)V", "")]
		public unsafe void Run (string p0)
		{
			const string __id = "run.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.scripting.surveyengine.rhino']/class[@name='RhinoExecutor']/method[@name='runResult' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("runResult", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object RunResult (global::Java.Lang.Class p0, string p1)
		{
			const string __id = "runResult.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
